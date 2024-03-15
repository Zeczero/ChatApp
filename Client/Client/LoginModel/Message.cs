using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.LoginModel
{
    public class Message
    {
        public string Type { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; } = String.Empty;
        public string Content { get; set; }
        public string Token { get; set; }

    }
}
