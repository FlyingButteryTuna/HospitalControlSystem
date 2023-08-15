
namespace kp5
{
  partial class FDWChnageProfile
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
      this.btnRegister = new System.Windows.Forms.Button();
      this.btnInformation = new System.Windows.Forms.Button();
      this.labelPassportInput = new System.Windows.Forms.Label();
      this.txtBoxPassportInput = new System.Windows.Forms.TextBox();
      this.gridviewFoundUser = new System.Windows.Forms.DataGridView();
      this.btnFindUser = new System.Windows.Forms.Button();
      this.labelNotfound = new System.Windows.Forms.Label();
      this.btnSaveChanges = new System.Windows.Forms.Button();
      this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.passportnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.insurancenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.activityuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridviewFoundUser)).BeginInit();
      this.SuspendLayout();
      // 
      // btnRegister
      // 
      this.btnRegister.Location = new System.Drawing.Point(12, 2);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(379, 23);
      this.btnRegister.TabIndex = 24;
      this.btnRegister.Text = "Регистрация профиля";
      this.btnRegister.UseVisualStyleBackColor = true;
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
      // 
      // btnInformation
      // 
      this.btnInformation.Location = new System.Drawing.Point(409, 1);
      this.btnInformation.Name = "btnInformation";
      this.btnInformation.Size = new System.Drawing.Size(379, 25);
      this.btnInformation.TabIndex = 23;
      this.btnInformation.Text = "Просмотр информации";
      this.btnInformation.UseVisualStyleBackColor = true;
      this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
      // 
      // labelPassportInput
      // 
      this.labelPassportInput.AutoSize = true;
      this.labelPassportInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelPassportInput.Location = new System.Drawing.Point(293, 71);
      this.labelPassportInput.Name = "labelPassportInput";
      this.labelPassportInput.Size = new System.Drawing.Size(224, 20);
      this.labelPassportInput.TabIndex = 25;
      this.labelPassportInput.Text = "Введите номер паспорта";
      // 
      // txtBoxPassportInput
      // 
      this.txtBoxPassportInput.Location = new System.Drawing.Point(269, 140);
      this.txtBoxPassportInput.Name = "txtBoxPassportInput";
      this.txtBoxPassportInput.Size = new System.Drawing.Size(271, 22);
      this.txtBoxPassportInput.TabIndex = 26;
      // 
      // gridviewFoundUser
      // 
      this.gridviewFoundUser.AllowUserToAddRows = false;
      this.gridviewFoundUser.AllowUserToDeleteRows = false;
      this.gridviewFoundUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridviewFoundUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullname,
            this.passportnumber,
            this.phonenumber,
            this.gender,
            this.insurancenumber,
            this.login,
            this.password,
            this.activityuser});
      this.gridviewFoundUser.Location = new System.Drawing.Point(12, 240);
      this.gridviewFoundUser.Name = "gridviewFoundUser";
      this.gridviewFoundUser.RowHeadersWidth = 51;
      this.gridviewFoundUser.RowTemplate.Height = 24;
      this.gridviewFoundUser.Size = new System.Drawing.Size(776, 122);
      this.gridviewFoundUser.TabIndex = 27;
      // 
      // btnFindUser
      // 
      this.btnFindUser.Location = new System.Drawing.Point(352, 184);
      this.btnFindUser.Name = "btnFindUser";
      this.btnFindUser.Size = new System.Drawing.Size(107, 34);
      this.btnFindUser.TabIndex = 28;
      this.btnFindUser.Text = "Найти";
      this.btnFindUser.UseVisualStyleBackColor = true;
      this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
      // 
      // labelNotfound
      // 
      this.labelNotfound.AutoSize = true;
      this.labelNotfound.ForeColor = System.Drawing.Color.Red;
      this.labelNotfound.Location = new System.Drawing.Point(304, 111);
      this.labelNotfound.Name = "labelNotfound";
      this.labelNotfound.Size = new System.Drawing.Size(203, 17);
      this.labelNotfound.TabIndex = 29;
      this.labelNotfound.Text = "Пользователь не был найден";
      // 
      // btnSaveChanges
      // 
      this.btnSaveChanges.Location = new System.Drawing.Point(309, 393);
      this.btnSaveChanges.Name = "btnSaveChanges";
      this.btnSaveChanges.Size = new System.Drawing.Size(198, 33);
      this.btnSaveChanges.TabIndex = 30;
      this.btnSaveChanges.Text = "Сохранить изменения";
      this.btnSaveChanges.UseVisualStyleBackColor = true;
      this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
      // 
      // fullname
      // 
      this.fullname.HeaderText = "Ф.И.О";
      this.fullname.MinimumWidth = 6;
      this.fullname.Name = "fullname";
      this.fullname.Width = 160;
      // 
      // passportnumber
      // 
      this.passportnumber.HeaderText = "Номер паспорта";
      this.passportnumber.MinimumWidth = 6;
      this.passportnumber.Name = "passportnumber";
      this.passportnumber.Width = 160;
      // 
      // phonenumber
      // 
      this.phonenumber.HeaderText = "Номер телефона";
      this.phonenumber.MinimumWidth = 6;
      this.phonenumber.Name = "phonenumber";
      this.phonenumber.Width = 160;
      // 
      // gender
      // 
      this.gender.HeaderText = "Пол";
      this.gender.MinimumWidth = 6;
      this.gender.Name = "gender";
      this.gender.Width = 60;
      // 
      // insurancenumber
      // 
      this.insurancenumber.HeaderText = "Номер страховки";
      this.insurancenumber.MinimumWidth = 6;
      this.insurancenumber.Name = "insurancenumber";
      this.insurancenumber.Width = 160;
      // 
      // login
      // 
      this.login.HeaderText = "Логин";
      this.login.MinimumWidth = 6;
      this.login.Name = "login";
      this.login.Width = 125;
      // 
      // password
      // 
      this.password.HeaderText = "Пароль";
      this.password.MinimumWidth = 6;
      this.password.Name = "password";
      this.password.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.password.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.password.Width = 125;
      // 
      // activityuser
      // 
      this.activityuser.HeaderText = "Активность";
      this.activityuser.MinimumWidth = 6;
      this.activityuser.Name = "activityuser";
      this.activityuser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.activityuser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.activityuser.Width = 125;
      // 
      // FDWChnageProfile
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnSaveChanges);
      this.Controls.Add(this.labelNotfound);
      this.Controls.Add(this.btnFindUser);
      this.Controls.Add(this.gridviewFoundUser);
      this.Controls.Add(this.txtBoxPassportInput);
      this.Controls.Add(this.labelPassportInput);
      this.Controls.Add(this.btnRegister);
      this.Controls.Add(this.btnInformation);
      this.Name = "FDWChnageProfile";
      this.Text = "Изменение Профиля";
      this.Load += new System.EventHandler(this.front_change_profile_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridviewFoundUser)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnInformation;
    private System.Windows.Forms.Label labelPassportInput;
    private System.Windows.Forms.TextBox txtBoxPassportInput;
    private System.Windows.Forms.DataGridView gridviewFoundUser;
    private System.Windows.Forms.Button btnFindUser;
    private System.Windows.Forms.Label labelNotfound;
    private System.Windows.Forms.Button btnSaveChanges;
    private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
    private System.Windows.Forms.DataGridViewTextBoxColumn passportnumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn gender;
    private System.Windows.Forms.DataGridViewTextBoxColumn insurancenumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn login;
    private System.Windows.Forms.DataGridViewTextBoxColumn password;
    private System.Windows.Forms.DataGridViewTextBoxColumn activityuser;
  }
}