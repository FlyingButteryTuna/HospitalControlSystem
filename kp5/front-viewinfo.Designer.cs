
namespace kp5
{
  partial class FDWviewinfo
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
      this.btnChangeProfile = new System.Windows.Forms.Button();
      this.monthCalendar = new System.Windows.Forms.MonthCalendar();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radioButtonDayApp = new System.Windows.Forms.RadioButton();
      this.radioButtonDayPatients = new System.Windows.Forms.RadioButton();
      this.radioButtonFreeDoc = new System.Windows.Forms.RadioButton();
      this.mainGrid = new System.Windows.Forms.DataGridView();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // btnRegister
      // 
      this.btnRegister.Location = new System.Drawing.Point(12, 3);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(379, 23);
      this.btnRegister.TabIndex = 26;
      this.btnRegister.Text = "Регистрация профиля";
      this.btnRegister.UseVisualStyleBackColor = true;
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
      // 
      // btnChangeProfile
      // 
      this.btnChangeProfile.Location = new System.Drawing.Point(409, 2);
      this.btnChangeProfile.Name = "btnChangeProfile";
      this.btnChangeProfile.Size = new System.Drawing.Size(379, 25);
      this.btnChangeProfile.TabIndex = 25;
      this.btnChangeProfile.Text = "Изменение профиля";
      this.btnChangeProfile.UseVisualStyleBackColor = true;
      this.btnChangeProfile.Click += new System.EventHandler(this.btnInformation_Click);
      // 
      // monthCalendar
      // 
      this.monthCalendar.Location = new System.Drawing.Point(12, 38);
      this.monthCalendar.Name = "monthCalendar";
      this.monthCalendar.TabIndex = 27;
      this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButtonFreeDoc);
      this.groupBox1.Controls.Add(this.radioButtonDayPatients);
      this.groupBox1.Controls.Add(this.radioButtonDayApp);
      this.groupBox1.Location = new System.Drawing.Point(506, 38);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(269, 207);
      this.groupBox1.TabIndex = 28;
      this.groupBox1.TabStop = false;
      // 
      // radioButtonDayApp
      // 
      this.radioButtonDayApp.AutoSize = true;
      this.radioButtonDayApp.Location = new System.Drawing.Point(23, 42);
      this.radioButtonDayApp.Name = "radioButtonDayApp";
      this.radioButtonDayApp.Size = new System.Drawing.Size(209, 21);
      this.radioButtonDayApp.TabIndex = 0;
      this.radioButtonDayApp.TabStop = true;
      this.radioButtonDayApp.Text = "Просмотр приемов на день";
      this.radioButtonDayApp.UseVisualStyleBackColor = true;
      this.radioButtonDayApp.CheckedChanged += new System.EventHandler(this.radioButtonDayApp_CheckedChanged);
      // 
      // radioButtonDayPatients
      // 
      this.radioButtonDayPatients.AutoSize = true;
      this.radioButtonDayPatients.Location = new System.Drawing.Point(23, 92);
      this.radioButtonDayPatients.Name = "radioButtonDayPatients";
      this.radioButtonDayPatients.Size = new System.Drawing.Size(223, 21);
      this.radioButtonDayPatients.TabIndex = 1;
      this.radioButtonDayPatients.TabStop = true;
      this.radioButtonDayPatients.Text = "Просмотр пациентов на день";
      this.radioButtonDayPatients.UseVisualStyleBackColor = true;
      this.radioButtonDayPatients.CheckedChanged += new System.EventHandler(this.radioButtonDayPatients_CheckedChanged);
      // 
      // radioButtonFreeDoc
      // 
      this.radioButtonFreeDoc.AutoSize = true;
      this.radioButtonFreeDoc.Location = new System.Drawing.Point(23, 135);
      this.radioButtonFreeDoc.Name = "radioButtonFreeDoc";
      this.radioButtonFreeDoc.Size = new System.Drawing.Size(236, 38);
      this.radioButtonFreeDoc.TabIndex = 2;
      this.radioButtonFreeDoc.TabStop = true;
      this.radioButtonFreeDoc.Text = "Просмотр врачей, \r\nу которых нет приемов на день";
      this.radioButtonFreeDoc.UseVisualStyleBackColor = true;
      this.radioButtonFreeDoc.CheckedChanged += new System.EventHandler(this.radioButtonFreeDoc_CheckedChanged);
      // 
      // mainGrid
      // 
      this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mainGrid.Location = new System.Drawing.Point(12, 257);
      this.mainGrid.Name = "mainGrid";
      this.mainGrid.RowHeadersWidth = 51;
      this.mainGrid.RowTemplate.Height = 24;
      this.mainGrid.Size = new System.Drawing.Size(786, 373);
      this.mainGrid.TabIndex = 29;
      // 
      // FDWviewinfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(810, 642);
      this.Controls.Add(this.mainGrid);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.monthCalendar);
      this.Controls.Add(this.btnRegister);
      this.Controls.Add(this.btnChangeProfile);
      this.Name = "FDWviewinfo";
      this.Text = "Просмотр Информации";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnChangeProfile;
    private System.Windows.Forms.MonthCalendar monthCalendar;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButtonFreeDoc;
    private System.Windows.Forms.RadioButton radioButtonDayPatients;
    private System.Windows.Forms.RadioButton radioButtonDayApp;
    private System.Windows.Forms.DataGridView mainGrid;
  }
}