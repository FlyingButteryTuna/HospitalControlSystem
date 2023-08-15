
namespace kp5
{
  partial class FrontDeskWorker
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnInformation = new System.Windows.Forms.Button();
      this.lableFullName = new System.Windows.Forms.Label();
      this.labelPassport = new System.Windows.Forms.Label();
      this.labelPhoneNumber = new System.Windows.Forms.Label();
      this.labelGender = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.labelInsuranceSpec = new System.Windows.Forms.Label();
      this.labelLogin = new System.Windows.Forms.Label();
      this.labelPassword = new System.Windows.Forms.Label();
      this.txtBoxLogin = new System.Windows.Forms.TextBox();
      this.txtBoxPassword = new System.Windows.Forms.TextBox();
      this.comboBoxUserType = new System.Windows.Forms.ComboBox();
      this.txtBoxFullName = new System.Windows.Forms.TextBox();
      this.txtBoxPassportNumber = new System.Windows.Forms.TextBox();
      this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
      this.txtBoxInsuranceSpec = new System.Windows.Forms.TextBox();
      this.groupBoxGender = new System.Windows.Forms.GroupBox();
      this.radioButtonGenderW = new System.Windows.Forms.RadioButton();
      this.radioButtonGenderM = new System.Windows.Forms.RadioButton();
      this.btnRegister = new System.Windows.Forms.Button();
      this.btnChangeProfile = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.groupBoxGender.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnInformation
      // 
      this.btnInformation.Location = new System.Drawing.Point(409, 1);
      this.btnInformation.Name = "btnInformation";
      this.btnInformation.Size = new System.Drawing.Size(379, 25);
      this.btnInformation.TabIndex = 1;
      this.btnInformation.Text = "Просмотр информации";
      this.btnInformation.UseVisualStyleBackColor = true;
      this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
      // 
      // lableFullName
      // 
      this.lableFullName.AutoSize = true;
      this.lableFullName.Location = new System.Drawing.Point(197, 164);
      this.lableFullName.Name = "lableFullName";
      this.lableFullName.Size = new System.Drawing.Size(123, 17);
      this.lableFullName.TabIndex = 2;
      this.lableFullName.Text = "Ф.И.О. Пациента";
      // 
      // labelPassport
      // 
      this.labelPassport.AutoSize = true;
      this.labelPassport.Location = new System.Drawing.Point(203, 194);
      this.labelPassport.Name = "labelPassport";
      this.labelPassport.Size = new System.Drawing.Size(117, 17);
      this.labelPassport.TabIndex = 3;
      this.labelPassport.Text = "Номер паспорта";
      // 
      // labelPhoneNumber
      // 
      this.labelPhoneNumber.AutoSize = true;
      this.labelPhoneNumber.Location = new System.Drawing.Point(199, 223);
      this.labelPhoneNumber.Name = "labelPhoneNumber";
      this.labelPhoneNumber.Size = new System.Drawing.Size(121, 17);
      this.labelPhoneNumber.TabIndex = 4;
      this.labelPhoneNumber.Text = "Номер телефона";
      // 
      // labelGender
      // 
      this.labelGender.AutoSize = true;
      this.labelGender.Location = new System.Drawing.Point(273, 271);
      this.labelGender.Name = "labelGender";
      this.labelGender.Size = new System.Drawing.Size(34, 17);
      this.labelGender.TabIndex = 5;
      this.labelGender.Text = "Пол";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(239, 223);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(0, 17);
      this.label5.TabIndex = 6;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(191, 129);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(129, 17);
      this.label6.TabIndex = 7;
      this.label6.Text = "Тип пользователя";
      // 
      // labelInsuranceSpec
      // 
      this.labelInsuranceSpec.AutoSize = true;
      this.labelInsuranceSpec.Location = new System.Drawing.Point(199, 315);
      this.labelInsuranceSpec.Name = "labelInsuranceSpec";
      this.labelInsuranceSpec.Size = new System.Drawing.Size(121, 17);
      this.labelInsuranceSpec.TabIndex = 8;
      this.labelInsuranceSpec.Text = "Номер страховки";
      // 
      // labelLogin
      // 
      this.labelLogin.AutoSize = true;
      this.labelLogin.Location = new System.Drawing.Point(273, 67);
      this.labelLogin.Name = "labelLogin";
      this.labelLogin.Size = new System.Drawing.Size(47, 17);
      this.labelLogin.TabIndex = 9;
      this.labelLogin.Text = "Логин";
      this.labelLogin.Click += new System.EventHandler(this.label1_Click);
      // 
      // labelPassword
      // 
      this.labelPassword.AutoSize = true;
      this.labelPassword.Location = new System.Drawing.Point(263, 98);
      this.labelPassword.Name = "labelPassword";
      this.labelPassword.Size = new System.Drawing.Size(57, 17);
      this.labelPassword.TabIndex = 10;
      this.labelPassword.Text = "Пароль";
      // 
      // txtBoxLogin
      // 
      this.txtBoxLogin.Location = new System.Drawing.Point(441, 64);
      this.txtBoxLogin.Name = "txtBoxLogin";
      this.txtBoxLogin.Size = new System.Drawing.Size(169, 22);
      this.txtBoxLogin.TabIndex = 11;
      // 
      // txtBoxPassword
      // 
      this.txtBoxPassword.Location = new System.Drawing.Point(441, 95);
      this.txtBoxPassword.Name = "txtBoxPassword";
      this.txtBoxPassword.Size = new System.Drawing.Size(169, 22);
      this.txtBoxPassword.TabIndex = 12;
      // 
      // comboBoxUserType
      // 
      this.comboBoxUserType.FormattingEnabled = true;
      this.comboBoxUserType.Location = new System.Drawing.Point(441, 126);
      this.comboBoxUserType.Name = "comboBoxUserType";
      this.comboBoxUserType.Size = new System.Drawing.Size(169, 24);
      this.comboBoxUserType.TabIndex = 13;
      this.comboBoxUserType.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserType_SelectedIndexChanged);
      // 
      // txtBoxFullName
      // 
      this.txtBoxFullName.Location = new System.Drawing.Point(441, 161);
      this.txtBoxFullName.Name = "txtBoxFullName";
      this.txtBoxFullName.Size = new System.Drawing.Size(169, 22);
      this.txtBoxFullName.TabIndex = 14;
      // 
      // txtBoxPassportNumber
      // 
      this.txtBoxPassportNumber.Location = new System.Drawing.Point(441, 191);
      this.txtBoxPassportNumber.Name = "txtBoxPassportNumber";
      this.txtBoxPassportNumber.Size = new System.Drawing.Size(169, 22);
      this.txtBoxPassportNumber.TabIndex = 15;
      // 
      // txtBoxPhoneNumber
      // 
      this.txtBoxPhoneNumber.Location = new System.Drawing.Point(441, 220);
      this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
      this.txtBoxPhoneNumber.Size = new System.Drawing.Size(169, 22);
      this.txtBoxPhoneNumber.TabIndex = 16;
      // 
      // txtBoxInsuranceSpec
      // 
      this.txtBoxInsuranceSpec.Location = new System.Drawing.Point(441, 312);
      this.txtBoxInsuranceSpec.Name = "txtBoxInsuranceSpec";
      this.txtBoxInsuranceSpec.Size = new System.Drawing.Size(169, 22);
      this.txtBoxInsuranceSpec.TabIndex = 19;
      // 
      // groupBoxGender
      // 
      this.groupBoxGender.Controls.Add(this.radioButtonGenderW);
      this.groupBoxGender.Controls.Add(this.radioButtonGenderM);
      this.groupBoxGender.Location = new System.Drawing.Point(441, 248);
      this.groupBoxGender.Name = "groupBoxGender";
      this.groupBoxGender.Size = new System.Drawing.Size(169, 49);
      this.groupBoxGender.TabIndex = 20;
      this.groupBoxGender.TabStop = false;
      this.groupBoxGender.Enter += new System.EventHandler(this.groupBoxGender_Enter);
      // 
      // radioButtonGenderW
      // 
      this.radioButtonGenderW.AutoSize = true;
      this.radioButtonGenderW.Location = new System.Drawing.Point(98, 17);
      this.radioButtonGenderW.Name = "radioButtonGenderW";
      this.radioButtonGenderW.Size = new System.Drawing.Size(42, 21);
      this.radioButtonGenderW.TabIndex = 21;
      this.radioButtonGenderW.TabStop = true;
      this.radioButtonGenderW.Text = "Ж";
      this.radioButtonGenderW.UseVisualStyleBackColor = true;
      this.radioButtonGenderW.CheckedChanged += new System.EventHandler(this.radioButtonGenderW_CheckedChanged);
      // 
      // radioButtonGenderM
      // 
      this.radioButtonGenderM.AutoSize = true;
      this.radioButtonGenderM.Location = new System.Drawing.Point(27, 17);
      this.radioButtonGenderM.Name = "radioButtonGenderM";
      this.radioButtonGenderM.Size = new System.Drawing.Size(40, 21);
      this.radioButtonGenderM.TabIndex = 0;
      this.radioButtonGenderM.TabStop = true;
      this.radioButtonGenderM.Text = "М";
      this.radioButtonGenderM.UseVisualStyleBackColor = true;
      this.radioButtonGenderM.CheckedChanged += new System.EventHandler(this.radioButtonGenderM_CheckedChanged);
      // 
      // btnRegister
      // 
      this.btnRegister.Location = new System.Drawing.Point(312, 371);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(152, 50);
      this.btnRegister.TabIndex = 21;
      this.btnRegister.Text = "Зарегистрировать";
      this.btnRegister.UseVisualStyleBackColor = true;
      this.btnRegister.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnChangeProfile
      // 
      this.btnChangeProfile.Location = new System.Drawing.Point(12, 2);
      this.btnChangeProfile.Name = "btnChangeProfile";
      this.btnChangeProfile.Size = new System.Drawing.Size(379, 23);
      this.btnChangeProfile.TabIndex = 22;
      this.btnChangeProfile.Text = "Изменение профиля";
      this.btnChangeProfile.UseVisualStyleBackColor = true;
      this.btnChangeProfile.Click += new System.EventHandler(this.btnChangeProfile_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(707, 371);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(87, 67);
      this.btnExit.TabIndex = 23;
      this.btnExit.Text = "Выход";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // FrontDeskWorker
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnChangeProfile);
      this.Controls.Add(this.btnRegister);
      this.Controls.Add(this.groupBoxGender);
      this.Controls.Add(this.txtBoxInsuranceSpec);
      this.Controls.Add(this.txtBoxPhoneNumber);
      this.Controls.Add(this.txtBoxPassportNumber);
      this.Controls.Add(this.txtBoxFullName);
      this.Controls.Add(this.comboBoxUserType);
      this.Controls.Add(this.txtBoxPassword);
      this.Controls.Add(this.txtBoxLogin);
      this.Controls.Add(this.labelPassword);
      this.Controls.Add(this.labelLogin);
      this.Controls.Add(this.labelInsuranceSpec);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.labelGender);
      this.Controls.Add(this.labelPhoneNumber);
      this.Controls.Add(this.labelPassport);
      this.Controls.Add(this.lableFullName);
      this.Controls.Add(this.btnInformation);
      this.Name = "FrontDeskWorker";
      this.Text = "FrontDeskWorker";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.groupBoxGender.ResumeLayout(false);
      this.groupBoxGender.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnInformation;
    private System.Windows.Forms.Label lableFullName;
    private System.Windows.Forms.Label labelPassport;
    private System.Windows.Forms.Label labelPhoneNumber;
    private System.Windows.Forms.Label labelGender;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label labelInsuranceSpec;
    private System.Windows.Forms.Label labelLogin;
    private System.Windows.Forms.Label labelPassword;
    private System.Windows.Forms.TextBox txtBoxLogin;
    private System.Windows.Forms.TextBox txtBoxPassword;
    private System.Windows.Forms.ComboBox comboBoxUserType;
    private System.Windows.Forms.TextBox txtBoxFullName;
    private System.Windows.Forms.TextBox txtBoxPassportNumber;
    private System.Windows.Forms.TextBox txtBoxPhoneNumber;
    private System.Windows.Forms.TextBox txtBoxInsuranceSpec;
    private System.Windows.Forms.GroupBox groupBoxGender;
    private System.Windows.Forms.RadioButton radioButtonGenderW;
    private System.Windows.Forms.RadioButton radioButtonGenderM;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnChangeProfile;
    private System.Windows.Forms.Button btnExit;
  }
}