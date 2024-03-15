using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.LoginModel
{
    public class Login
    {
        public string Type { get; set; } = "login";
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
