using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDPNB.Forms.Users
{
    public partial class FrmModifyUser : Form
    {
        Data.DataClassesDataContext data = new Data.DataClassesDataContext();
        List<Data.UserRole> userRoles = new List<Data.UserRole>();
        Data.User user;
        public FrmModifyUser()
        {
            InitializeComponent();
            int? UserId = FrmPickUser.Pick();
            if(UserId != null) user = data.Users.Single(elem => elem.Id == UserId);
        }

        public FrmModifyUser(int? UserId)
        {
            InitializeComponent();
            if (UserId != null) user = data.Users.Single(elem => elem.Id == UserId);
        }

        private void FrmModifyUser_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                this.BeginInvoke(new Action(() => {
                    this.Close();
                }));
                return;
            }

            this.userRoles = data.UserRoles.ToList();
            this.cmbBoxRole.DataSource = this.userRoles.Select(elem => elem.Name.Trim()).ToList();

            this.lblValueId.Text = $"{user.Id}";
            this.tBoxName.Text = user.Name?.Trim();
            this.tBoxEmail.Text = user.Email?.Trim();
            this.tBoxPhone.Text = user.Phone?.Trim();
            this.tBoxAddress.Text = user.Address?.Trim();

            try
            {
                var selectedRole = userRoles.FirstOrDefault(role => role != null && role.Id == user.UserRoleId);
                if (selectedRole != null)
                {
                    this.cmbBoxRole.SelectedIndex = userRoles.IndexOf(selectedRole);
                }
            }
            catch (Exception exc)
            {
                this.lblValueCreatedBy.Text = "NA";
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.chkBoxMultiSession.Checked = user.MultiSession;
            this.chkBoxActive.Checked = user.Active;
            this.lblValueCreatedAt.Text = user.CreatedAt?.ToString() ?? "NA";

            try
            {
                if (user.CreatedBy != null)
                {
                    var createdByUser = data.Users.SingleOrDefault(elem => elem.Id == user.CreatedBy);
                    if (createdByUser != null)
                    {
                        this.lblValueCreatedBy.Text = $"{createdByUser.Name.Trim()} ({user.CreatedBy})";
                    }
                    else
                    {
                        this.lblValueCreatedBy.Text = "NA";
                    }
                }
                else
                {
                    this.lblValueCreatedBy.Text = "NA";
                }
            }
            catch (Exception exc)
            {
                this.lblValueCreatedBy.Text = "NA";
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.lblValueUpdatedAt.Text = user.UpdatedAt?.ToString() ?? "NA";

            try
            {
                if (user.UpdatedBy != null)
                {
                    var updatedByUser = data.Users.SingleOrDefault(elem => elem.Id == user.UpdatedBy);
                    if (updatedByUser != null)
                    {
                        this.lblValueUpdatedBy.Text = $"{updatedByUser.Name.Trim()} ({user.UpdatedBy})";
                    }
                    else
                    {
                        this.lblValueUpdatedBy.Text = "NA";
                    }
                }
                else
                {
                    this.lblValueUpdatedBy.Text = "NA";
                }
            }
            catch (Exception exc)
            {
                this.lblValueUpdatedBy.Text = "NA";
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            if (user.Id == Common.User.Id)
            {
                cmbBoxRole.Enabled = false;
                chkBoxMultiSession.Enabled = false;
                chkBoxActive.Enabled = false;
            }

        }


        private void cmbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(user != null)
                user.UserRoleId = cmbBoxRole.SelectedIndex;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var existingUser = data.Users.Single(u => u.Id == user.Id);

                if (existingUser != null)
                {
                    existingUser.Name = tBoxName.Text.Trim();
                    existingUser.Email = tBoxEmail.Text.Trim();
                    existingUser.Phone = tBoxPhone.Text.Trim();
                    existingUser.Address = tBoxAddress.Text.Trim();
                    existingUser.UserRoleId = cmbBoxRole.SelectedIndex;
                    existingUser.Active = chkBoxActive.Checked;
                    existingUser.MultiSession = chkBoxMultiSession.Checked;
                    existingUser.UpdatedAt = DateTime.Now;
                    existingUser.UpdatedBy = Common.User.Id;

                    data.SubmitChanges();
                    MessageBox.Show("Modified successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModifyUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (user != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to discard the changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the form closing event
                }
            }
        }

    }
}
