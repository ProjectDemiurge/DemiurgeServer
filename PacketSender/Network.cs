using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace PacketSender
{
    class Network
    {
        public static UdpClient client;

        public Network()
        {
            client = new UdpClient(5120);

            byte[] packet = new byte[7];
            packet[0] = 66;
            packet[1] = 78;
            packet[2] = 69;
            packet[3] = 83;
            packet[4] = 255;
            packet[5] = 19;
            packet[6] = 0;

            client.Send(packet, packet.Length, "127.0.0.1", 5122);

            IPEndPoint src = new IPEndPoint(IPAddress.Any, 0);
            
            byte[] reply = client.Receive(ref src);


        }
    }
}
