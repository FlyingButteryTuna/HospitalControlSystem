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
  public partial class PatientAppoointments : Form
  {
    private DataRow patient_;
    private SqlConnection sqlConnection_;
    
    private SqlCommand getSchedule_;

    private String currentDocName_;
    private String currentDocPhone_;

    private String currentDateTime_ = "";

    private PatientViewInfo viewInfoWindow_;
    private PatientChangeApp changeAppWindow_;

    private docs_change_psw changePsw_;
    private LoginScreen lgScreen_;

    public PatientAppoointments()
    {
      InitializeComponent();
    }

    public PatientAppoointments(DataRow patient, SqlConnection connection, LoginScreen lgScreen)
    {
      InitializeComponent();
      sqlConnection_ = connection;
      patient_ = patient;

      getSchedule_ = new SqlCommand("ViewDoctorsSchedule", sqlConnection_);
      getSchedule_.CommandType = CommandType.StoredProcedure;

      String query = "Select distinct SpecializationName from Specializations";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable specs = new DataTable();
      sda.Fill(specs);

      for (int i = 0; i < specs.Rows.Count; i++) {
        comboBoxSpec.Items.Add(specs.Rows[i]["SpecializationName"].ToString());
      }

      comboBoxSpec.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBoxDoc.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBoxDate.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBoxTime.DropDownStyle = ComboBoxStyle.DropDownList;

      changePsw_ = new docs_change_psw(sqlConnection_, this, patient_);

      lgScreen_ = lgScreen;


      changeAppWindow_ = new PatientChangeApp(patient_, connection, this);
      viewInfoWindow_ = new PatientViewInfo(patient_, connection, this, changeAppWindow_);
      changeAppWindow_.setViewWindow(viewInfoWindow_);
    }

    private void patient_appoointments_Load(object sender, EventArgs e)
    {

    }

    private void comboBoxSpec_SelectedIndexChanged(object sender, EventArgs e)
    {
      comboBoxDate.Items.Clear();
      comboBoxDoc.Items.Clear();
      if (comboBoxSpec.SelectedItem == null) {
        return;
      }
      String selectedSpec = comboBoxSpec.SelectedItem.ToString();

      String query = "Select distinct FullName, PhoneNumber from Doctors where SpecializationId = "
        + "(select IdSpecialization from Specializations where SpecializationName = '" + selectedSpec + "')";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable docs = new DataTable();
      sda.Fill(docs);
      comboBoxDoc.Items.Clear();
      for (int i = 0; i < docs.Rows.Count; i++) {
        comboBoxDoc.Items.Add("" + docs.Rows[i]["FullName"] + ", " + docs.Rows[i]["PhoneNumber"]);
      }
    }

    private void comboBoxDoc_SelectedIndexChanged(object sender, EventArgs e)
    {
      comboBoxDate.Items.Clear();
      DateTime tmp = DateTime.Now;
      for (int i = 0; i < 7; i++) {
        String tmpDate = tmp.Year.ToString() + "-" + tmp.Month.ToString() + "-" + tmp.Day.ToString();
        comboBoxDate.Items.Add("" + tmpDate);
        tmp = tmp.AddDays(1);
      }
    }


    private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
    {
      comboBoxTime.Items.Clear();
      String selectedDoc = comboBoxDoc.SelectedItem.ToString();

      String fullname = selectedDoc.Split(',')[0];
      String phoneNumber = selectedDoc.Split(',')[1].Substring(1, selectedDoc.Split(',')[1].Length - 1);

      String query = "Select distinct IdDoctor from Doctors where FullName = '" + fullname + "'" +
        " and PhoneNumber = '" + phoneNumber + "'";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable docid = new DataTable();
      sda.Fill(docid);

      String date = comboBoxDate.SelectedItem.ToString();

      getSchedule_.Parameters.AddWithValue("@DoctorId", docid.Rows[0]["IdDoctor"]);
      getSchedule_.Parameters.AddWithValue("@Date", date);
      sqlConnection_.Open();
      getSchedule_.ExecuteNonQuery();

      query = "select Time1 from ##TempSchedule";
      sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable schedule = new DataTable();

      sda.Fill(schedule);
      DateTime tmp = DateTime.Now;
      for (int i = 0; i < schedule.Rows.Count; i++)
      {
        comboBoxTime.Items.Add("" + schedule.Rows[i]["Time1"]);
      }
      sqlConnection_.Close();
      getSchedule_.Parameters.Clear();
      currentDocName_ = fullname;
      currentDocPhone_ = phoneNumber;
    }

    private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
    {
      currentDateTime_ = comboBoxDate.SelectedItem.ToString() + " " + comboBoxTime.SelectedItem.ToString();
    }

    private void btnApplyForApp_Click(object sender, EventArgs e)
    {
      if (currentDateTime_ == "")
      {
        MessageBox.Show("Проверьте на пустые поля.");
        return;
      }
      String queryDoc = "select IdDoctor from Doctors where FullName = '" + currentDocName_ + "' and" +
        " PhoneNumber = '" + currentDocPhone_ + "'";

      SqlDataAdapter sda = new SqlDataAdapter(queryDoc, sqlConnection_);
      DataTable iddoc = new DataTable();
      sda.Fill(iddoc);

      String query = "insert into Appointments(PatientId, DoctorId, DateTimeOfAppointmet, AppoinmentContentId, AppointmentStatusId) values " +
        "(@PatientId, @DoctorId, @DateTimeOfAppointment, @AppoinmentContentId, @AppointmentStatusId)";
      SqlCommand command = new SqlCommand(query, sqlConnection_);
      sqlConnection_.Open();
      command.Parameters.AddWithValue("@PatientId", SqlDbType.Int).Value = patient_["IdPatient"].ToString();
      command.Parameters.AddWithValue("@DoctorId", SqlDbType.Int).Value = iddoc.Rows[0]["IdDoctor"].ToString();
      command.Parameters.AddWithValue("@DateTimeOfAppointment", SqlDbType.DateTime).Value = currentDateTime_;
      command.Parameters.AddWithValue("@AppointmentStatusId", SqlDbType.Int).Value = 1;
      command.Parameters.AddWithValue("@AppoinmentContentId", SqlDbType.Int).Value = 4;
      command.ExecuteNonQuery();
      sqlConnection_.Close();
      comboBoxDate.Items.Clear();
      comboBoxTime.Items.Clear();
      comboBoxDoc.SelectedItem = null;
      comboBoxSpec.SelectedItem = null;
      currentDateTime_ = "";
      MessageBox.Show("Запись добавлена.");
    }

    private void btnChangeApp_Click(object sender, EventArgs e)
    {
      changeAppWindow_.Show();
      this.Hide();
    }

    private void btnViewInfo_Click(object sender, EventArgs e)
    {
      viewInfoWindow_.Show();
      this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      changePsw_.Show();
      this.Hide();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      viewInfoWindow_.Close();
      changeAppWindow_.Close();
      changePsw_.Close();
      lgScreen_.Show();
      this.Close();
    }
  }
}
