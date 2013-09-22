using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacketSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var client = new UdpClient(5120);

            byte[] packet;
            
            // BNES
            packet = new byte[7];
            packet[0] = 66; // header
            packet[1] = 78; // header
            packet[2] = 69; // header
            packet[3] = 83; // header
            packet[4] = 255;  // usually 255, other value doesn't seem to matter?
            packet[5] = 19;  // usually 19, other value doesn't seem to matter?
            packet[6] = 0; // usually 0, other value repeated back

            // BNER follows from BNES structured as follows
            // 4 header bytes
            // 2 bytes unknown
            // 1 byte that is equal to packet[6]
            // 1 byte that represents the string length 1-255
            // X remaining bytes are server name


            client.Send(packet, packet.Length, "127.0.0.1", 5122);

            IPEndPoint src = new IPEndPoint(IPAddress.Any, 0);

            byte[] reply = client.Receive(ref src);

            string line = "";
            foreach (byte b in reply)
            {
                line = line + b + " ";
            }
            listBox1.Items.Add(line);
        }
    }
}
