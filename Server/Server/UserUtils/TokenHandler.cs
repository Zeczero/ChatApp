using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.UserManager
{
    public class TokenHandler
    {
        Random Random = new Random();
        public string GetToken()
        {
            string token = "";
            for (int i = 0; i < 10; i++)
            {
                token += (char) Random.Next(97, 122);
            }
            return token;
        }
        public bool ValidateToken(string token)
        {
            return UserManager.Tokens.Contains(token); 
        }
    }
}
