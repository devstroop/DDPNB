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
        int expiry;
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

            var user = users.First();

            if (!user.MultiSession)
            {
                foreach (Data.Session existingSession in data.Sessions.Where(elem => elem.UserId == user.Id))
                {
                    data.Sessions.DeleteOnSubmit(existingSession);
                }
            }

            var SessionId = Guid.NewGuid().ToString();
            data.Sessions.InsertOnSubmit(
                new Data.Session()
                {
                    SessionId = SessionId,
                    UserId = user.Id,
                    CreatedAt = DateTime.Now,
                    ExpiresAt = DateTime.Now.AddMilliseconds(DDPNB.Common.Expiry),
                });
            data.SubmitChanges();
            this.user = user;
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
