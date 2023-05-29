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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(Common.Session != null)
                {
                    MessageBox.Show("Already logged in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string email = this.tBoxEmail.Text;
                string password = this.tBoxPassword.Text;

                DataClassesDataContext data = new DataClassesDataContext();
                var users = data.Users.Where(elem => elem.Email.Trim() == email).ToList();
                if (users.Count() == 0)
                {
                    MessageBox.Show("Invalid email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (users.First().Password.Trim() != password.Trim())
                {
                    MessageBox.Show("Invalid password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = users.First();

                

                var SessionId = Guid.NewGuid().ToString();
                var session = new Session()
                {
                    SessionId = SessionId,
                    UserId = user.Id,
                    CreatedAt = DateTime.Now,
                    ExpiresAt = DateTime.Now.AddMilliseconds(DDPNB.Common.Expiry),
                };

                Common.Session = session;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
