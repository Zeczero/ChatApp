using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.LoginModel
{
    public class KeyExchangeMessage
    {
        public string Type = "Exchange";
        public string Recipient { get; set; }

        public string Sender { get; set; }
        public string Token { get; set; }
        public string PublicKey { get; set; }   
    }
}
