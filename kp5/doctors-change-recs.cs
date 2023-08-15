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
  public partial class doctors_change_recs : Form
  {

    private DataTable result_;
    private DataRow doc_;
    private SqlConnection sqlConnection_;
    private doctors_view_info viewWin_;
    private addRecs recsWin_;
    private LoginScreen lgScreen_;
    private docs_change_psw changePsw_;

    public doctors_change_recs()
    {
      InitializeComponent();


    }

    public doctors_change_recs(DataRow doc, SqlConnection connection, LoginScreen lgScreen)
    {
      InitializeComponent();

      sqlConnection_ = connection;
      doc_ = doc;
      mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      mainGrid.AllowUserToAddRows = false;
      mainGrid.CurrentCellDirtyStateChanged += changedCompl;

      result_ = new DataTable();
      viewWin_ = new doctors_view_info(doc_, sqlConnection_, this);

      recsWin_ = new addRecs(sqlConnection_, this);
      lgScreen_ = lgScreen;

      changePsw_ = new docs_change_psw(sqlConnection_, this, doc_);

      getAppointments();
    }

    private void getAppointments()
    {
      result_.Columns.Clear();
      result_.Rows.Clear();
      result_.Clear();

      sqlConnection_.Open();
      String query = "select * from Appointments_full where IdDoctor = '" + doc_["IdDoctor"] + "'";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable apps = new DataTable();
      sda.Fill(apps);
      sqlConnection_.Close();



      sqlConnection_.Open();
      DataGridViewComboBoxColumn status = new DataGridViewComboBoxColumn();
      status.HeaderText = "Статус";
      status.Name = "Статус";
      status.DataPropertyName = "Статус";
      status.Items.AddRange("Не явился", "Создан", "Завершен");

       DataGridViewComboBoxColumn complaints = new DataGridViewComboBoxColumn();
      complaints.HeaderText = "Жалобы";
      complaints.Name = "Жалобы";
      complaints.DataPropertyName = "Жалобы";

       query = "select Complaints from AppointmentsContent";
       sda = new SqlDataAdapter(query, sqlConnection_);
       DataTable compl = new DataTable();
       sda.Fill(compl);
       for (int i = 0; i < compl.Rows.Count; i++) {
         complaints.Items.Add(compl.Rows[i]["Complaints"].ToString().Trim());
         Console.WriteLine(compl.Rows[i]["Complaints"]);
       }

      result_.Columns.Add("AppId").ReadOnly = true;
      result_.Columns.Add("Имя пациента").ReadOnly = true;
      result_.Columns.Add("Дата и время").ReadOnly = true;
      result_.Columns.Add("Статус", typeof(String));
      result_.Columns.Add("Жалобы", typeof(String));
      result_.Columns.Add("Рекомендации");

      int k = 0;

      for (int i = 0; i < apps.Rows.Count; i++)
      {
        String datetmp = apps.Rows[i]["DateTimeOfAppointmet"].ToString();

        DateTime tmp = DateTime.Parse(datetmp);
        if (tmp < DateTime.Now)
        {
          continue;
        }

        if (apps.Rows[i]["StatusName"].ToString() == "Отменен" || apps.Rows[i]["StatusName"].ToString() == "Не явился" ||
            apps.Rows[i]["StatusName"].ToString() == "Завершен")
        {
          continue;
        }

        DataRow rw = result_.NewRow();
        rw["AppId"] = apps.Rows[i]["IdAppointment"].ToString();
        rw["Имя пациента"] = apps.Rows[i]["PatientName"].ToString();
        rw["Дата и время"] = apps.Rows[i]["DateTimeOfAppointmet"].ToString().Trim();
        rw["Статус"] = apps.Rows[i]["StatusName"].ToString();
        rw["Жалобы"] = apps.Rows[i]["Complaints"].ToString();
        rw["Рекомендации"] = apps.Rows[i]["Recommendations"].ToString();
        result_.Rows.Add(rw);

        k++;
      }

      mainGrid.DataSource = result_;
      mainGrid.Columns[0].Visible = false;
      mainGrid.Columns[3].Visible = false;
      mainGrid.Columns[4].Visible = false;
      mainGrid.Columns.Add(status);
      mainGrid.Columns.Add(complaints);

      sqlConnection_.Close();
    }

    private void changedCompl(object sender, EventArgs e) { 
      if (mainGrid.CurrentCell is DataGridViewComboBoxCell && mainGrid.CurrentCell.ColumnIndex == 7)
      {
        String query = "select Recommendations from AppointmentsContent where Complaints = '"
          + mainGrid.CurrentCell.Value.ToString() + "'";
        SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
        DataTable rec = new DataTable();
        sda.Fill(rec);

        mainGrid.Rows[mainGrid.CurrentRow.Index].Cells[5].Value = rec.Rows[0]["Recommendations"].ToString();
        mainGrid.Rows[mainGrid.CurrentRow.Index].Cells[5].Selected = true;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      sqlConnection_.Open();
      for (int i = 0; i < mainGrid.Rows.Count; i++)
      {
        String query = 
          "update Appointments " +
          "set AppointmentStatusId = (" +
          "select IdAppointmentStatus from AppointmentStatus where StatusName = '" 
          + mainGrid.Rows[i].Cells[6].Value.ToString() + "'" + "), " 
          + "AppoinmentContentId = " + "(select IdAppointmentContent from AppointmentsContent" +
          " where Recommendations = '" + mainGrid.Rows[i].Cells[5].Value.ToString() + "') " +
          " where IdAppointment = " + mainGrid.Rows[i].Cells[0].Value.ToString();
        SqlCommand command = new SqlCommand(query, sqlConnection_);
        command.ExecuteNonQuery();
      }
      sqlConnection_.Close();
      MessageBox.Show("Изменения сохранены");
    }

    private void btnInfo_Click(object sender, EventArgs e)
    {
      this.Hide();
      viewWin_.Show();
    }

    private void btnAddRecs_Click(object sender, EventArgs e)
    {
      recsWin_.Show();
      this.Hide();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      viewWin_.Close();
      recsWin_.Close();
      lgScreen_.Show();
      changePsw_.Close();
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      changePsw_.Show();
      this.Hide();
    }

    private void btnExit_Click_1(object sender, EventArgs e)
    {
      viewWin_.Close();
      lgScreen_.Show();
      this.Close();
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      changePsw_.Show();
      this.Hide();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      getAppointments();
    }
  }
}
