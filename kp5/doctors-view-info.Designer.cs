
namespace kp5
{
  partial class doctors_view_info
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
      this.mainGrid = new System.Windows.Forms.DataGridView();
      this.btnChangeAps = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radioButtonPlannedApps = new System.Windows.Forms.RadioButton();
      this.radioButtonPatients = new System.Windows.Forms.RadioButton();
      this.radioButtonPastApps = new System.Windows.Forms.RadioButton();
      this.radioButtonAmountPlanned = new System.Windows.Forms.RadioButton();
      ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // mainGrid
      // 
      this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mainGrid.Location = new System.Drawing.Point(13, 151);
      this.mainGrid.Name = "mainGrid";
      this.mainGrid.RowHeadersWidth = 51;
      this.mainGrid.RowTemplate.Height = 24;
      this.mainGrid.Size = new System.Drawing.Size(775, 287);
      this.mainGrid.TabIndex = 0;
      // 
      // btnChangeAps
      // 
      this.btnChangeAps.Location = new System.Drawing.Point(213, 12);
      this.btnChangeAps.Name = "btnChangeAps";
      this.btnChangeAps.Size = new System.Drawing.Size(398, 23);
      this.btnChangeAps.TabIndex = 3;
      this.btnChangeAps.Text = "Изменение приемов";
      this.btnChangeAps.UseVisualStyleBackColor = true;
      this.btnChangeAps.Click += new System.EventHandler(this.btnChangeAps_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButtonAmountPlanned);
      this.groupBox1.Controls.Add(this.radioButtonPastApps);
      this.groupBox1.Controls.Add(this.radioButtonPatients);
      this.groupBox1.Controls.Add(this.radioButtonPlannedApps);
      this.groupBox1.Location = new System.Drawing.Point(13, 41);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(775, 90);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      // 
      // radioButtonPlannedApps
      // 
      this.radioButtonPlannedApps.AutoSize = true;
      this.radioButtonPlannedApps.Location = new System.Drawing.Point(6, 27);
      this.radioButtonPlannedApps.Name = "radioButtonPlannedApps";
      this.radioButtonPlannedApps.Size = new System.Drawing.Size(220, 38);
      this.radioButtonPlannedApps.TabIndex = 0;
      this.radioButtonPlannedApps.TabStop = true;
      this.radioButtonPlannedApps.Text = "Просмотр запланированных \r\nприемов";
      this.radioButtonPlannedApps.UseVisualStyleBackColor = true;
      this.radioButtonPlannedApps.CheckedChanged += new System.EventHandler(this.radioButtonPlannedApps_CheckedChanged);
      // 
      // radioButtonPatients
      // 
      this.radioButtonPatients.AutoSize = true;
      this.radioButtonPatients.Location = new System.Drawing.Point(241, 36);
      this.radioButtonPatients.Name = "radioButtonPatients";
      this.radioButtonPatients.Size = new System.Drawing.Size(168, 21);
      this.radioButtonPatients.TabIndex = 1;
      this.radioButtonPatients.TabStop = true;
      this.radioButtonPatients.Text = "Просмотр пациентов";
      this.radioButtonPatients.UseVisualStyleBackColor = true;
      this.radioButtonPatients.CheckedChanged += new System.EventHandler(this.radioButtonPatients_CheckedChanged);
      // 
      // radioButtonPastApps
      // 
      this.radioButtonPastApps.AutoSize = true;
      this.radioButtonPastApps.Location = new System.Drawing.Point(424, 27);
      this.radioButtonPastApps.Name = "radioButtonPastApps";
      this.radioButtonPastApps.Size = new System.Drawing.Size(174, 38);
      this.radioButtonPastApps.TabIndex = 2;
      this.radioButtonPastApps.TabStop = true;
      this.radioButtonPastApps.Text = "Просмотр прошедших\r\nприемов";
      this.radioButtonPastApps.UseVisualStyleBackColor = true;
      this.radioButtonPastApps.CheckedChanged += new System.EventHandler(this.radioButtonPastApps_CheckedChanged);
      // 
      // radioButtonAmountPlanned
      // 
      this.radioButtonAmountPlanned.AutoSize = true;
      this.radioButtonAmountPlanned.Location = new System.Drawing.Point(628, 19);
      this.radioButtonAmountPlanned.Name = "radioButtonAmountPlanned";
      this.radioButtonAmountPlanned.Size = new System.Drawing.Size(147, 55);
      this.radioButtonAmountPlanned.TabIndex = 3;
      this.radioButtonAmountPlanned.TabStop = true;
      this.radioButtonAmountPlanned.Text = "Подсчет \r\nзапланированных\r\nприемов";
      this.radioButtonAmountPlanned.UseVisualStyleBackColor = true;
      this.radioButtonAmountPlanned.CheckedChanged += new System.EventHandler(this.radioButtonAmountPlanned_CheckedChanged);
      // 
      // doctors_view_info
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnChangeAps);
      this.Controls.Add(this.mainGrid);
      this.Name = "doctors_view_info";
      this.Text = "Просмотр информации";
      ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView mainGrid;
    private System.Windows.Forms.Button btnChangeAps;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButtonAmountPlanned;
    private System.Windows.Forms.RadioButton radioButtonPastApps;
    private System.Windows.Forms.RadioButton radioButtonPatients;
    private System.Windows.Forms.RadioButton radioButtonPlannedApps;
  }
}