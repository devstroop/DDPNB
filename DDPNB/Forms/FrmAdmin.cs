using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDPNB.Forms
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var user = DDPNB.Forms.FrmLogin.Login(host: "http://localhost:5001");
            if (user != null)
            {
                MessageBox.Show($"Success: {user.Email}");
            }
            else
            {
                MessageBox.Show($"Failed");
            }*/
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            if (DDPNB.Common.LoggedInUser != null)
            {
                this.loginToolStripMenuItem.Visible = false;
                this.profileToolStripMenuItem.Visible = true;
                this.logoutToolStripMenuItem.Visible = true;
            }
            else
            {
                this.loginToolStripMenuItem.Visible = true;
                this.profileToolStripMenuItem.Visible = false;
                this.logoutToolStripMenuItem.Visible = false;
            }
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var frmLogin = new DDPNB.Forms.FrmLogin();
            frmLogin.ShowDialog();
            if (Common.LoggedInUser != null)
            {
                MessageBox.Show($"Success: {Common.LoggedInUser.Email}");
            }
            else
            {
                MessageBox.Show($"Failed");
            }
            FrmAdmin_Load(sender, e);
        }
    }
}
