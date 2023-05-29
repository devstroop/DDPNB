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
            DDPNB.Data.DataClassesDataContext data = new Data.DataClassesDataContext();
            if (data.Users.Count() == 0) 
            {
                InitialSetup();
            }
            if (DDPNB.Common.User != null)
            {
                this.usersToolStripMenuItem.Visible = true;
                this.jobsToolStripMenuItem.Visible = true;
                this.transactionsToolStripMenuItem.Visible = true;
                this.microservicesToolStripMenuItem.Visible = true;

                this.loginToolStripMenuItem.Visible = false;
                this.profileToolStripMenuItem.Visible = true;
                this.logoutToolStripMenuItem.Visible = true;

                this.profileToolStripMenuItem.Text = $"{Common.User.Email.Trim()}";
                this.profileToolStripMenuItem.Image = global::DDPNB.Properties.Resources.accept_x16;
            }
            else
            {
                this.usersToolStripMenuItem.Visible = false;
                this.jobsToolStripMenuItem.Visible = false;
                this.transactionsToolStripMenuItem.Visible = false;
                this.microservicesToolStripMenuItem.Visible = false;

                this.loginToolStripMenuItem.Visible = true;
                this.profileToolStripMenuItem.Visible = false;
                this.logoutToolStripMenuItem.Visible = false;

                this.profileToolStripMenuItem.Text = "Profile";
                this.profileToolStripMenuItem.Image = global::DDPNB.Properties.Resources.warning_x16;
            }
        }

        private void InitialSetup()
        {
            DialogResult result = MessageBox.Show("Do you want to proceed initial setup?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    // Show New User Form
                    // Create User
                    // Assign Admin
                    MessageBox.Show("Initial setup completed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLogin = new DDPNB.Forms.FrmLogin();
            frmLogin.ShowDialog();
            if (Common.User != null)
            {
                MessageBox.Show($"Success ({Common.User.Email.Trim()})", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Login failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
