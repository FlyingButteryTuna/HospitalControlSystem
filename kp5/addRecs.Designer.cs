
namespace kp5
{
  partial class addRecs
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
      this.textBoxrecs = new System.Windows.Forms.TextBox();
      this.textBoxComps = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.buttonBack = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBoxrecs
      // 
      this.textBoxrecs.Location = new System.Drawing.Point(41, 109);
      this.textBoxrecs.Multiline = true;
      this.textBoxrecs.Name = "textBoxrecs";
      this.textBoxrecs.Size = new System.Drawing.Size(317, 197);
      this.textBoxrecs.TabIndex = 0;
      // 
      // textBoxComps
      // 
      this.textBoxComps.Location = new System.Drawing.Point(436, 109);
      this.textBoxComps.Multiline = true;
      this.textBoxComps.Name = "textBoxComps";
      this.textBoxComps.Size = new System.Drawing.Size(333, 197);
      this.textBoxComps.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(160, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "Жалобы";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(549, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(105, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Рекомендации";
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(319, 353);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(141, 47);
      this.btnAdd.TabIndex = 4;
      this.btnAdd.Text = "Добавить";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // buttonBack
      // 
      this.buttonBack.Location = new System.Drawing.Point(13, 374);
      this.buttonBack.Name = "buttonBack";
      this.buttonBack.Size = new System.Drawing.Size(106, 64);
      this.buttonBack.TabIndex = 5;
      this.buttonBack.Text = "Вернуться";
      this.buttonBack.UseVisualStyleBackColor = true;
      this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
      // 
      // addRecs
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.buttonBack);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxComps);
      this.Controls.Add(this.textBoxrecs);
      this.Name = "addRecs";
      this.Text = "Добавление рекомендаций и жалоб";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxrecs;
    private System.Windows.Forms.TextBox textBoxComps;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button buttonBack;
  }
}