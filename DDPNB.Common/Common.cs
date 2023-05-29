using DDPNB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDPNB
{
    public class Common
    {
        public static User LoggedInUser { get; set; }
        public static User Login(string host)
        {
            var frmLogin = new Forms.FrmLogin(host: host);
            frmLogin.ShowDialog();
            return frmLogin.user;
        }
        public static void Logout()
        {
            if(LoggedInUser == null)
            {
                return;
            }
            // Pop from session or call api
        }
    }
}
