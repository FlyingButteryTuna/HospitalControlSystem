
namespace kp5
{
  partial class doctors_change_recs
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
      this.button1 = new System.Windows.Forms.Button();
      this.btnInfo = new System.Windows.Forms.Button();
      this.btnAddRecs = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // mainGrid
      // 
      this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mainGrid.Location = new System.Drawing.Point(13, 94);
      this.mainGrid.Name = "mainGrid";
      this.mainGrid.RowHeadersWidth = 51;
      this.mainGrid.RowTemplate.Height = 24;
      this.mainGrid.Size = new System.Drawing.Size(775, 271);
      this.mainGrid.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(306, 371);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(169, 67);
      this.button1.TabIndex = 1;
      this.button1.Text = "Сохранить";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnInfo
      // 
      this.btnInfo.Location = new System.Drawing.Point(207, 12);
      this.btnInfo.Name = "btnInfo";
      this.btnInfo.Size = new System.Drawing.Size(398, 23);
      this.btnInfo.TabIndex = 2;
      this.btnInfo.Text = "Просмотр информации";
      this.btnInfo.UseVisualStyleBackColor = true;
      this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
      // 
      // btnAddRecs
      // 
      this.btnAddRecs.Location = new System.Drawing.Point(13, 371);
      this.btnAddRecs.Name = "btnAddRecs";
      this.btnAddRecs.Size = new System.Drawing.Size(133, 67);
      this.btnAddRecs.TabIndex = 5;
      this.btnAddRecs.Text = "Добавить \r\nрекомендации и жалобы";
      this.btnAddRecs.UseVisualStyleBackColor = true;
      this.btnAddRecs.Click += new System.EventHandler(this.btnAddRecs_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(613, 371);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(84, 67);
      this.button2.TabIndex = 14;
      this.button2.Text = "Сменить\r\nпароль";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click_1);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(703, 371);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(87, 67);
      this.btnExit.TabIndex = 13;
      this.btnExit.Text = "Выход";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(152, 371);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(90, 66);
      this.button3.TabIndex = 15;
      this.button3.Text = "Обновить";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // doctors_change_recs
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnAddRecs);
      this.Controls.Add(this.btnInfo);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.mainGrid);
      this.Name = "doctors_change_recs";
      this.Text = "Изменение данных приемов";
      ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView mainGrid;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnInfo;
    private System.Windows.Forms.Button btnAddRecs;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button button3;
  }
}