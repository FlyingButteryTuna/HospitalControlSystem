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
  public partial class PatientViewInfo : Form
  {
    private PatientAppoointments appWindow_;
    private PatientChangeApp changeApp_;
    private DataRow patient_;
    private SqlConnection sqlConnection_;

    private SqlCommand getSchedule_;

    private DataTable result_;

    public PatientViewInfo()
    {
      InitializeComponent();
    }

    public PatientViewInfo(DataRow patient, SqlConnection connection, PatientAppoointments appWindow, PatientChangeApp changeApp)
    {
      InitializeComponent();
      appWindow_ = appWindow;
      changeApp_ = changeApp;
      patient_ = patient;
      sqlConnection_ = connection;

      mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      mainGrid.ReadOnly = true;
      comboBoxSpec.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBoxDoc.DropDownStyle = ComboBoxStyle.DropDownList;

      getSchedule_ = new SqlCommand("ViewDoctorsSchedule", sqlConnection_);
      getSchedule_.CommandType = CommandType.StoredProcedure;

      String query = "Select distinct SpecializationName from Specializations";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable specs = new DataTable();
      sda.Fill(specs);

      for (int i = 0; i < specs.Rows.Count; i++)
      {
        comboBoxSpec.Items.Add(specs.Rows[i]["SpecializationName"].ToString());
      }

      comboBoxSpec.Visible = false;
      labelChooseSpec.Visible = false;
      comboBoxDoc.Visible = false;
      labelDoc.Visible = false;

      groupBoxButtons.Controls.Add(radioButtonApps);
      groupBoxButtons.Controls.Add(radioButtonDocs);
      groupBoxButtons.Controls.Add(radioButtonScheduleSpecDoc);

      result_ = new DataTable();
      radioButtonApps.Checked = true;

      mainGrid.AllowUserToAddRows = false;
      getAppointments();
    }

    
    private void patient_view_info_Load(object sender, EventArgs e)
    {

    }

    private void radioButtonApps_CheckedChanged(object sender, EventArgs e)
    {
      callInfoFunction();
    }

    private void radioButtonDocs_CheckedChanged(object sender, EventArgs e)
    {
      callInfoFunction();
    }

    private void radioButtonScheduleSpecDoc_CheckedChanged(object sender, EventArgs e)
    {
      callInfoFunction();
    }

    private void radioButtonScheduleDoc_CheckedChanged(object sender, EventArgs e)
    {
      callInfoFunction();
    }

    private void callInfoFunction() 
    {
      if (radioButtonApps.Checked)
      {
        getAppointments();
        comboBoxSpec.Visible = false;
        labelChooseSpec.Visible = false;
        labelDoc.Visible = false;
        comboBoxDoc.Visible = false;
      }
      else if (radioButtonDocs.Checked)
      {
        getDoctors();
        comboBoxSpec.Visible = false;
        labelChooseSpec.Visible = false;
        labelDoc.Visible = false;
        comboBoxDoc.Visible = false;
      }
      else if (radioButtonScheduleSpecDoc.Checked)
      {
        if (comboBoxSpec.SelectedItem == null) {
          comboBoxSpec.SelectedIndex = 0;
        }
        
        comboBoxSpec.Visible = true;
        labelChooseSpec.Visible = true;

        comboBoxDoc.Items.Clear();
        labelDoc.Text = "Выберите дату";
        DateTime tmp = DateTime.Now;
        for (int i = 0; i < 7; i++)
        {
          String tmpDate = tmp.Year.ToString() + "-" + tmp.Month.ToString() + "-" + tmp.Day.ToString();
          comboBoxDoc.Items.Add("" + tmpDate);
          tmp = tmp.AddDays(1);
        }
        comboBoxDoc.SelectedIndex = 0;
        labelDoc.Visible = true;
        comboBoxDoc.Visible = true;
        getDoctorsSpec();
      }
    }


    private void getAppointments() 
    {
      result_.Columns.Clear();
      result_.Rows.Clear();
      result_.Clear();

      sqlConnection_.Open();
      String query = "select * from Appointments_full where IdPatient = '" + patient_["IdPatient"] + "'";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable apps = new DataTable();
      sda.Fill(apps);


      result_.Columns.Add("Имя доктора");
      result_.Columns.Add("Дата и время");
      result_.Columns.Add("Статус");
      result_.Columns.Add("Жалобы");
      result_.Columns.Add("Рекомендации");

      for (int i = 0; i < apps.Rows.Count; i++) {
        DataRow rw = result_.NewRow();
        rw["Имя доктора"] = apps.Rows[i]["DoctorName"].ToString();
        rw["Дата и время"] = apps.Rows[i]["DateTimeOfAppointmet"].ToString();
        rw["Статус"] = apps.Rows[i]["StatusName"].ToString();
        rw["Жалобы"] = apps.Rows[i]["Complaints"].ToString();
        rw["Рекомендации"] = apps.Rows[i]["Recommendations"].ToString();
        result_.Rows.Add(rw);
      }
      mainGrid.DataSource = result_;
      sqlConnection_.Close();
    }

    private void getDoctors() 
    {
      result_.Columns.Clear();
      result_.Rows.Clear();
      result_.Clear();

      sqlConnection_.Open();
      String query = "select * from Doctors_with_spec";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable docs = new DataTable();
      sda.Fill(docs);

      result_.Columns.Add("Имя доктора");
      result_.Columns.Add("Пол");
      result_.Columns.Add("Номер телефона");
      result_.Columns.Add("Специализация");

      for (int i = 0; i < docs.Rows.Count; i++)
      {
        DataRow rw = result_.NewRow();
        rw["Имя доктора"] = docs.Rows[i]["FullName"].ToString();
        rw["Пол"] = docs.Rows[i]["Gender"].ToString();
        rw["Номер телефона"] = docs.Rows[i]["PhoneNumber"].ToString();
        rw["Специализация"] = docs.Rows[i]["SpecializationName"].ToString();
        result_.Rows.Add(rw);
      }
      mainGrid.DataSource = result_;
      sqlConnection_.Close();
    }

    private void getDoctorsSpec() 
    {
      result_.Columns.Clear();
      result_.Rows.Clear();
      result_.Clear();

      if (comboBoxSpec.SelectedItem == null || comboBoxDoc.SelectedItem == null) {
        return;
      }

      sqlConnection_.Open();
      String query = "select * from Doctors_with_spec where SpecializationName = '" + comboBoxSpec.Text.Trim() + "'";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable docs = new DataTable();
      sda.Fill(docs);
      sqlConnection_.Close();
       
     
      result_.Columns.Add("Имя доктора");
      result_.Columns.Add("Доступное время");

      for (int i = 0; i < docs.Rows.Count; i++)
      {
        getSchedule_.Parameters.AddWithValue("@DoctorId", docs.Rows[i]["IdDoctor"]);
        getSchedule_.Parameters.AddWithValue("@Date", comboBoxDoc.SelectedItem.ToString());
        sqlConnection_.Open();
        getSchedule_.ExecuteNonQuery();

        query = "select Time1 from ##TempSchedule";
        sda = new SqlDataAdapter(query, sqlConnection_);
        DataTable schedule = new DataTable();
        sda.Fill(schedule);
        sqlConnection_.Close();

        DataRow rw = result_.NewRow();
        rw["Имя доктора"] = docs.Rows[i]["FullName"].ToString();
        String scheduleDoc = "";
        for (int j = 0; j < schedule.Rows.Count; j++) {
          scheduleDoc += schedule.Rows[j]["Time1"].ToString() + " ";
          
        }
        rw["Доступное время"] = scheduleDoc;
        result_.Rows.Add(rw);
        getSchedule_.Parameters.Clear();
        
      }
      mainGrid.DataSource = result_;
    }


    private void comboBoxSpec_SelectedIndexChanged(object sender, EventArgs e)
    {
        getDoctorsSpec();
    }

    private void comboBoxDoc_SelectedIndexChanged(object sender, EventArgs e)
    {
        getDoctorsSpec();
    }

    private void btnRegAps_Click(object sender, EventArgs e)
    {
      this.Hide();
      appWindow_.Show();
    }

    private void btnChangeAps_Click(object sender, EventArgs e)
    {
      this.Hide();
      changeApp_.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      callInfoFunction();
    }
  }
}
