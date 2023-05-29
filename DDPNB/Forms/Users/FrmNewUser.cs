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
        public FrmNewUser()
        {
            InitializeComponent();
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
                user.UserRoleId = 1; // Take dynamic value
                user.MultiSession = this.chkBoxMultiSession.Checked;
                user.Active = this.chkBoxActive.Checked;

                user.CreatedAt = DateTime.Now;
                user.CreatedBy = Common.User.Id;



                data.Users.InsertOnSubmit(user);
                data.SubmitChanges();
                MessageBox.Show("User successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmNewUser_Load(object sender, EventArgs e)
        {
            this.userRoles = data.UserRoles.ToList();
            this.cmbBoxRole.DataSource = this.userRoles.Select(elem => elem.Name).ToList();
        }
    }
}
