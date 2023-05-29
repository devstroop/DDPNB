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
    public partial class FrmAllUsers : Form
    {
        Data.DataClassesDataContext data = new Data.DataClassesDataContext();
        List<Data.User> users = new List<Data.User>();
        public FrmAllUsers()
        {
            InitializeComponent();
        }

        private void FrmAllUsers_Load(object sender, EventArgs e)
        {
            users = data.Users.ToList();
            this.dgvUsers.DataSource = users;
            this.cmbBoxSearchBy.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(this.cmbBoxSearchBy.SelectedIndex == 0)
                this.dgvUsers.DataSource = users.Where(elem => elem.Name.ToLower().Trim().Contains(this.tBoxSearch.Text.ToLower().Trim())).ToList();
            else if (this.cmbBoxSearchBy.SelectedIndex == 1)
                this.dgvUsers.DataSource = users.Where(elem => elem.Phone.ToLower().Trim().Contains(this.tBoxSearch.Text.ToLower().Trim())).ToList();
            else if (this.cmbBoxSearchBy.SelectedIndex == 2)
                this.dgvUsers.DataSource = users.Where(elem => elem.Email.ToLower().Trim().Contains(this.tBoxSearch.Text.ToLower().Trim())).ToList();
        }

        private void btnNew_Click(object sender, EventArgs e) => (new Users.FrmNewUser() { MdiParent = this.MdiParent }).Show();

        private void btnRefresh_Click(object sender, EventArgs e) => FrmAllUsers_Load(sender, e);
    }
}
