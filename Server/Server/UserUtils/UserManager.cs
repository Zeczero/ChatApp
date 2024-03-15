using Data;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Data.UserModel;
using Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.UserManager
{
    public static class UserManager
    {
        public static List<string> Tokens = new List<string>();  
        public static string[] HandleUsers(Login user)
        {
            using (var db = new AppDbContext())
            {
                var us = db.Users.FirstOrDefault(x => x.Name == user.Username);
                if (us == null)
                {
                    var usr = new User
                    {
                        Name = user.Username, 
                        PasswordHash = user.Password
                    };
                    db.Users.Add(usr);
                    db.SaveChanges();  
                    return new [] { "Success", usr.Name };
                }
                else
                {
                    if (user.Password == us.PasswordHash)
                    {
                        string token = new TokenHandler().GetToken();
                        Tokens.Add(token);
                        return new [] { token, user.Username};
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
