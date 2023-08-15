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
  public partial class FrontDeskWorker : Form
  {
    private DataRow receptionist_;
    private SqlConnection sqlConnection_;

    private SqlCommand registerPatient_;
    private SqlCommand registerDoctor_;

    private FDWChnageProfile changeProfileWindow_;
    private FDWviewinfo viewInfoWindow_;
    private LoginScreen lgScreen_;

    private char currentGender = 'М';

    public FrontDeskWorker()
    {
      InitializeComponent();
    }

    public FrontDeskWorker(DataRow receptionist, SqlConnection connection, LoginScreen lgScreen)
    {
      InitializeComponent();
      receptionist_ = receptionist;
      sqlConnection_ = connection;

      changeProfileWindow_ = new FDWChnageProfile(receptionist_, sqlConnection_, this);
      viewInfoWindow_ = new FDWviewinfo(receptionist_, changeProfileWindow_, this, sqlConnection_);
      changeProfileWindow_.setViewWindow(viewInfoWindow_);

      registerPatient_ = new SqlCommand("RegisterPatient", sqlConnection_);
      registerPatient_.CommandType = CommandType.StoredProcedure;

      registerDoctor_ = new SqlCommand("RegisterDoctor", sqlConnection_);
      registerDoctor_.CommandType = CommandType.StoredProcedure;

      lgScreen_ = lgScreen;

      groupBoxGender.Controls.Add(radioButtonGenderM);
      groupBoxGender.Controls.Add(radioButtonGenderW);
      radioButtonGenderM.Checked = true;

      comboBoxUserType.Items.Add("Доктор");
      comboBoxUserType.Items.Add("Пациент");
      comboBoxUserType.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBoxUserType.SelectedIndex = 1;

      txtBoxLogin.MaxLength = 30;
      txtBoxPassword.MaxLength = 50;
      txtBoxFullName.MaxLength = 100;
      txtBoxPassportNumber.MaxLength = 10;
      txtBoxPhoneNumber.MaxLength = 15;
      txtBoxInsuranceSpec.MaxLength = 16;
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void groupBoxGender_Enter(object sender, EventArgs e)
    {

    }

    private void radioButtonGenderW_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButtonGenderM_CheckedChanged(object sender, EventArgs e)
    {
      if (radioButtonGenderM.Checked) {
        currentGender = 'М';
      }
      else {
        currentGender = 'Ж';
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      String login = txtBoxLogin.Text.Trim();
      String password = txtBoxPassword.Text.Trim();
      int userType = comboBoxUserType.SelectedIndex;
      String fullName = txtBoxFullName.Text.Trim();
      String passportNumber = txtBoxPassportNumber.Text.Trim();
      String phoneNumber = txtBoxPhoneNumber.Text.Trim();
      String specializationInsurance = txtBoxInsuranceSpec.Text.Trim();
      String errMsg = validateRegisterParameters(login, password, userType, fullName, passportNumber, phoneNumber,
                                                 specializationInsurance);
      if (!errMsg.Equals("")) {
        MessageBox.Show(errMsg);
        return;
      }

      if (userType == 0) {
        registerDoctor_.Parameters.AddWithValue("@Login", login);
        registerDoctor_.Parameters.AddWithValue("@Password", password);
        registerDoctor_.Parameters.AddWithValue("@Fullname", fullName);
        registerDoctor_.Parameters.AddWithValue("@PassportNumber", passportNumber);
        registerDoctor_.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
        registerDoctor_.Parameters.AddWithValue("@Gender", currentGender);
        String query = "Select distinct IdSpecialization from Specializations Where  SpecializationName = '"
          + specializationInsurance.Trim() + "'";

        SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
        DataTable specialization = new DataTable();
        sda.Fill(specialization);
        sqlConnection_.Open();
        if (specialization.Rows.Count != 1)
        {
          query = "insert into Specializations (SpecializationName) values(@SpecializationName)";
          SqlCommand command = new SqlCommand(query, sqlConnection_);
          command.Parameters.Add("@SpecializationName", SqlDbType.VarChar).Value = specializationInsurance.Trim();
          command.ExecuteNonQuery();
        }
        specialization = new DataTable();
        sda.Fill(specialization);
        registerDoctor_.Parameters.AddWithValue("@SpecializationId", specialization.Rows[0]["IdSpecialization"]);
        
        registerDoctor_.ExecuteNonQuery();
        sqlConnection_.Close();
        registerDoctor_.Parameters.Clear();
        MessageBox.Show("Доктор успешно зарегистрирован.");
      }
      else {
        registerPatient_.Parameters.AddWithValue("@Login", login);
        registerPatient_.Parameters.AddWithValue("@Password", StringCipher.Encrypt(password, LoginScreen.password));
        registerPatient_.Parameters.AddWithValue("@Fullname", fullName);
        registerPatient_.Parameters.AddWithValue("@PassportNumber", passportNumber);
        registerPatient_.Parameters.AddWithValue("@InsuranceNumber", specializationInsurance);
        registerPatient_.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
        registerPatient_.Parameters.AddWithValue("@Gender", currentGender);
        sqlConnection_.Open();
        registerPatient_.ExecuteNonQuery();
        sqlConnection_.Close();
        registerPatient_.Parameters.Clear();
        MessageBox.Show("Пациент успешно зарегистрирован.");
      }


    }

    private String validateRegisterParameters(String login, String password, int userType, String fullName,
                                            String passportNumber, String phoneNumber, String specializationInsurance)
    {
      String message = "";
      if (login == "" || password == "" || fullName == "" || passportNumber == "" || phoneNumber == "" ||
          specializationInsurance == "") {
        message = "Провертье пустые поля.";
        return message;
      }
      sqlConnection_.Open();
      String query = "Select distinct * from Users Where Login = '" + txtBoxLogin.Text.Trim()
       + "'";

      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable test = new DataTable();
      sda.Fill(test);
      if (test.Rows.Count >= 1) {
        message += "Такой логин уже занят.\n";
      }
      sqlConnection_.Close();
      test.Clear();

      sqlConnection_.Open();
      query = "Select distinct * from Patients, Doctors Where Doctors.PhoneNumber = '" + phoneNumber.Trim() + "'"
        + " or Patients.PhoneNumber = '" + phoneNumber.Trim() + "'";
      sda = new SqlDataAdapter(query, sqlConnection_);
      sda.Fill(test);
      if (test.Rows.Count >= 1)
      {
        message += "Такой номер телефона уже зарегистрирован.\n";
      }
      sqlConnection_.Close();
      test.Clear();

      sqlConnection_.Open();
      query = "Select distinct * from Patients, Doctors Where Doctors.PassportNumber = '" + passportNumber.Trim() + "'"
        + " or Patients.PassportNumber = '" + passportNumber.Trim() + "'";
      sda = new SqlDataAdapter(query, sqlConnection_);
      sda.Fill(test);
      if (test.Rows.Count >= 1)
      {
        message += "Такой номер паспорта уже зарегистрирован.\n";
      }
      sqlConnection_.Close();
      test.Clear();

      if (!fullName.All(c => char.IsWhiteSpace(c) || char.IsLetter(c))) {
        message += "Имя должно содержать только пробелы и буквы.\n";
      }

      if (userType == 1) {
        sqlConnection_.Open();
        query = "Select distinct * from Patients Where InsuranceNumber = '" + specializationInsurance.Trim() + "'";
        sda = new SqlDataAdapter(query, sqlConnection_);
        test.Clear();
        sda.Fill(test);
        if (test.Rows.Count >= 1)
        {
          message += "Пользователь с такой страховкой уже зарегистрирован.\n";
        }
        sqlConnection_.Close();
        test.Clear();
      }


      if (!passportNumber.All(char.IsDigit)) {
        message += "Номер пасорта должен содержать только цифры.\n";
      }

      if (passportNumber.Length != 10) {
        message += "Номер пасспорта должен содержать 10 цифр.\n";
      }

      if (!phoneNumber.All(char.IsDigit))
      {
        message += "Номер телефона должен содержать только цифры.\n";
      }

      if (userType == 0) {
        if (!specializationInsurance.All(char.IsLetter))
        {
          message += "Специализация врача должна содержать только буквы.\n";
        }
      } else {
        if (!specializationInsurance.All(char.IsDigit)) {
          message += "Страховка поцеинта должна содержать только цифры.\n";
        }

        if (specializationInsurance.Length != 16) {
          message += "Страховка пациента должна содержать 16 цифр.\n";
        }
      }

      return message;
    }

    private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboBoxUserType.SelectedItem.ToString().Equals("Доктор")) {
        labelInsuranceSpec.Text = "Специализация";
        txtBoxInsuranceSpec.MaxLength = 100;
      }
      else {
        labelInsuranceSpec.Text = "Номер страховки";
        txtBoxInsuranceSpec.MaxLength = 16;
      }
    }

    private void btnChangeProfile_Click(object sender, EventArgs e)
    {
      this.Hide();
      changeProfileWindow_.Show();
    }

    private void btnInformation_Click(object sender, EventArgs e)
    {
      this.Hide();
      viewInfoWindow_.Show();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      changeProfileWindow_.Close();
      viewInfoWindow_.Close();
      lgScreen_.Show();
      this.Close();
    }
  }
}
