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
  public partial class FDWviewinfo : Form
  {
    private FDWChnageProfile changeProfileWindow_;
    private FrontDeskWorker receprionistWindow_;
    private DataRow receptionist_;
    private SqlConnection sqlConnection_;

    private DataTable result = new DataTable();

    public FDWviewinfo()
    {
      InitializeComponent();
    }

    public FDWviewinfo(DataRow receptionist, FDWChnageProfile changeProfile, FrontDeskWorker receptionistWindow, SqlConnection connection)
    {
      InitializeComponent();
      changeProfileWindow_ = changeProfile;
      receprionistWindow_ = receptionistWindow;
      receptionist_ = receptionist;
      sqlConnection_ = connection;

      mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      mainGrid.AllowUserToAddRows = false;
      mainGrid.ReadOnly = true;
      groupBox1.Controls.Add(radioButtonDayApp);
      groupBox1.Controls.Add(radioButtonDayPatients);
      groupBox1.Controls.Add(radioButtonFreeDoc);
      radioButtonDayApp.Checked = true;
      monthCalendar.MaxSelectionCount = 1;
      getAppoinmentsForTheDay();

    }

    private void getAppoinmentsForTheDay() 
    {
      String date = monthCalendar.SelectionStart.Year.ToString() + "-" +
        monthCalendar.SelectionStart.Month.ToString() + "-" +
        monthCalendar.SelectionStart.Day.ToString();

      String query = "Select distinct * from Appointments_full where CAST(DateTimeOfAppointmet as date) = '" + date + "'" +
        " and StatusName = '" + "Создан" + "'";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable apps = new DataTable();
      sda.Fill(apps);

      result.Columns.Clear();
      result.Rows.Clear();
      result.Clear();
      
      result.Columns.Add("Имя пациента");
      result.Columns.Add("Имя доктора");
      result.Columns.Add("Дата");
      result.Columns.Add("Статус");
      result.Columns.Add("Рекомендации");
      result.Columns.Add("Жалобы");

      for (int i = 0; i < apps.Rows.Count; i++) {
        DataRow rw = result.NewRow();
        rw["Имя пациента"] = apps.Rows[i]["PatientName"].ToString();
        rw["Имя доктора"] = apps.Rows[i]["DoctorName"].ToString();
        rw["Дата"] = apps.Rows[i]["DateTimeOfAppointmet"].ToString();
        rw["Статус"] = apps.Rows[i]["StatusName"];
        rw["Рекомендации"] = apps.Rows[i]["Recommendations"];
        rw["Жалобы"] = apps.Rows[i]["Complaints"];
        result.Rows.Add(rw);
      }
      mainGrid.DataSource = result;
    }

    private void getPatientsForTheDay()
    {
      String date = monthCalendar.SelectionStart.Year.ToString() + "-" +
        monthCalendar.SelectionStart.Month.ToString() + "-" +
        monthCalendar.SelectionStart.Day.ToString();

      String query = "select distinct FullName, Gender, InsuranceNumber, PassportNumber, PhoneNumber from Patients " +
        "inner join Appointments as a on IdPatient = a.PatientId and CAST(DateTimeOfAppointmet as date) = '" + date + "'" +
        "and a.AppointmentStatusId = (select b.IdAppointmentStatus from AppointmentStatus as b where StatusName = 'Создан')";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable patients = new DataTable();
      sda.Fill(patients);

      result.Columns.Clear();
      result.Rows.Clear();
      result.Clear();

      result.Columns.Add("Имя пациента");
      result.Columns.Add("Пол");
      result.Columns.Add("Номер страховки");
      result.Columns.Add("Номер паспорта");
      result.Columns.Add("Номер телефона");

      for (int i = 0; i < patients.Rows.Count; i++)
      {
        DataRow rw = result.NewRow();
        rw["Имя пациента"] = patients.Rows[i]["FullName"].ToString();
        rw["Пол"] = patients.Rows[i]["Gender"].ToString();
        rw["Номер страховки"] = patients.Rows[i]["InsuranceNumber"].ToString();
        rw["Номер паспорта"] = patients.Rows[i]["PassportNumber"];
        rw["Номер телефона"] = patients.Rows[i]["PhoneNumber"];
        result.Rows.Add(rw);
      }
      mainGrid.DataSource = result;
    }

    private void getFreeDoctorsForTheDay() 
    {
      String date = monthCalendar.SelectionStart.Year.ToString() + "-" +
        monthCalendar.SelectionStart.Month.ToString() + "-" +
        monthCalendar.SelectionStart.Day.ToString();

      String query = "(select distinct d.FullName, d.PassportNumber, d.PhoneNumber, s.SpecializationName from Doctors as d " +
        "inner join Specializations as s on s.IdSpecialization = d.SpecializationId) " +
        "except " +
        "(select distinct FullName, PassportNumber, PhoneNumber, s.SpecializationName from Doctors " +
        "inner join Appointments as a on CAST(a.DateTimeOfAppointmet as date) = '" + date + "' " + 
        "and a.AppointmentStatusId = (select b.IdAppointmentStatus from AppointmentStatus as b " +
        "where StatusName = 'Создан') " +
	      "inner join Specializations as s on s.IdSpecialization = SpecializationId " +
        "where IdDoctor = a.DoctorId)";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable doctors = new DataTable();
      sda.Fill(doctors);

      result.Columns.Clear();
      result.Rows.Clear();
      result.Clear();

      result.Columns.Add("Имя доктора");
      result.Columns.Add("Номер паспорта");
      result.Columns.Add("Номер телефона");
      result.Columns.Add("Специализация");
      

      for (int i = 0; i < doctors.Rows.Count; i++)
      {
        DataRow rw = result.NewRow();
        rw["Имя доктора"] = doctors.Rows[i]["FullName"].ToString();
        rw["Номер паспорта"] = doctors.Rows[i]["PassportNumber"];
        rw["Номер телефона"] = doctors.Rows[i]["PhoneNumber"];
        rw["Специализация"] = doctors.Rows[i]["SpecializationName"].ToString();
        
        result.Rows.Add(rw);
      }
      mainGrid.DataSource = result;
    }

    private void btnInformation_Click(object sender, EventArgs e)
    {
      this.Hide();
      changeProfileWindow_.Show();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
      this.Hide();
      receprionistWindow_.Show();
    }

    private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
    {
      if (radioButtonDayApp.Checked)
      {
        getAppoinmentsForTheDay();
      }
      else if (radioButtonDayPatients.Checked)
      {
        getPatientsForTheDay();
      }
      else {
        getFreeDoctorsForTheDay();
      }
    }

    private void radioButtonDayApp_CheckedChanged(object sender, EventArgs e)
    {
      if (radioButtonDayApp.Checked)
      {
        getAppoinmentsForTheDay();
      }
      else if (radioButtonDayPatients.Checked)
      {
        getPatientsForTheDay();
      }
      else
      {
        getFreeDoctorsForTheDay();
      }
    }

    private void radioButtonDayPatients_CheckedChanged(object sender, EventArgs e)
    {
      if (radioButtonDayApp.Checked)
      {
        getAppoinmentsForTheDay();
      }
      else if (radioButtonDayPatients.Checked)
      {
        getPatientsForTheDay();
      }
      else
      {
        getFreeDoctorsForTheDay();
      }
    }

    private void radioButtonFreeDoc_CheckedChanged(object sender, EventArgs e)
    {
      if (radioButtonDayApp.Checked)
      {
        getAppoinmentsForTheDay();
      }
      else if (radioButtonDayPatients.Checked)
      {
        getPatientsForTheDay();
      }
      else
      {
        getFreeDoctorsForTheDay();
      }
    }
  }
}
