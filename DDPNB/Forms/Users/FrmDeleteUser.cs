using System;
using System.Linq;
using System.Windows.Forms;

namespace DDPNB.Forms.Users
{
    public partial class FrmDeleteUser : Form
    {
        Data.DataClassesDataContext data = new Data.DataClassesDataContext();
        Data.User user;
        public FrmDeleteUser()
        {
            InitializeComponent();
            int? UserId = FrmPickUser.Pick();
            if (UserId != null) user = data.Users.Single(elem => elem.Id == UserId);
        }
        public FrmDeleteUser(int? UserId)
        {
            InitializeComponent();
            if (UserId != null) user = data.Users.Single(elem => elem.Id == UserId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkBoxConfirm.Checked)
                {
                    if(user != null && user.Id == Common.User.Id)
                    {
                        MessageBox.Show("Cannot delete yourself.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    data.Users.DeleteOnSubmit(data.Users.Single(elem => elem.Id == user.Id));
                    data.SubmitChanges();
                    MessageBox.Show("Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please confirm to proceed.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDeleteUser_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                this.BeginInvoke(new Action(() => {
                    this.Close();
                }));
                return;
            }
            this.lblValueId.Text = user.Id.ToString();
            this.lblValueName.Text = user.Name.Trim();
            this.lblValueEmail.Text = user.Email.Trim();
            this.lblValuePhone.Text = user.Phone.Trim();
            this.lblValueAddress.Text = user.Address.Trim();
            try
            {
                this.lblValueRole.Text = data.UserRoles.Single(elem => elem.Id == user.UserRoleId).Name;
            }
            catch
            {
                this.lblValueRole.Text = "NA";
            }

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
        }
    }
}
