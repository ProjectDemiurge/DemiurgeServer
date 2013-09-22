using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacketLoggerGUI
{
    class Proxy
    {
        public static UdpClient client;
        public static UdpClient server;
        public ListBox serverDisplay;
        public ListBox clientDisplay;
        public List<byte[]> serverLog;
        public List<byte[]> clientLog;

        public Proxy(ListBox ServerDisplay, ListBox ClientDisplay, ref List<byte[]> ServerLog, ref List<byte[]> ClientLog)
        {

            this.serverLog = ServerLog;
            this.clientLog = ClientLog;

            this.serverDisplay = ServerDisplay;
            this.clientDisplay = ClientDisplay;

            // Client to proxy
            client = new UdpClient(5124);

            // server to proxy
            server = new UdpClient(5120);
        }

        public void ListenClient()
        {
            while (true)
            {
                byte[] data;
                var srcAdd = new IPEndPoint(IPAddress.Any, 0);
                data = client.Receive(ref srcAdd);

                    clientDisplay.Invoke((MethodInvoker)delegate
                    {
                        clientDisplay.Items.Add(BitConverter.ToString(data));
                    });
                    clientLog.Add(data);

                server.Send(data, data.Length, "72.55.191.9", 5121);
            }
        }

        public void ListenServer()
        {
            while (true)
            {
                byte[] data;
                var srcAdd = new IPEndPoint(IPAddress.Any, 0);
                data = server.Receive(ref srcAdd);

                    serverDisplay.Invoke((MethodInvoker)delegate
                    {
                        serverDisplay.Items.Add(BitConverter.ToString(data));
                    });
                    serverLog.Add(data);

                client.Send(data, data.Length, "127.0.0.1", 5132);
            }
        }
    }
}
