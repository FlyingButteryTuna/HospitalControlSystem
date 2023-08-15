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
  public partial class doctors_view_info : Form
  {
    private DataRow doc_;
    private SqlConnection sqlConnection_;
    private doctors_change_recs recWin_;

    private DataTable result_ = new DataTable();

    public doctors_view_info()
    {
      InitializeComponent();
    }

    public doctors_view_info(DataRow doc, SqlConnection connection, doctors_change_recs recWin)
    {
      InitializeComponent();
      doc_ = doc;
      sqlConnection_ = connection;
      recWin_ = recWin;

      groupBox1.Controls.Add(radioButtonAmountPlanned);
      groupBox1.Controls.Add(radioButtonPastApps);
      groupBox1.Controls.Add(radioButtonPatients);
      groupBox1.Controls.Add(radioButtonPlannedApps);
      radioButtonPlannedApps.Checked = true;
      mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      mainGrid.AllowUserToAddRows = false;
      mainGrid.ReadOnly = true;
      

      getPlannedAps();
    }

    private void getPlannedAps() 
    {
      result_.Columns.Clear();
      result_.Rows.Clear();
      result_.Clear();

      sqlConnection_.Open();
      String dateTmp = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
      String query = "select p.FullName as 'PatientName', d.FullName as 'DoctorName', a.DateTimeOfAppointmet " +
        "from Appointments as a inner join Doctors as d on d.IdDoctor = a.DoctorId " +
        "and CAST(DateTimeOfAppointmet as date) >= '" + dateTmp + "' " +
        "and AppointmentStatusId = (select IdAppointmentStatus from AppointmentStatus where StatusName = 'Создан') " +
        "and d.IdDoctor = " + doc_["IdDoctor"].ToString() +
        " inner join Patients as p on p.IdPatient = a.PatientId";

      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable apps = new DataTable();
      sda.Fill(apps);

      result_.Columns.Add("Имя пациента");
      result_.Columns.Add("Дата и время");

      for (int i = 0; i < apps.Rows.Count; i++)
      {
        DataRow rw = result_.NewRow();
        rw["Имя пациента"] = apps.Rows[i]["PatientName"].ToString();
        rw["Дата и время"] = apps.Rows[i]["DateTimeOfAppointmet"].ToString();

        result_.Rows.Add(rw);
      }
      mainGrid.DataSource = result_;
      sqlConnection_.Close();
    }

    private void getPatients() 
    {
      result_.Columns.Clear();
      result_.Rows.Clear();
      result_.Clear();

      sqlConnection_.Open();
      String dateTmp = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
      String query = "Select distinct p.FullName, p.PassportNumber, p.InsuranceNumber, p.PhoneNumber, p.Gender from Appointments as a " +
                        "inner join Patients as p on a.PatientId = p.IdPatient " +
                        "inner join Doctors as d on d.IdDoctor = a.DoctorId " +
                        "and d.IdDoctor = " + doc_["IdDoctor"].ToString();

      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable apps = new DataTable();
      sda.Fill(apps);

      result_.Columns.Add("Имя пациента");
      result_.Columns.Add("Паспорт");
      result_.Columns.Add("Страховка");
      result_.Columns.Add("Номер телефона");
      result_.Columns.Add("Пол");

      for (int i = 0; i < apps.Rows.Count; i++)
      {
        DataRow rw = result_.NewRow();
        rw["Имя пациента"] = apps.Rows[i]["FullName"].ToString();
        rw["Паспорт"] = apps.Rows[i]["PassportNumber"].ToString();
        rw["Страховка"] = apps.Rows[i]["InsuranceNumber"].ToString();
        rw["Номер телефона"] = apps.Rows[i]["PhoneNumber"].ToString();
        rw["Пол"] = apps.Rows[i]["Gender"].ToString();

        result_.Rows.Add(rw);
      }
      mainGrid.DataSource = result_;
      sqlConnection_.Close();
    }

    private void getPreviousApps() 
    {
      result_.Columns.Clear();
      result_.Rows.Clear();
      result_.Clear();

      sqlConnection_.Open();
      String dateTmp = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
      String query = "select * " +
        "from Appointments_full as a inner join Doctors as d on d.IdDoctor = a.IdDoctor " +
        //"and CAST(DateTimeOfAppointmet as date) <= '" + dateTmp + "' " +
        "and StatusName = \'Завершен\' " +
        "and d.IdDoctor = " + doc_["IdDoctor"].ToString() +
        " inner join Patients as p on p.IdPatient = a.IdPatient";

      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable apps = new DataTable();
      sda.Fill(apps);

      result_.Columns.Add("Имя пациента");
      result_.Columns.Add("Дата и время");
      result_.Columns.Add("Жалобы");
      result_.Columns.Add("Рекомендации");
      result_.Columns.Add("Статус");

      for (int i = 0; i < apps.Rows.Count; i++)
      {
        DataRow rw = result_.NewRow();
        rw["Имя пациента"] = apps.Rows[i]["PatientName"].ToString();
        rw["Дата и время"] = apps.Rows[i]["DateTimeOfAppointmet"].ToString();
        rw["Жалобы"] = apps.Rows[i]["Complaints"].ToString();
        rw["Рекомендации"] = apps.Rows[i]["Recommendations"].ToString();
        rw["Статус"] = apps.Rows[i]["StatusName"].ToString();

        result_.Rows.Add(rw);
      }
      mainGrid.DataSource = result_;
      sqlConnection_.Close();
    }

    private void countPlannedApps()
    {
      result_.Columns.Clear();
      result_.Rows.Clear();
      result_.Clear();

      sqlConnection_.Open();
      String dateTmp = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
      String query = "select d.FullName as 'DoctorName', count(IdAppointment) as \'result\' " +
        "from Appointments as a inner join Doctors as d on d.IdDoctor = a.DoctorId " +
        "and CAST(DateTimeOfAppointmet as date) >= '" + dateTmp + "' " +
        "and AppointmentStatusId = (select IdAppointmentStatus from AppointmentStatus where StatusName = 'Создан') " +
        "and d.IdDoctor = " + doc_["IdDoctor"].ToString() +
        " inner join Patients as p on p.IdPatient = a.PatientId group by d.FullName";

      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable apps = new DataTable();
      sda.Fill(apps);

      result_.Columns.Add("Имя доктора");
      result_.Columns.Add("Кол-во запланированных приемов");

      for (int i = 0; i < apps.Rows.Count; i++)
      {
        DataRow rw = result_.NewRow();
        rw["Имя доктора"] = apps.Rows[i]["DoctorName"].ToString();
        rw["Кол-во запланированных приемов"] = apps.Rows[i]["result"].ToString();

        result_.Rows.Add(rw);
      }
      mainGrid.DataSource = result_;
      sqlConnection_.Close();
    }

    private void btnChangeAps_Click(object sender, EventArgs e)
    {
      this.Hide();
      recWin_.Show();
    }

    private void radioButtonPlannedApps_CheckedChanged(object sender, EventArgs e)
    {
      callInfoFun();
    }

    private void radioButtonPatients_CheckedChanged(object sender, EventArgs e)
    {
      callInfoFun();
    }

    private void radioButtonPastApps_CheckedChanged(object sender, EventArgs e)
    {
      callInfoFun();
    }

    private void radioButtonAmountPlanned_CheckedChanged(object sender, EventArgs e)
    {
      callInfoFun();
    }

    private void callInfoFun() 
    {
      if (radioButtonPlannedApps.Checked)
      {
        getPlannedAps();
      }
      else if (radioButtonPatients.Checked)
      {
        getPatients();
      }
      else if (radioButtonPastApps.Checked)
      {
        getPreviousApps();
      }
      else if (radioButtonAmountPlanned.Checked)
      {
        countPlannedApps();
      }
    
    }

  }
}
