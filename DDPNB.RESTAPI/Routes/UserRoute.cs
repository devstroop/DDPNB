using DDPNB.Data;
using Nancy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDPNB.ClientAPI.Routes
{
    public class UserRoute : NancyModule
    {
        DataClassesDataContext data = new DataClassesDataContext();
        public UserRoute() : base("/API/User")
        {
            Post("/Login", async args =>
            {
                try
                {
                    string Email = Request.Form["Email"];
                    string Password = Request.Form["Password"];
                    var users = data.Users.Where(elem => elem.Email.Trim() == Email).ToList();
                    if (users.Count() == 0)
                    {
                        return JsonConvert.SerializeObject(new Dictionary<string, dynamic>
                        {
                            {"Msg", "Invalid Credentials" }
                        });
                    }
                    if (users.First().Password.Trim() != Password.Trim())
                    {
                        return JsonConvert.SerializeObject(new Dictionary<string, dynamic>
                        {
                            {"Msg", "Invalid Credentials" }
                        });
                    }
                    User user = users.First();

                    if(!user.MultiSession)
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
                            ExpiresAt = DateTime.Now.AddMilliseconds(DDPNB.Common.Expiry), // set 6000 dynamically from configuration
                        });
                    data.SubmitChanges();
                    return JsonConvert.SerializeObject(new Dictionary<string, dynamic>
                    {
                        {"SessionId", SessionId }
                    });
                }
                catch (Exception exc)
                {
                    return JsonConvert.SerializeObject(new Dictionary<string, dynamic>
                    {
                        {"Error", exc.Message }
                    });
                }
            });
        }
    }
}
