using DDPNB.Data;
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
    public partial class FrmLogin : Form
    {

        string host;
        public User user { get; set; }
        public FrmLogin(string host)
        {
            this.host = host;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = this.tBoxEmail.Text;
            string password = this.tBoxPassword.Text;
            string host = this.host;

            // Dont use native calls, prefer api
            DataClassesDataContext data = new DataClassesDataContext();
            var users = data.Users.Where(elem => elem.Email.Trim() == email).ToList();
            if(users.Count() == 0)
            {
                MessageBox.Show("Invalida email.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(users.First().Password.Trim() != password.Trim())
            {
                MessageBox.Show("Invalida password.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.user = users.First();
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
