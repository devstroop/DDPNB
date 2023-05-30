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
    public partial class FrmUserRoles : Form
    {
        Data.DataClassesDataContext data = new Data.DataClassesDataContext();
        List<Data.UserRole> Roles = new List<Data.UserRole>();
        public FrmUserRoles()
        {
            InitializeComponent();
        }

        private void FrmUserRoles_Load(object sender, EventArgs e)
        {
            Roles = data.UserRoles.ToList();
            dgvRoles.DataSource = Roles;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
