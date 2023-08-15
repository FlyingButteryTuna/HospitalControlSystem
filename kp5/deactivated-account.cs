using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kp5
{
  public partial class deactivated_account : Form
  {
    private LoginScreen lgScreen_;
    public deactivated_account()
    {
      InitializeComponent();
    }
    public deactivated_account(LoginScreen lgScreen)
    {
      InitializeComponent();
      lgScreen_ = lgScreen;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      lgScreen_.Show();
      this.Close();
    }
  }
}
