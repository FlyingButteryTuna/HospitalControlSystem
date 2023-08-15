
namespace kp5
{
  partial class docs_change_psw
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
      this.buttonBack = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxOld = new System.Windows.Forms.TextBox();
      this.textBoxNew = new System.Windows.Forms.TextBox();
      this.checkBoxOld = new System.Windows.Forms.CheckBox();
      this.checkBoxNew = new System.Windows.Forms.CheckBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonBack
      // 
      this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.buttonBack.Location = new System.Drawing.Point(12, 349);
      this.buttonBack.Name = "buttonBack";
      this.buttonBack.Size = new System.Drawing.Size(154, 89);
      this.buttonBack.TabIndex = 6;
      this.buttonBack.Text = "Вернуться";
      this.buttonBack.UseVisualStyleBackColor = true;
      this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(199, 80);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(193, 29);
      this.label1.TabIndex = 7;
      this.label1.Text = "Старый Пароль";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(199, 175);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(179, 29);
      this.label2.TabIndex = 8;
      this.label2.Text = "Новый пароль";
      // 
      // textBoxOld
      // 
      this.textBoxOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxOld.Location = new System.Drawing.Point(398, 80);
      this.textBoxOld.Name = "textBoxOld";
      this.textBoxOld.Size = new System.Drawing.Size(185, 34);
      this.textBoxOld.TabIndex = 9;
      // 
      // textBoxNew
      // 
      this.textBoxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxNew.Location = new System.Drawing.Point(398, 170);
      this.textBoxNew.Name = "textBoxNew";
      this.textBoxNew.Size = new System.Drawing.Size(185, 34);
      this.textBoxNew.TabIndex = 10;
      // 
      // checkBoxOld
      // 
      this.checkBoxOld.AutoSize = true;
      this.checkBoxOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBoxOld.Location = new System.Drawing.Point(624, 82);
      this.checkBoxOld.Name = "checkBoxOld";
      this.checkBoxOld.Size = new System.Drawing.Size(142, 33);
      this.checkBoxOld.TabIndex = 11;
      this.checkBoxOld.Text = "Показать";
      this.checkBoxOld.UseVisualStyleBackColor = true;
      this.checkBoxOld.CheckedChanged += new System.EventHandler(this.checkBoxOld_CheckedChanged);
      // 
      // checkBoxNew
      // 
      this.checkBoxNew.AutoSize = true;
      this.checkBoxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBoxNew.Location = new System.Drawing.Point(624, 175);
      this.checkBoxNew.Name = "checkBoxNew";
      this.checkBoxNew.Size = new System.Drawing.Size(142, 33);
      this.checkBoxNew.TabIndex = 12;
      this.checkBoxNew.Text = "Показать";
      this.checkBoxNew.UseVisualStyleBackColor = true;
      this.checkBoxNew.CheckedChanged += new System.EventHandler(this.checkBoxNew_CheckedChanged);
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnSave.Location = new System.Drawing.Point(311, 281);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(177, 66);
      this.btnSave.TabIndex = 13;
      this.btnSave.Text = "Сохранить";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // docs_change_psw
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.checkBoxNew);
      this.Controls.Add(this.checkBoxOld);
      this.Controls.Add(this.textBoxNew);
      this.Controls.Add(this.textBoxOld);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonBack);
      this.Name = "docs_change_psw";
      this.Text = "Смена пароля";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonBack;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxOld;
    private System.Windows.Forms.TextBox textBoxNew;
    private System.Windows.Forms.CheckBox checkBoxOld;
    private System.Windows.Forms.CheckBox checkBoxNew;
    private System.Windows.Forms.Button btnSave;
  }
}