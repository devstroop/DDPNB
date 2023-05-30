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
                this.jobsToolStripMenuItem.Enabled = true;
                this.transactionsToolStripMenuItem.Enabled = true;
                this.microservicesToolStripMenuItem.Enabled = true;
                this.usersToolStripMenuItem.Enabled = true;
                this.utilityToolStripMenuItem.Enabled = true;
                this.configurationToolStripMenuItem.Enabled = true;
                this.flowPanelShortcuts.Enabled = true;

                this.loginToolStripMenuItem.Visible = false;
                this.profileToolStripMenuItem.Visible = true;
                this.logoutToolStripMenuItem.Visible = true;

                this.profileToolStripMenuItem.Text = $"{Common.User.Email.Trim()}";
                this.profileToolStripMenuItem.Image = global::DDPNB.Properties.Resources.accept_x16;
            }
            else
            {
                this.jobsToolStripMenuItem.Enabled = false;
                this.transactionsToolStripMenuItem.Enabled = false;
                this.microservicesToolStripMenuItem.Enabled = false;
                this.usersToolStripMenuItem.Enabled = false;
                this.utilityToolStripMenuItem.Enabled = false;
                this.configurationToolStripMenuItem.Enabled = false;
                this.flowPanelShortcuts.Enabled = false;

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
                    (new Users.FrmNewUser()).ShowDialog();
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
            var frmLogin = new DDPNB.Forms.FrmLogin() ;
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

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmConfiguration(){ MdiParent = this }).Show();
        }

        private void newJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Jobs.FrmNewJob(){ MdiParent = this }).Show();
        }

        private void modifyJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Jobs.FrmModifyJob(){ MdiParent = this }).Show();
        }

        private void deleteJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Jobs.FrmDeleteJob(){ MdiParent = this }).Show();
        }

        private void suspendJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Jobs.FrmSuspendActivateJob(){ MdiParent = this }).Show();
        }

        private void allJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Jobs.FrmAllJobs(){ MdiParent = this }).Show();
        }

        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Transactions.FrmNewTransaction(){ MdiParent = this }).Show();
        }

        private void modifyTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Transactions.FrmModifyTransaction(){ MdiParent = this }).Show();
        }

        private void deleteTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Transactions.FrmDeleteTransaction(){ MdiParent = this }).Show();
        }

        private void allTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Transactions.FrmAllTransactions(){ MdiParent = this }).Show();
        }

        private void suspendMicroservicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Microservices.FrmSuspendActivateMicroservice(){ MdiParent = this }).Show();
        }

        private void findMicroservicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Microservices.FrmFindMicroservices(){ MdiParent = this }).Show();
        }

        private void allMicroservicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Microservices.FrmAllMicroservices(){ MdiParent = this }).Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Users.FrmNewUser(){ MdiParent = this }).Show();
        }

        private void modifyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Users.FrmModifyUser(){ MdiParent = this }).Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Users.FrmDeleteUser(){ MdiParent = this }).Show();
        }

        private void suspendUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Users.FrmSuspentActivateUser(){ MdiParent = this }).Show();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Users.FrmAllUsers(){ MdiParent = this }).Show();
        }

        private void importJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmImport(){ MdiParent = this }).Show();
        }

        private void importTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmImport(){ MdiParent = this }).Show();
        }

        private void importMicroservicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmImport(){ MdiParent = this }).Show();
        }

        private void importUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmImport(){ MdiParent = this }).Show();
        }

        private void importAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmImport(){ MdiParent = this }).Show();
        }

        private void exportJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmExport(){ MdiParent = this }).Show();
        }

        private void exportTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmExport(){ MdiParent = this }).Show();
        }

        private void exportMicroservicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmExport(){ MdiParent = this }).Show();
        }

        private void exportUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmExport(){ MdiParent = this }).Show();
        }

        private void exportAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmExport(){ MdiParent = this }).Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmBackup(){ MdiParent = this }).Show();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Utility.FrmRestore(){ MdiParent = this }).Show();
        }

        private void tsBtnRunningAt_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tsBtnRunningAt.Text);
            MessageBox.Show("Copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnF1_Click(object sender, EventArgs e)
        {

        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            (new Jobs.FrmNewJob() { MdiParent = this }).Show();
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            (new Transactions.FrmNewTransaction() { MdiParent = this }).Show();
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            (new Users.FrmNewUser() { MdiParent = this }).Show();
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            (new Jobs.FrmAllJobs() { MdiParent = this }).Show();
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            (new Transactions.FrmAllTransactions() { MdiParent = this }).Show();
        }

        private void btnF7_Click(object sender, EventArgs e)
        {
            (new Users.FrmAllUsers() { MdiParent = this }).Show();
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
            (new Microservices.FrmAllMicroservices() { MdiParent = this }).Show();
        }

        private void tsBtnAbout_Click(object sender, EventArgs e)
        {
            (new FrmAbout() { MdiParent = this }).Show();
        }

        private void tsBtnReleaseNote_Click(object sender, EventArgs e)
        {
            (new FrmReleaseNote() { MdiParent = this }).Show();
        }

        private void userRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Users.UserRoles.FrmAllUserRoles() { MdiParent = this }).Show();
        }

        private void newRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Users.UserRoles.FrmNewUserRole() { MdiParent = this }).Show();
        }

        private void modifyRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Users.UserRoles.FrmModifyUserRole() { MdiParent = this }).Show();
        }

        private void deleteRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Users.UserRoles.FrmDeleteUserRole() { MdiParent = this }).Show();
        }

        private void allRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Users.UserRoles.FrmAllUserRoles() { MdiParent = this }).Show();
        }
    }
}
