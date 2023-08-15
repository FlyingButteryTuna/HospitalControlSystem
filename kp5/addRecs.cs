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
  public partial class addRecs : Form
  {
    private doctors_change_recs recWin_;
    private SqlConnection sqlConnection_;

    public addRecs()
    {
      InitializeComponent();
    }

    public addRecs(SqlConnection connection, doctors_change_recs recWin)
    {
      InitializeComponent();
      sqlConnection_ = connection;
      recWin_ = recWin;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (textBoxComps.Text.Length == 0 || textBoxrecs.Text.Length == 0) {
        MessageBox.Show("Провертье пустые поля.");
        return;
      }

      String query = "insert into AppointmentsContent (Recommendations, Complaints) values (" +
        "@Recommendations, @Complaints)";
      SqlCommand sda = new SqlCommand(query, sqlConnection_);
      sda.Parameters.AddWithValue("@Recommendations", textBoxrecs.Text);
      sda.Parameters.AddWithValue("@Complaints", textBoxComps.Text);
      sqlConnection_.Open();
      sda.ExecuteNonQuery();
      sqlConnection_.Close();
      MessageBox.Show("Изменения сохранены.");
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
      recWin_.Show();
      this.Hide();
    }
  }
}
