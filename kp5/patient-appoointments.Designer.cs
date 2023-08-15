
namespace kp5
{
  partial class PatientAppoointments
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
      this.btnChangeApp = new System.Windows.Forms.Button();
      this.btnViewInfo = new System.Windows.Forms.Button();
      this.labelDocSpec = new System.Windows.Forms.Label();
      this.labelDoc = new System.Windows.Forms.Label();
      this.labelDate = new System.Windows.Forms.Label();
      this.comboBoxSpec = new System.Windows.Forms.ComboBox();
      this.comboBoxDoc = new System.Windows.Forms.ComboBox();
      this.comboBoxDate = new System.Windows.Forms.ComboBox();
      this.btnApplyForApp = new System.Windows.Forms.Button();
      this.labelTime = new System.Windows.Forms.Label();
      this.comboBoxTime = new System.Windows.Forms.ComboBox();
      this.button2 = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnChangeApp
      // 
      this.btnChangeApp.Location = new System.Drawing.Point(12, 12);
      this.btnChangeApp.Name = "btnChangeApp";
      this.btnChangeApp.Size = new System.Drawing.Size(378, 23);
      this.btnChangeApp.TabIndex = 0;
      this.btnChangeApp.Text = "Изменение приема";
      this.btnChangeApp.UseVisualStyleBackColor = true;
      this.btnChangeApp.Click += new System.EventHandler(this.btnChangeApp_Click);
      // 
      // btnViewInfo
      // 
      this.btnViewInfo.Location = new System.Drawing.Point(410, 12);
      this.btnViewInfo.Name = "btnViewInfo";
      this.btnViewInfo.Size = new System.Drawing.Size(378, 23);
      this.btnViewInfo.TabIndex = 1;
      this.btnViewInfo.Text = "Просмотр информации";
      this.btnViewInfo.UseVisualStyleBackColor = true;
      this.btnViewInfo.Click += new System.EventHandler(this.btnViewInfo_Click);
      // 
      // labelDocSpec
      // 
      this.labelDocSpec.AutoSize = true;
      this.labelDocSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelDocSpec.Location = new System.Drawing.Point(29, 97);
      this.labelDocSpec.Name = "labelDocSpec";
      this.labelDocSpec.Size = new System.Drawing.Size(275, 29);
      this.labelDocSpec.TabIndex = 2;
      this.labelDocSpec.Text = "Специализация врача";
      // 
      // labelDoc
      // 
      this.labelDoc.AutoSize = true;
      this.labelDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelDoc.Location = new System.Drawing.Point(234, 147);
      this.labelDoc.Name = "labelDoc";
      this.labelDoc.Size = new System.Drawing.Size(70, 29);
      this.labelDoc.TabIndex = 3;
      this.labelDoc.Text = "Врач";
      // 
      // labelDate
      // 
      this.labelDate.AutoSize = true;
      this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelDate.Location = new System.Drawing.Point(234, 203);
      this.labelDate.Name = "labelDate";
      this.labelDate.Size = new System.Drawing.Size(67, 29);
      this.labelDate.TabIndex = 4;
      this.labelDate.Text = "Дата";
      // 
      // comboBoxSpec
      // 
      this.comboBoxSpec.FormattingEnabled = true;
      this.comboBoxSpec.Location = new System.Drawing.Point(379, 104);
      this.comboBoxSpec.Name = "comboBoxSpec";
      this.comboBoxSpec.Size = new System.Drawing.Size(409, 24);
      this.comboBoxSpec.TabIndex = 5;
      this.comboBoxSpec.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpec_SelectedIndexChanged);
      // 
      // comboBoxDoc
      // 
      this.comboBoxDoc.FormattingEnabled = true;
      this.comboBoxDoc.Location = new System.Drawing.Point(379, 154);
      this.comboBoxDoc.Name = "comboBoxDoc";
      this.comboBoxDoc.Size = new System.Drawing.Size(409, 24);
      this.comboBoxDoc.TabIndex = 6;
      this.comboBoxDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoc_SelectedIndexChanged);
      // 
      // comboBoxDate
      // 
      this.comboBoxDate.FormattingEnabled = true;
      this.comboBoxDate.Location = new System.Drawing.Point(379, 210);
      this.comboBoxDate.Name = "comboBoxDate";
      this.comboBoxDate.Size = new System.Drawing.Size(409, 24);
      this.comboBoxDate.TabIndex = 7;
      this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged);
      // 
      // btnApplyForApp
      // 
      this.btnApplyForApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnApplyForApp.Location = new System.Drawing.Point(305, 323);
      this.btnApplyForApp.Name = "btnApplyForApp";
      this.btnApplyForApp.Size = new System.Drawing.Size(186, 98);
      this.btnApplyForApp.TabIndex = 8;
      this.btnApplyForApp.Text = "Записаться на\r\nприем";
      this.btnApplyForApp.UseVisualStyleBackColor = true;
      this.btnApplyForApp.Click += new System.EventHandler(this.btnApplyForApp_Click);
      // 
      // labelTime
      // 
      this.labelTime.AutoSize = true;
      this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelTime.Location = new System.Drawing.Point(212, 259);
      this.labelTime.Name = "labelTime";
      this.labelTime.Size = new System.Drawing.Size(89, 29);
      this.labelTime.TabIndex = 9;
      this.labelTime.Text = "Время";
      // 
      // comboBoxTime
      // 
      this.comboBoxTime.FormattingEnabled = true;
      this.comboBoxTime.Location = new System.Drawing.Point(379, 266);
      this.comboBoxTime.Name = "comboBoxTime";
      this.comboBoxTime.Size = new System.Drawing.Size(409, 24);
      this.comboBoxTime.TabIndex = 10;
      this.comboBoxTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxTime_SelectedIndexChanged);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(617, 371);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(84, 67);
      this.button2.TabIndex = 12;
      this.button2.Text = "Сменить\r\nпароль";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(707, 371);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(87, 67);
      this.btnExit.TabIndex = 11;
      this.btnExit.Text = "Выход";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // PatientAppoointments
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.comboBoxTime);
      this.Controls.Add(this.labelTime);
      this.Controls.Add(this.btnApplyForApp);
      this.Controls.Add(this.comboBoxDate);
      this.Controls.Add(this.comboBoxDoc);
      this.Controls.Add(this.comboBoxSpec);
      this.Controls.Add(this.labelDate);
      this.Controls.Add(this.labelDoc);
      this.Controls.Add(this.labelDocSpec);
      this.Controls.Add(this.btnViewInfo);
      this.Controls.Add(this.btnChangeApp);
      this.Name = "PatientAppoointments";
      this.Text = "Запись к врачу";
      this.Load += new System.EventHandler(this.patient_appoointments_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnChangeApp;
    private System.Windows.Forms.Button btnViewInfo;
    private System.Windows.Forms.Label labelDocSpec;
    private System.Windows.Forms.Label labelDoc;
    private System.Windows.Forms.Label labelDate;
    private System.Windows.Forms.ComboBox comboBoxSpec;
    private System.Windows.Forms.ComboBox comboBoxDoc;
    private System.Windows.Forms.ComboBox comboBoxDate;
    private System.Windows.Forms.Button btnApplyForApp;
    private System.Windows.Forms.Label labelTime;
    private System.Windows.Forms.ComboBox comboBoxTime;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnExit;
  }
}