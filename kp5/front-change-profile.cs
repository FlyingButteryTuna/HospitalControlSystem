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
  public partial class FDWChnageProfile : Form
  {
    private DataRow receptionist_;
    private SqlConnection sqlConnection_;

    private FrontDeskWorker receptionstWindow_;
    private FDWviewinfo viewinfoWindow_;

    private int currentUserTypeFound_;

    private String currentPassportNumber_;
    private String currentFullname_;
    private String currentPhoneNumber_;
    private String currentGender_;
    private String currentInsuranceSpec_;
    private String currentLogin_;
    private String currentPassword_;
    private String currentActive_;

    private bool updateFN = false;
    private bool updatePhN = false;
    private bool updatePaN = false;
    private bool updateGender = false;
    private bool updateInsSpec = false;
    private bool updateLogin = false;
    private bool updatePassword = false;
    private bool updateActive = false;

    public void setViewWindow(FDWviewinfo window) {
      viewinfoWindow_ = window;
    }

    public FDWChnageProfile()
    {
      InitializeComponent();
    }

    public FDWChnageProfile(DataRow receptionist, SqlConnection connection, FrontDeskWorker receptionstWindow)
    {
      InitializeComponent();
      receptionist_ = receptionist;
      sqlConnection_ = connection;
      receptionstWindow_ = receptionstWindow;

      labelNotfound.Visible = false;
      btnSaveChanges.Visible = false;

      gridviewFoundUser.AllowUserToAddRows = false;
    }

    private void front_change_profile_Load(object sender, EventArgs e)
    {

    }


    private void btnFindUser_Click(object sender, EventArgs e)
    {
      String query = "Select distinct * from Patients Where PassportNumber = '"
          + txtBoxPassportInput.Text.Trim() + "'";

      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection_);
      DataTable patients = new DataTable();
      sda.Fill(patients);
      gridviewFoundUser.Columns[4].HeaderText = "Номер страховки";
      if (patients.Rows.Count != 0) {
        query = "Select distinct * from Users Where IdUser = '"
          + patients.Rows[0]["UserId"] + "'";
        sda = new SqlDataAdapter(query, sqlConnection_);
        DataTable userinfo = new DataTable();
        sda.Fill(userinfo);

        labelNotfound.Visible = false;
        btnSaveChanges.Visible = true;

        string[] user = new string[] { "" + patients.Rows[0]["FullName"],
                        "" + patients.Rows[0]["PassportNumber"],
                        "" + patients.Rows[0]["PhoneNumber"],
                        "" + patients.Rows[0]["Gender"],
                        "" + patients.Rows[0]["InsuranceNumber"],
                        "" + userinfo.Rows[0]["Login"],
                        "" + StringCipher.Decrypt(userinfo.Rows[0]["Password"].ToString(), LoginScreen.password),
                        "" + (((bool)userinfo.Rows[0]["Active"]) ? "Да" : "Нет")};

        gridviewFoundUser.Rows.Clear();
        gridviewFoundUser.Rows.Add(user);

        currentUserTypeFound_ = 1;
        currentPassportNumber_ = patients.Rows[0]["PassportNumber"].ToString();
        currentActive_ = (((bool)userinfo.Rows[0]["Active"]) ? "Да" : "Нет");
        currentFullname_ = patients.Rows[0]["FullName"].ToString();
        currentPhoneNumber_ = patients.Rows[0]["PhoneNumber"].ToString().Trim();
        currentGender_ = patients.Rows[0]["Gender"].ToString();
        currentInsuranceSpec_ = patients.Rows[0]["InsuranceNumber"].ToString();
        currentLogin_ = userinfo.Rows[0]["Login"].ToString();
        currentPassword_ = StringCipher.Decrypt(userinfo.Rows[0]["Password"].ToString(), LoginScreen.password);
      }
      else {
        query = "Select distinct * from Doctors Where PassportNumber = '"
          + txtBoxPassportInput.Text.Trim() + "'";
        sda = new SqlDataAdapter(query, sqlConnection_);
        DataTable doctors = new DataTable();
        sda.Fill(doctors);
        if (doctors.Rows.Count == 0){
          labelNotfound.Visible = true;
          gridviewFoundUser.Rows.Clear();
          btnSaveChanges.Visible = false;
          return;
        }
        else {
          labelNotfound.Visible = false;
          btnSaveChanges.Visible = true;

          query = "Select distinct SpecializationName from Specializations Where IdSpecialization = '"
          + doctors.Rows[0]["SpecializationId"] + "'";
          sda = new SqlDataAdapter(query, sqlConnection_);
          DataTable specialization = new DataTable();
          sda.Fill(specialization);

          query = "Select distinct * from Users Where IdUser = '"
          + doctors.Rows[0]["UserId"] + "'";
          sda = new SqlDataAdapter(query, sqlConnection_);
          DataTable userinfo = new DataTable();
          sda.Fill(userinfo);

          gridviewFoundUser.Columns[4].HeaderText = "Специализация";
          string[] user = new string[] { "" + doctors.Rows[0]["FullName"],
                        "" + doctors.Rows[0]["PassportNumber"],
                        "" + doctors.Rows[0]["PhoneNumber"],
                        "" + doctors.Rows[0]["Gender"],
                        "" + specialization.Rows[0]["SpecializationName"],
                        "" + userinfo.Rows[0]["Login"],
                        "" + StringCipher.Decrypt(userinfo.Rows[0]["Password"].ToString(), LoginScreen.password),
                        "" + (((bool)userinfo.Rows[0]["Active"]) ? "Да" : "Нет")};

          gridviewFoundUser.Rows.Clear();
          gridviewFoundUser.Rows.Add(user);

          currentUserTypeFound_ = 0;
          currentPassportNumber_ = doctors.Rows[0]["PassportNumber"].ToString();
          currentActive_ = (((bool)userinfo.Rows[0]["Active"]) ? "Да" : "Нет");
          currentFullname_ = doctors.Rows[0]["FullName"].ToString();
          currentPhoneNumber_ = doctors.Rows[0]["PhoneNumber"].ToString();
          currentGender_ = doctors.Rows[0]["Gender"].ToString();
          currentInsuranceSpec_ = doctors.Rows[0]["SpecializationId"].ToString();
          currentLogin_ = userinfo.Rows[0]["Login"].ToString();
          currentPassword_ = StringCipher.Decrypt(userinfo.Rows[0]["Password"].ToString(), LoginScreen.password);
        }

      }


    }

    private void btnSaveChanges_Click(object sender, EventArgs e)
    {
      String fullName = gridviewFoundUser.Rows[0].Cells[0].Value.ToString();
      String passportNumber = gridviewFoundUser.Rows[0].Cells[1].Value.ToString();
      String phoneNumber = gridviewFoundUser.Rows[0].Cells[2].Value.ToString();
      String gender1 = gridviewFoundUser.Rows[0].Cells[3].Value.ToString().Trim();
      String insuranceSpec = gridviewFoundUser.Rows[0].Cells[4].Value.ToString();
      String login = gridviewFoundUser.Rows[0].Cells[5].Value.ToString();
      String password = gridviewFoundUser.Rows[0].Cells[6].Value.ToString();
      String active = gridviewFoundUser.Rows[0].Cells[7].Value.ToString();

      updateFN = false;
      updatePhN = false;
      updatePaN = false;
      updateGender = false;
      updateInsSpec = false;
      updateLogin = false;
      updatePassword = false;
      updateActive = false;

      if (!fullName.Equals(currentFullname_))
        updateFN = true;

      if (!passportNumber.Equals(currentPassportNumber_))
        updatePaN = true;

      if (!phoneNumber.Equals(currentPhoneNumber_))
        updatePhN = true;

      if (!gender1.Equals(currentGender_))
        updateGender = true;

      if (!insuranceSpec.Equals(currentInsuranceSpec_))
        updateInsSpec = true;

      if (!login.Equals(currentLogin_))
        updateLogin = true;

      if (!password.Equals(currentPassword_))
        updatePassword = true;

      if (!active.Equals(currentActive_))
        updateActive = true;

      if (!updateFN && !updatePaN && !updatePhN && !updateGender &&
          !updateInsSpec && !updateLogin && !updatePassword && !updateActive)
      {
        MessageBox.Show("Данные не были изменены");
        return;
      }

      String msg = validateRegisterParameters(login, password, currentUserTypeFound_, fullName,
        passportNumber, phoneNumber, insuranceSpec, active, gender1);

      if (!msg.Equals("")) {
        MessageBox.Show(msg);
        return;
      }

      String tableToUpdate = "";
      String query;
      String specid = "";
      SqlDataAdapter sda;
      DataTable specialization;
      SqlCommand command;
      if (currentUserTypeFound_ == 0)
      {
        tableToUpdate = "Doctors";
        query = "Select distinct IdSpecialization from Specializations Where SpecializationName = '" +
        insuranceSpec + "'";
        sda = new SqlDataAdapter(query, sqlConnection_);
        specialization = new DataTable();
        sda.Fill(specialization);

        if (specialization.Rows.Count == 0) {
          query = "insert into Specializations (SpecializationName) values(@SpecializationName)";
          sqlConnection_.Open();
          command = new SqlCommand(query, sqlConnection_);
          command.Parameters.Add("@SpecializationName", SqlDbType.VarChar).Value = insuranceSpec.Trim();
          command.ExecuteNonQuery();
          sqlConnection_.Close();
        }

        query = "Select distinct IdSpecialization from Specializations Where SpecializationName = '" +
        insuranceSpec + "'";
        sda = new SqlDataAdapter(query, sqlConnection_);
        specialization = new DataTable();
        sda.Fill(specialization);

        specid = specialization.Rows[0]["IdSpecialization"].ToString();
      }
      else {
        tableToUpdate = "Patients";
      }

      if (updateFN || updatePaN || updateInsSpec || updatePhN || updateGender)
      {
        query = "update " + tableToUpdate +
          " set FullName = '" + fullName + "'" +
          ", PassportNumber = '" + passportNumber + "'" +
          ((currentUserTypeFound_ == 1) ? ", InsuranceNumber = '" + insuranceSpec + "'" : ", SpecializationId = " + specid) +
          ", PhoneNumber = '" + phoneNumber + "'" +
          ", Gender = '" + gender1 + "' " +
          "where PassportNumber = '" + currentPassportNumber_ + "'";

        sqlConnection_.Open();
        command = new SqlCommand(query, sqlConnection_);
        command.ExecuteNonQuery();
        sqlConnection_.Close();
      }

      if (updateLogin || updatePassword || updateActive)
      {
        query = "Select distinct UserId from " + tableToUpdate + " where PassportNumber = '" + passportNumber + "'";
        sda = new SqlDataAdapter(query, sqlConnection_);
        DataTable useridUpd = new DataTable();
        sda.Fill(useridUpd);

        query = "update Users set " +
          "Login = '" + login + "'" +
          ", Password = '" + StringCipher.Encrypt(password, LoginScreen.password) + "'" +
          ", Active = " + (active.Trim() == "Да" ? "1" : "0") +
          " where IdUser = " + useridUpd.Rows[0]["UserId"].ToString();

        sqlConnection_.Open();
        command = new SqlCommand(query, sqlConnection_);
        command.ExecuteNonQuery();
        sqlConnection_.Close();
      }

      currentFullname_ = fullName;
      currentGender_ = gender1;
      currentInsuranceSpec_ = insuranceSpec;
      currentPassportNumber_ = passportNumber;
      currentPhoneNumber_ = phoneNumber;
      currentLogin_ = login;
      currentPassword_ = password;
      currentActive_ = active;

      MessageBox.Show("Данные пользователя были успешно обновлены");
    }

    private String validateRegisterParameters(String login, String password, int userType, String fullName,
                                           String passportNumber, String phoneNumber, String specializationInsurance,
                                           String active, String gender)
    {
      String message = "";
      if (login == "" || password == "" || fullName == "" || passportNumber == "" || phoneNumber == "" ||
          specializationInsurance == "" || active == "")
      {
        message = "Провертье пустые поля.";
        return message;
      }
      String query;
      SqlDataAdapter sda;
      DataTable test = new DataTable();
      if (updateLogin)
      {
        sqlConnection_.Open();
        query = "Select distinct * from Users Where Login = '" + login.Trim()
         + "'";
        sda = new SqlDataAdapter(query, sqlConnection_);
        test = new DataTable();
        sda.Fill(test);
        if (test.Rows.Count >= 1)
        {
          message += "Такой логин уже занят.\n";
        }
        sqlConnection_.Close();
        test.Clear();
      }

      if (updatePhN)
      {
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
      }

      if (updatePaN)
      {
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
      }

      
      if (updateFN && (!fullName.All(c => char.IsWhiteSpace(c) || char.IsLetter(c))))
      {
        message += "Имя должно содержать только пробелы и буквы.\n";
      }

      if (userType == 1 && updateInsSpec)
      {
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


      if (updatePaN && (!passportNumber.All(char.IsDigit)))
      {
        message += "Номер пасорта должен содержать только цифры.\n";
      }

      if (updatePaN && passportNumber.Length != 10)
      {
        message += "Номер пасспорта должен содержать 10 цифр.\n";
      }

      if (updatePhN && !phoneNumber.All(char.IsDigit))
      {
        message += "Номер телефона должен содержать только цифры.\n";
      }

      if (userType == 0 && updateInsSpec)
      {
        if (!specializationInsurance.All(char.IsLetter))
        {
          message += "Специализация врача должна содержать только буквы.\n";
        }
      }
      else
      {
        if (!specializationInsurance.All(char.IsDigit))
        {
          message += "Страховка поцеинта должна содержать только цифры.\n";
        }

        if (specializationInsurance.Length != 16)
        {
          message += "Страховка пациента должна содержать 16 цифр.\n";
        }
      }

      if (updateActive && (active.ToLower() != "нет" && active.ToLower() != "да")) {
        message += "Актинвость должна содержать либо \'нет\', либо \'да\'\n";
      }

      if (updateGender && (!gender.Equals("М") && !gender.Equals("Ж"))){
        
        message += "Пол должен быть указан как М или Ж (заглавные).\n";
      }

      return message;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
      this.Hide();
      receptionstWindow_.Show();
    }

    private void btnInformation_Click(object sender, EventArgs e)
    {
      this.Hide();
      viewinfoWindow_.Show();
    }
  }

}
