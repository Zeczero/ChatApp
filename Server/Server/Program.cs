using Server.Messaging;
using WebSocketSharp.Server;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSocketServer server = new WebSocketServer("ws://127.0.0.1:5555");
            server.AddWebSocketService<MessageService>("/");

            server.Start();
            Console.ReadKey();
            server.Stop();
        }
    }
}
