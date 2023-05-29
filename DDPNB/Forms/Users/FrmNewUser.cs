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
    public partial class FrmNewUser : Form
    {
        Data.DataClassesDataContext data = new Data.DataClassesDataContext();
        List<Data.UserRole> userRoles = new List<Data.UserRole>();
        Data.UserRole Role { get; set; }

        public FrmNewUser()
        {
            InitializeComponent();
        }
        public FrmNewUser(Data.UserRole Role)
        {
            InitializeComponent();
            this.Role = Role;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Data.User user = new Data.User();
                user.Name = this.tBoxName.Text;
                user.Email = this.tBoxEmail.Text;
                user.Phone = this.tBoxPhone.Text;
                user.Address = this.tBoxAddress.Text;
                user.Password = this.tBoxPassword.Text;
                user.UserRoleId = this.Role != null ? Role.Id : 0; // Take dynamic value
                user.MultiSession = this.chkBoxMultiSession.Checked;
                user.Active = this.chkBoxActive.Checked;

                user.CreatedAt = DateTime.Now;
                user.CreatedBy = Common.User != null ? (int?)Common.User.Id : null;

                data.Users.InsertOnSubmit(user);
                data.SubmitChanges();
                MessageBox.Show("User successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmNewUser_Load(object sender, EventArgs e)
        {
            this.userRoles = data.UserRoles.ToList();
            this.cmbBoxRole.DataSource = this.userRoles.Select(elem => elem.Name.Trim()).ToList();
        }

        private void cmbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Role = data.UserRoles.Single(elem => elem.Name.Trim() == this.cmbBoxRole.Text.Trim());
        }
    }
}
