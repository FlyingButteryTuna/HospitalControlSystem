
namespace kp5
{
  partial class LoginScreen
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
      this.btnLogin = new System.Windows.Forms.Button();
      this.labelLogin = new System.Windows.Forms.Label();
      this.labelPassword = new System.Windows.Forms.Label();
      this.txtBoxPassword = new System.Windows.Forms.TextBox();
      this.txtBoxLogin = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.checkBoxPsw = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // btnLogin
      // 
      this.btnLogin.Location = new System.Drawing.Point(328, 344);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(138, 53);
      this.btnLogin.TabIndex = 0;
      this.btnLogin.Text = "Войти";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.button1_Click);
      // 
      // labelLogin
      // 
      this.labelLogin.AutoSize = true;
      this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelLogin.Location = new System.Drawing.Point(169, 153);
      this.labelLogin.Name = "labelLogin";
      this.labelLogin.Size = new System.Drawing.Size(83, 29);
      this.labelLogin.TabIndex = 1;
      this.labelLogin.Text = "Логин";
      // 
      // labelPassword
      // 
      this.labelPassword.AutoSize = true;
      this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelPassword.Location = new System.Drawing.Point(153, 241);
      this.labelPassword.Name = "labelPassword";
      this.labelPassword.Size = new System.Drawing.Size(99, 29);
      this.labelPassword.TabIndex = 2;
      this.labelPassword.Text = "Пароль";
      // 
      // txtBoxPassword
      // 
      this.txtBoxPassword.Location = new System.Drawing.Point(294, 248);
      this.txtBoxPassword.Name = "txtBoxPassword";
      this.txtBoxPassword.Size = new System.Drawing.Size(201, 22);
      this.txtBoxPassword.TabIndex = 3;
      // 
      // txtBoxLogin
      // 
      this.txtBoxLogin.Location = new System.Drawing.Point(294, 153);
      this.txtBoxLogin.Name = "txtBoxLogin";
      this.txtBoxLogin.Size = new System.Drawing.Size(201, 22);
      this.txtBoxLogin.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(313, 58);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(169, 32);
      this.label1.TabIndex = 5;
      this.label1.Text = "Клиника \"x\"";
      // 
      // checkBoxPsw
      // 
      this.checkBoxPsw.AutoSize = true;
      this.checkBoxPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBoxPsw.Location = new System.Drawing.Point(541, 243);
      this.checkBoxPsw.Name = "checkBoxPsw";
      this.checkBoxPsw.Size = new System.Drawing.Size(192, 29);
      this.checkBoxPsw.TabIndex = 6;
      this.checkBoxPsw.Text = "Показать пароль";
      this.checkBoxPsw.UseVisualStyleBackColor = true;
      this.checkBoxPsw.CheckedChanged += new System.EventHandler(this.checkBoxPsw_CheckedChanged);
      // 
      // LoginScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.checkBoxPsw);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtBoxLogin);
      this.Controls.Add(this.txtBoxPassword);
      this.Controls.Add(this.labelPassword);
      this.Controls.Add(this.labelLogin);
      this.Controls.Add(this.btnLogin);
      this.Name = "LoginScreen";
      this.Text = "Вход";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Label labelLogin;
    private System.Windows.Forms.Label labelPassword;
    private System.Windows.Forms.TextBox txtBoxPassword;
    private System.Windows.Forms.TextBox txtBoxLogin;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox checkBoxPsw;
  }
}

