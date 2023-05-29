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
            user = data.Users.Single(elem => elem.Id == UserId);
        }

        public FrmModifyUser(int UserId)
        {
            InitializeComponent();
            user = data.Users.Single(elem => elem.Id == UserId);
        }

        private void FrmModifyUser_Load(object sender, EventArgs e)
        {
            this.userRoles = data.UserRoles.ToList();
            this.cmbBoxRole.DataSource = this.userRoles.Select(elem => elem.Name.Trim()).ToList();

            if (user != null)
            {
                this.tBoxName.Text = user.Name.Trim();
                this.tBoxEmail.Text = user.Email.Trim();
                this.tBoxPhone.Text = user.Phone.Trim();
                this.tBoxAddress.Text = user.Address.Trim();
                try
                {
                    Console.WriteLine(user.UserRoleId);
                    foreach(var role in userRoles)
                    {
                        if(role != null && role.Id == user.UserRoleId)
                        {
                            this.cmbBoxRole.SelectedIndex = userRoles.IndexOf(role);
                        }
                    }
                }
                catch (Exception exc)
                {
                    this.lblValueCreatedBy.Text = string.Empty;
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.chkBoxMultiSession.Checked = user.MultiSession;
                this.chkBoxActive.Checked = user.Active;

                this.lblValueCreatedAt.Text = user.CreatedAt != null ? user.CreatedAt.ToString() : "NA";
                try
                {
                    if(user.CreatedBy != null)
                    {
                        this.lblValueCreatedBy.Text = $"{data.Users.Single(elem => elem.Id == user.CreatedBy).Name.Trim()} ({user.CreatedBy})";
                    }
                    else
                    {
                        this.lblValueCreatedBy.Text = "NA";
                    }
                }
                catch(Exception exc)
                {
                    this.lblValueCreatedBy.Text = String.Empty;
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                this.lblValueUpdatedAt.Text = user.UpdatedAt != null ? user.UpdatedAt.ToString() : "NA";
                try
                {
                    if (user.UpdatedBy != null)
                    {
                        this.lblValueUpdatedBy.Text = $"{data.Users.Single(elem => elem.Id == user.UpdatedBy).Name.Trim()} ({user.UpdatedBy})";
                    }
                    else
                    {
                        this.lblValueUpdatedBy.Text = "NA";
                    }
                        
                }
                catch (Exception exc)
                {
                    this.lblValueUpdatedBy.Text = String.Empty;
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.UserRoleId = cmbBoxRole.SelectedIndex;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            data.SubmitChanges();
        }
    }
}
