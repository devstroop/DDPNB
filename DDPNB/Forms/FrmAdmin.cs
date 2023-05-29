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

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            if (DDPNB.Common.LoggedInUser != null)
            {
                this.usersToolStripMenuItem.Visible = true;
                this.jobsToolStripMenuItem.Visible = true;
                this.transactionsToolStripMenuItem.Visible = true;

                this.loginToolStripMenuItem.Visible = false;
                this.profileToolStripMenuItem.Visible = true;
                this.logoutToolStripMenuItem.Visible = true;

                this.profileToolStripMenuItem.Text = $"{Common.LoggedInUser.Email.Trim()}";
                this.profileToolStripMenuItem.Image = global::DDPNB.Properties.Resources.accept_x16;
            }
            else
            {
                this.usersToolStripMenuItem.Visible = false;
                this.jobsToolStripMenuItem.Visible = false;
                this.transactionsToolStripMenuItem.Visible = false;

                this.loginToolStripMenuItem.Visible = true;
                this.profileToolStripMenuItem.Visible = false;
                this.logoutToolStripMenuItem.Visible = false;

                this.profileToolStripMenuItem.Text = "Profile";
                this.profileToolStripMenuItem.Image = global::DDPNB.Properties.Resources.warning_x16;
            }
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var frmLogin = new DDPNB.Forms.FrmLogin();
            frmLogin.ShowDialog();
            if (Common.LoggedInUser != null)
            {
                MessageBox.Show($"Success ({Common.LoggedInUser.Email.Trim()})");
            }
            else
            {
                MessageBox.Show($"Failed");
            }
            FrmAdmin_Load(sender, e);
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmDeveloper()).ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmAbout()).ShowDialog();
        }

        private void releaseNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmReleaseNote()).ShowDialog();
        }
    }
}
