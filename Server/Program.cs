using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();
            Console.WriteLine("Starting server...");
            var serverListen = new Thread(server.Listen);
            serverListen.Start();
            Console.WriteLine("Server started");
            Console.ReadKey();
            server.Close();
            serverListen.Abort();
        }
    }
}
