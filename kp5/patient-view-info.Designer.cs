
namespace kp5
{
  partial class PatientViewInfo
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
      this.groupBoxButtons = new System.Windows.Forms.GroupBox();
      this.radioButtonScheduleSpecDoc = new System.Windows.Forms.RadioButton();
      this.radioButtonDocs = new System.Windows.Forms.RadioButton();
      this.radioButtonApps = new System.Windows.Forms.RadioButton();
      this.btnRegAps = new System.Windows.Forms.Button();
      this.btnChangeAps = new System.Windows.Forms.Button();
      this.mainGrid = new System.Windows.Forms.DataGridView();
      this.comboBoxSpec = new System.Windows.Forms.ComboBox();
      this.labelChooseSpec = new System.Windows.Forms.Label();
      this.labelDoc = new System.Windows.Forms.Label();
      this.comboBoxDoc = new System.Windows.Forms.ComboBox();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBoxButtons.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBoxButtons
      // 
      this.groupBoxButtons.Controls.Add(this.radioButtonScheduleSpecDoc);
      this.groupBoxButtons.Controls.Add(this.radioButtonDocs);
      this.groupBoxButtons.Controls.Add(this.radioButtonApps);
      this.groupBoxButtons.Location = new System.Drawing.Point(13, 50);
      this.groupBoxButtons.Name = "groupBoxButtons";
      this.groupBoxButtons.Size = new System.Drawing.Size(775, 65);
      this.groupBoxButtons.TabIndex = 0;
      this.groupBoxButtons.TabStop = false;
      // 
      // radioButtonScheduleSpecDoc
      // 
      this.radioButtonScheduleSpecDoc.AutoSize = true;
      this.radioButtonScheduleSpecDoc.Location = new System.Drawing.Point(522, 13);
      this.radioButtonScheduleSpecDoc.Name = "radioButtonScheduleSpecDoc";
      this.radioButtonScheduleSpecDoc.Size = new System.Drawing.Size(231, 38);
      this.radioButtonScheduleSpecDoc.TabIndex = 2;
      this.radioButtonScheduleSpecDoc.Text = "Просмотр расписания врачей \r\nопределенной специализации";
      this.radioButtonScheduleSpecDoc.UseVisualStyleBackColor = true;
      this.radioButtonScheduleSpecDoc.CheckedChanged += new System.EventHandler(this.radioButtonScheduleSpecDoc_CheckedChanged);
      // 
      // radioButtonDocs
      // 
      this.radioButtonDocs.AutoSize = true;
      this.radioButtonDocs.Location = new System.Drawing.Point(284, 22);
      this.radioButtonDocs.Name = "radioButtonDocs";
      this.radioButtonDocs.Size = new System.Drawing.Size(145, 21);
      this.radioButtonDocs.TabIndex = 1;
      this.radioButtonDocs.Text = "Просмотр врачей";
      this.radioButtonDocs.UseVisualStyleBackColor = true;
      this.radioButtonDocs.CheckedChanged += new System.EventHandler(this.radioButtonDocs_CheckedChanged);
      // 
      // radioButtonApps
      // 
      this.radioButtonApps.AutoSize = true;
      this.radioButtonApps.Checked = true;
      this.radioButtonApps.Location = new System.Drawing.Point(25, 22);
      this.radioButtonApps.Name = "radioButtonApps";
      this.radioButtonApps.Size = new System.Drawing.Size(154, 21);
      this.radioButtonApps.TabIndex = 0;
      this.radioButtonApps.TabStop = true;
      this.radioButtonApps.Text = "Просмотр приемов";
      this.radioButtonApps.UseVisualStyleBackColor = true;
      this.radioButtonApps.CheckedChanged += new System.EventHandler(this.radioButtonApps_CheckedChanged);
      // 
      // btnRegAps
      // 
      this.btnRegAps.Location = new System.Drawing.Point(13, 13);
      this.btnRegAps.Name = "btnRegAps";
      this.btnRegAps.Size = new System.Drawing.Size(376, 23);
      this.btnRegAps.TabIndex = 1;
      this.btnRegAps.Text = "Запись на прием";
      this.btnRegAps.UseVisualStyleBackColor = true;
      this.btnRegAps.Click += new System.EventHandler(this.btnRegAps_Click);
      // 
      // btnChangeAps
      // 
      this.btnChangeAps.Location = new System.Drawing.Point(412, 12);
      this.btnChangeAps.Name = "btnChangeAps";
      this.btnChangeAps.Size = new System.Drawing.Size(376, 23);
      this.btnChangeAps.TabIndex = 2;
      this.btnChangeAps.Text = "Изменение приема";
      this.btnChangeAps.UseVisualStyleBackColor = true;
      this.btnChangeAps.Click += new System.EventHandler(this.btnChangeAps_Click);
      // 
      // mainGrid
      // 
      this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mainGrid.Location = new System.Drawing.Point(13, 172);
      this.mainGrid.Name = "mainGrid";
      this.mainGrid.RowHeadersWidth = 51;
      this.mainGrid.RowTemplate.Height = 24;
      this.mainGrid.Size = new System.Drawing.Size(775, 236);
      this.mainGrid.TabIndex = 3;
      // 
      // comboBoxSpec
      // 
      this.comboBoxSpec.FormattingEnabled = true;
      this.comboBoxSpec.Location = new System.Drawing.Point(148, 128);
      this.comboBoxSpec.Name = "comboBoxSpec";
      this.comboBoxSpec.Size = new System.Drawing.Size(241, 24);
      this.comboBoxSpec.TabIndex = 4;
      this.comboBoxSpec.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpec_SelectedIndexChanged);
      // 
      // labelChooseSpec
      // 
      this.labelChooseSpec.AutoSize = true;
      this.labelChooseSpec.Location = new System.Drawing.Point(26, 118);
      this.labelChooseSpec.Name = "labelChooseSpec";
      this.labelChooseSpec.Size = new System.Drawing.Size(112, 34);
      this.labelChooseSpec.TabIndex = 5;
      this.labelChooseSpec.Text = "Выберите\r\nспециализацию";
      // 
      // labelDoc
      // 
      this.labelDoc.AutoSize = true;
      this.labelDoc.Location = new System.Drawing.Point(409, 131);
      this.labelDoc.Name = "labelDoc";
      this.labelDoc.Size = new System.Drawing.Size(117, 17);
      this.labelDoc.TabIndex = 6;
      this.labelDoc.Text = "Выберите врача";
      // 
      // comboBoxDoc
      // 
      this.comboBoxDoc.FormattingEnabled = true;
      this.comboBoxDoc.Location = new System.Drawing.Point(535, 128);
      this.comboBoxDoc.Name = "comboBoxDoc";
      this.comboBoxDoc.Size = new System.Drawing.Size(241, 24);
      this.comboBoxDoc.TabIndex = 7;
      this.comboBoxDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoc_SelectedIndexChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(13, 415);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(110, 23);
      this.button1.TabIndex = 8;
      this.button1.Text = "Обновить";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // PatientViewInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.comboBoxDoc);
      this.Controls.Add(this.labelDoc);
      this.Controls.Add(this.labelChooseSpec);
      this.Controls.Add(this.comboBoxSpec);
      this.Controls.Add(this.mainGrid);
      this.Controls.Add(this.btnChangeAps);
      this.Controls.Add(this.btnRegAps);
      this.Controls.Add(this.groupBoxButtons);
      this.Name = "PatientViewInfo";
      this.Text = "Просмотр информации";
      this.Load += new System.EventHandler(this.patient_view_info_Load);
      this.groupBoxButtons.ResumeLayout(false);
      this.groupBoxButtons.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBoxButtons;
    private System.Windows.Forms.RadioButton radioButtonScheduleSpecDoc;
    private System.Windows.Forms.RadioButton radioButtonDocs;
    private System.Windows.Forms.RadioButton radioButtonApps;
    private System.Windows.Forms.Button btnRegAps;
    private System.Windows.Forms.Button btnChangeAps;
    private System.Windows.Forms.DataGridView mainGrid;
    private System.Windows.Forms.ComboBox comboBoxSpec;
    private System.Windows.Forms.Label labelChooseSpec;
    private System.Windows.Forms.Label labelDoc;
    private System.Windows.Forms.ComboBox comboBoxDoc;
    private System.Windows.Forms.Button button1;
  }
}