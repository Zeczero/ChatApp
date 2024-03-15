using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using WebSocketSharp;
using Newtonsoft.Json;
using Data;
using Server.Data.UserModel;
using Server.UserManager;
using System.Reflection.Metadata;
using Server.Model;
using Server.UserManager;

namespace Server.Messaging
{
    public class MessageService : WebSocketBehavior
    {
        private static Dictionary<string, string> _userToId = new Dictionary<string, string>();
        protected override void OnMessage(MessageEventArgs e)
        {
            var user = JsonConvert.DeserializeObject<Login>(e.Data);
            if (e.Data.Contains("login"))
            {
                string[] result = UserManager.UserManager.HandleUsers(user);
                AddUser(result[1], ID);
                Send(result[0]);
            }
            else
            {
                var message  = JsonConvert.DeserializeObject<Message>(e.Data);
                // add mapping to no-token object
                if (new TokenHandler().ValidateToken(message.Token))
                {
                    if (String.IsNullOrEmpty(message.Recipient))
                    {
                        var publicMessageDTO = new MessageDTO
                        {
                            Type = message.Type,
                            Content = message.Content,
                            Sender = message.Sender
                        };
                        var publicMessageDTOToJson = JsonConvert.SerializeObject(publicMessageDTO);
                        Sessions.Broadcast(publicMessageDTOToJson);
                    }
                    else
                    {
                        var privateMessageDTO = new MessageDTO
                        {
                            Type = message.Type,
                            Content = message.Content,
                            Recipient = message.Recipient,
                            Sender = message.Sender,
                        };
                        var userId = _userToId[privateMessageDTO.Recipient];
                        var privateMessageDTOToJson = JsonConvert.SerializeObject(privateMessageDTO);
                        Sessions.SendTo(privateMessageDTOToJson, userId);
                        Send(privateMessageDTOToJson);
                    }
                }
                else
                {
                    Send("0");
                }
            }
        }
        private void AddUser(string username, string id)
        {
            _userToId[username] = id;
        }
    }
}
