using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDPNB_CLIENT.Forms
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private async void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = await DDPNB.Forms.FrmLogin.Login(host: "http://localhost:5001");
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
