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
    public partial class FrmSuspentActivateUser : Form
    {
        Data.DataClassesDataContext data = new Data.DataClassesDataContext();
        Data.User user;
        public FrmSuspentActivateUser()
        {
            InitializeComponent();
            int? UserId = FrmPickUser.Pick();
            if (UserId != null) user = data.Users.Single(elem => elem.Id == UserId);
        }

        public FrmSuspentActivateUser(int? UserId)
        {
            InitializeComponent();
            if (UserId != null) user = data.Users.Single(elem => elem.Id == UserId);
        }
        private void FrmSuspentActivateUser_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                this.BeginInvoke(new Action(() => {
                    this.Close();
                }));
                return;
            }

            this.lblValueId.Text = $"{user.Id}";
            this.lblValueName.Text = user.Name?.Trim();
            this.lblValueEmail.Text = user.Email?.Trim();
            this.lblValuePhone.Text = user.Phone?.Trim();
            try
            {
                this.lblValueRole.Text = data.UserRoles.Single(elem => elem.Id == user.UserRoleId).Name;
            }
            catch
            {
                this.lblValueRole.Text = "NA";
            }
            if (user.Active)
            {
                rBtnActive.Checked = true;
            }
            else
            {
                rBtnSuspended.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (user != null && user.Id == Common.User.Id)
            {
                MessageBox.Show("Cannot suspend or activate yourself.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var existingUser = data.Users.Single(u => u.Id == user.Id);
            existingUser.Active = rBtnActive.Checked;

            data.SubmitChanges();
            MessageBox.Show("Applied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
