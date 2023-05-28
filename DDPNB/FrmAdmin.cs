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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = DDPNB.Forms.FrmLogin.Login(host: "http://localhost:5001");
            if (user != null)
            {
                MessageBox.Show($"Success: {user.Email}");
            }
            else
            {
                MessageBox.Show($"Failed");
            }
        }
    }
}
