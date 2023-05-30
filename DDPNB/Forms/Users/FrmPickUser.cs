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
    public partial class FrmPickUser : Form
    {
        Data.DataClassesDataContext data = new Data.DataClassesDataContext();
        List<Data.User> Users = new List<Data.User>();
        public static int? Pick()
        {
            FrmPickUser frmPickUser = new FrmPickUser();
            frmPickUser.ShowDialog();
            return frmPickUser.UserId;
        }

        public int? UserId { get; set; }
        public FrmPickUser()
        {
            InitializeComponent();
        }

        private void FrmPickUser_Load(object sender, EventArgs e)
        {
            Users = data.Users.ToList();
            this.dgvUsers.DataSource = Users;
        }

        private void tBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tBoxSearch.Text))
            {
                this.dgvUsers.DataSource = Users;
            }
            else
            {
                this.dgvUsers.DataSource = Users.Where(elem => elem.Name.ToLower().Trim().Contains(this.tBoxSearch.Text.ToLower().Trim()));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tBoxSearch.Text))
            {
                this.dgvUsers.DataSource = Users;
            }
            else
            {
                this.dgvUsers.DataSource = Users.Where(elem => elem.Name.ToLower().Trim().Contains(this.tBoxSearch.Text.ToLower().Trim()));
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                UserId = int.Parse(dgvUsers.SelectedRows[0].Cells["Id"].Value.ToString());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
