using System.ComponentModel;
using Newtonsoft.Json;
using Client.LoginModel;
using WebSocketSharp;
using System.Security.Cryptography;
using System.Text;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace Client
{
    public partial class Form1 : Form
    {
        private WebSocket webSocket;
        public string Token { get; set; }
        public Form1()
        {
            InitializeComponent();
            RunWebSocket();
        }
        void RunWebSocket()
        {
            webSocket = new WebSocket("ws://127.0.0.1:5555/");
            webSocket.OnMessage += Web_OnMessage;
            webSocket.Connect();
        }

        private void AddItemToListBox(string itemText)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.BeginInvoke(new Action(() => AddItemToListBox(itemText)));
            }
            else
            {
                listBox1.Items.Add(itemText);

                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private void Web_OnMessage(object? sender, MessageEventArgs e)
        {

            if (e.Data is not null && !e.Data.Contains("Success") && !e.Data.Contains("Content") && !e.Data.Contains("Key") && !e.Data.Contains("Exchange"))
            {
                Token = e.Data;
            }
            if (e.Data.Contains("Content"))
            {
               
                var data = JsonConvert.DeserializeObject<LoginModel.Message>(e.Data);

                if (data.Recipient == null)
                {
                    AddItemToListBox($"{data.Sender} : {data.Content}");
                }
                else
                {
                    AddMessageToPrivateListBox($"{data.Sender} : {data.Content}");
                }
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            webSocket.Close();
            base.OnClosing(e);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var login = new Login()
            {
                Type = "login",
                Username = textBox1.Text,
                Password = textBox2.Text,
            };
            var loginJson = JsonConvert.SerializeObject(login);
            webSocket.Connect();
            webSocket.Send(loginJson);
        }

        private void snd_Click(object sender, EventArgs e)
        {
            var publicMessage = new LoginModel.Message()
            {
                Type = "message",
                Sender = textBox1.Text,
                Content = msg.Text,
                Token = Token
            };
            var publicMessageJson = JsonConvert.SerializeObject(publicMessage);
            webSocket.Send(publicMessageJson);
            msg.Text = "";
        }

        private void PrivateMsgSend_Click(object sender, EventArgs e)
        {
   
            var privateMessage = new LoginModel.Message()
            {
                Type = "message",
                Sender = textBox1.Text,
                Recipient = UsernamePrivate.Text,
                Content = PrivateMessage.Text,
                Token = Token,
            };
            var privateMessageJson = JsonConvert.SerializeObject(privateMessage);
            webSocket.Send(privateMessageJson);
            PrivateMessage.Text = "";
        }

        private void AddMessageToPrivateListBox(string itemText)
        {
            if (listBox1.InvokeRequired)
            {
                ChatBoxPrivate.BeginInvoke(new Action(() => AddMessageToPrivateListBox(itemText)));
            }
            else
            {
                ChatBoxPrivate.Items.Add(itemText);

                ChatBoxPrivate.SelectedIndex = ChatBoxPrivate.Items.Count - 1;
            }
        }

    }
}
