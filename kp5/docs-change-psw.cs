using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kp5
{
  public partial class docs_change_psw : Form
  {
    private SqlConnection sqlConnection_;
    private object previousWin_;
    private DataRow user_;

    public docs_change_psw()
    {
      InitializeComponent();
    }

    public docs_change_psw(SqlConnection connection, object previosWin, DataRow user)
    {
      InitializeComponent();
      user_ = user;
      previousWin_ = previosWin;
      sqlConnection_ = connection;
      textBoxNew.UseSystemPasswordChar = true;
      textBoxOld.UseSystemPasswordChar = true;
      textBoxNew.MaxLength = 50;
      textBoxOld.MaxLength = 50;
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
      this.Hide();
      (previousWin_ as Form).Show();
    }

    private void checkBoxOld_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxOld.Checked)
      {
        textBoxOld.UseSystemPasswordChar = false;
      }
      else {
        textBoxOld.UseSystemPasswordChar = true;
      }
    }

    private void checkBoxNew_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxNew.Checked)
      {
        textBoxNew.UseSystemPasswordChar = false;
      }
      else
      {
        textBoxNew.UseSystemPasswordChar = true;
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (textBoxNew.Text.Length == 0 || textBoxOld.Text.Length == 0) {
        MessageBox.Show("Провертье пустые поля.");
        return;
      }

      String oldPsw = textBoxOld.Text;
      String query = "Select * from Users Where IdUser = " + user_["UserId"].ToString();

      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable users = new DataTable();
      sda.Fill(users);
      if (StringCipher.Decrypt(users.Rows[0]["Password"].ToString(), LoginScreen.password) != oldPsw) {
        MessageBox.Show("Старый пароль введен неверно.");
        return;
      }

      query = "update Users set Password = '" + StringCipher.Encrypt(textBoxNew.Text, LoginScreen.password) + "' where IdUser = " + user_["UserId"];
      SqlCommand cmd = new SqlCommand(query, sqlConnection_);
      sqlConnection_.Open();
      cmd.ExecuteNonQuery();
      sqlConnection_.Close();
      MessageBox.Show("Изменения сохранены.");
    }
  }
}
