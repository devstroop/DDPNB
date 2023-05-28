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
        public static User Login(string host)
        {
            var frmLogin = new FrmLogin(host: host);
            frmLogin.ShowDialog();
            return frmLogin.user;
        }
        public static void Logout(string userId)
        {

        }

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

            this.user = new User
            {
                Email = email,
            };
            this.Close();
        }
    }
}
