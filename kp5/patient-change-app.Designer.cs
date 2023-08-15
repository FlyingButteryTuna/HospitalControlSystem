
namespace kp5
{
  partial class PatientChangeApp
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
      this.components = new System.ComponentModel.Container();
      this.btnRegAps = new System.Windows.Forms.Button();
      this.btnViewInfo = new System.Windows.Forms.Button();
      this.mainGrid = new System.Windows.Forms.DataGridView();
      this.kpDataSet = new kp5.kpDataSet();
      this.appointmentStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.appointmentStatusTableAdapter = new kp5.kpDataSetTableAdapters.AppointmentStatusTableAdapter();
      this.kpDataSet1 = new kp5.kpDataSet1();
      this.appointmentStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.appointmentStatusTableAdapter1 = new kp5.kpDataSet1TableAdapters.AppointmentStatusTableAdapter();
      this.btnSave = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.kpDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.kpDataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusBindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnRegAps
      // 
      this.btnRegAps.Location = new System.Drawing.Point(13, 13);
      this.btnRegAps.Name = "btnRegAps";
      this.btnRegAps.Size = new System.Drawing.Size(377, 23);
      this.btnRegAps.TabIndex = 0;
      this.btnRegAps.Text = "Запись на прием";
      this.btnRegAps.UseVisualStyleBackColor = true;
      this.btnRegAps.Click += new System.EventHandler(this.btnRegAps_Click);
      // 
      // btnViewInfo
      // 
      this.btnViewInfo.Location = new System.Drawing.Point(411, 13);
      this.btnViewInfo.Name = "btnViewInfo";
      this.btnViewInfo.Size = new System.Drawing.Size(377, 23);
      this.btnViewInfo.TabIndex = 1;
      this.btnViewInfo.Text = "Просмотр информации";
      this.btnViewInfo.UseVisualStyleBackColor = true;
      this.btnViewInfo.Click += new System.EventHandler(this.btnViewInfo_Click);
      // 
      // mainGrid
      // 
      this.mainGrid.ColumnHeadersHeight = 29;
      this.mainGrid.Location = new System.Drawing.Point(13, 99);
      this.mainGrid.Name = "mainGrid";
      this.mainGrid.RowHeadersWidth = 51;
      this.mainGrid.RowTemplate.Height = 24;
      this.mainGrid.Size = new System.Drawing.Size(775, 272);
      this.mainGrid.TabIndex = 2;
      // 
      // kpDataSet
      // 
      this.kpDataSet.DataSetName = "kpDataSet";
      this.kpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // appointmentStatusBindingSource
      // 
      this.appointmentStatusBindingSource.DataMember = "AppointmentStatus";
      this.appointmentStatusBindingSource.DataSource = this.kpDataSet;
      // 
      // appointmentStatusTableAdapter
      // 
      this.appointmentStatusTableAdapter.ClearBeforeFill = true;
      // 
      // kpDataSet1
      // 
      this.kpDataSet1.DataSetName = "kpDataSet1";
      this.kpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // appointmentStatusBindingSource1
      // 
      this.appointmentStatusBindingSource1.DataMember = "AppointmentStatus";
      this.appointmentStatusBindingSource1.DataSource = this.kpDataSet1;
      // 
      // appointmentStatusTableAdapter1
      // 
      this.appointmentStatusTableAdapter1.ClearBeforeFill = true;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(306, 386);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(183, 48);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "Сохранить";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(13, 386);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(91, 52);
      this.button1.TabIndex = 4;
      this.button1.Text = "Обновить";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // PatientChangeApp
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.mainGrid);
      this.Controls.Add(this.btnViewInfo);
      this.Controls.Add(this.btnRegAps);
      this.Name = "PatientChangeApp";
      this.Text = "Изменение приема";
      this.Load += new System.EventHandler(this.patient_change_app_Load);
      ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.kpDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.kpDataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusBindingSource1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnRegAps;
    private System.Windows.Forms.Button btnViewInfo;
    private System.Windows.Forms.DataGridView mainGrid;
    private kpDataSet kpDataSet;
    private System.Windows.Forms.BindingSource appointmentStatusBindingSource;
    private kpDataSetTableAdapters.AppointmentStatusTableAdapter appointmentStatusTableAdapter;
    private kpDataSet1 kpDataSet1;
    private System.Windows.Forms.BindingSource appointmentStatusBindingSource1;
    private kpDataSet1TableAdapters.AppointmentStatusTableAdapter appointmentStatusTableAdapter1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button button1;
  }
}