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
        private static Data.DataClassesDataContext data = new DataClassesDataContext();
        public static int Expiry = 6000; // In Milliseconds
        public static User User 
        { 
            get 
            { 
                if(Session == null)
                {
                    return null;
                }
                return data.Users.Single(x => x.Id == Session.UserId);

            } 
        }
        private static Session _Session;
        public static Session Session 
        {
            get 
            { 
                return _Session;
            } 
            set
            {
                _Session = value;
                if (!User.MultiSession)
                {
                    foreach (Data.Session existingSession in data.Sessions.Where(elem => elem.UserId == User.Id))
                    {
                        data.Sessions.DeleteOnSubmit(existingSession);
                    }
                }
                data.Sessions.InsertOnSubmit(value);
                data.SubmitChanges();

            }
        }
    }
}
