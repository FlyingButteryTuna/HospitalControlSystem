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
  public partial class PatientChangeApp : Form
  {
    private PatientAppoointments appsWindow_;
    private PatientViewInfo viewWindow_;
    private DataRow patient_;
    private SqlConnection sqlConnection_;

    private SqlCommand getSchedule_;

    private DataTable result_;

    public PatientChangeApp()
    {
      InitializeComponent();
    }

    public class Status
    {
      public int id { get; set; }
      public string name { get; set; }
    }

    public PatientChangeApp(DataRow patient, SqlConnection connection, PatientAppoointments appWindow)
    {
      InitializeComponent();
      patient_ = patient;
      sqlConnection_ = connection;
      appsWindow_ = appWindow;

      mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

      result_ = new DataTable();

      mainGrid.AllowUserToAddRows = false;

      getSchedule_ = new SqlCommand("ViewDoctorsSchedule", sqlConnection_);
      getSchedule_.CommandType = CommandType.StoredProcedure;


      getAppointments();
    }

    public void setViewWindow(PatientViewInfo viewWindow) {
      viewWindow_ = viewWindow;
    }

    private void getAppointments()
    {
      result_.Columns.Clear();
      result_.Rows.Clear();
      result_.Clear();

      sqlConnection_.Open();
      String query = "select * from Appointments_full where PatientName = '" + patient_["FullName"] + "'";
      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable apps = new DataTable();
      sda.Fill(apps);
      sqlConnection_.Close();
      



      DataGridViewComboBoxColumn status = new DataGridViewComboBoxColumn();
      status.HeaderText = "Статус";
      status.Name = "Статус";
      status.DataPropertyName = "Статус";
      status.Items.AddRange("Отменен", "Создан");

      result_.Columns.Add("AppId").ReadOnly = true;
      result_.Columns.Add("Имя доктора").ReadOnly = true;
      result_.Columns.Add("Дата и время", typeof(String)).ReadOnly = true ;
      result_.Columns.Add("Статус", typeof(String));
      result_.Columns.Add("Жалобы").ReadOnly = true; ;
      result_.Columns.Add("Рекомендации").ReadOnly = true; ;

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
        rw["Имя доктора"] = apps.Rows[i]["DoctorName"].ToString();
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
      mainGrid.Columns.Add(status);

      sqlConnection_.Close();
    }

    private void patient_change_app_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'kpDataSet1.AppointmentStatus' table. You can move, or remove it, as needed.
      this.appointmentStatusTableAdapter1.Fill(this.kpDataSet1.AppointmentStatus);
      // TODO: This line of code loads data into the 'kpDataSet.AppointmentStatus' table. You can move, or remove it, as needed.
      this.appointmentStatusTableAdapter.Fill(this.kpDataSet.AppointmentStatus);

    }

    private void btnRegAps_Click(object sender, EventArgs e)
    {
      this.Hide();
      appsWindow_.Show();
    }

    private void btnViewInfo_Click(object sender, EventArgs e)
    {
      this.Hide();
      viewWindow_.Show();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      sqlConnection_.Open();
      for (int i = 0; i < mainGrid.Rows.Count; i++) {
        String query = "update Appointments set AppointmentStatusId = (" +
          "select IdAppointmentStatus from AppointmentStatus where StatusName = '" + mainGrid.Rows[i].Cells[6].Value.ToString() + "'" +
          ") where IdAppointment = " + mainGrid.Rows[i].Cells[0].Value.ToString();
        SqlCommand command = new SqlCommand(query, sqlConnection_);
        command.ExecuteNonQuery();
      }
      sqlConnection_.Close();
      MessageBox.Show("Изменения сохранены");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      getAppointments();
    }
  }
}
