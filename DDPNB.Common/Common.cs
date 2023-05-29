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
        public static int Expiry = 6000; // In Milliseconds
        public static User LoggedInUser { get; set; }
    }
}
