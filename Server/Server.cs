using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace Server
{
    class Server
    {
        public static UdpClient Client;
        public static MessageHandler MessageHandler;

        public const string ServerName = "Test Server";
        public const string ModuleName = "Chapter1";
        public const string ServerDescription = "Download Project Demiurge at http://github.com/ProjectDemiurge";
        public const string ModuleDescription = "Test Module Description";
        public const string Version = "8109";

        public static List<Connection> Connections; 

        public Server()
        {
            // Client to proxy
            Client = new UdpClient(5121);
            MessageHandler = new MessageHandler();
            Connections = new List<Connection>();
        }

        public void Listen()
        {
            while (true)
            {
                var srcAdd = new IPEndPoint(IPAddress.Any, 0);
                var data = Client.Receive(ref srcAdd);
                var reply = MessageHandler.Handle(data, this);

                Client.Send(reply, reply.Length, "127.0.0.1", 5132);
            }
        }

        public void Close()
        {
            Client.Close();
        }
    }

}
