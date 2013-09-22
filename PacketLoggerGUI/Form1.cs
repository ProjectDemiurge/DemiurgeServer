using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacketLoggerGUI
{
    public partial class Form1 : Form
    {
        Proxy proxy;
        Thread client;
        Thread server;
        public List<byte[]> serverLog;
        public List<byte[]> clientLog;

        public Form1()
        {
            InitializeComponent();

            serverLog = new List<byte[]>();
            clientLog = new List<byte[]>();

            proxy = new Proxy(lstbx_Server, lstbx_Client, ref serverLog, ref clientLog);
            client = new Thread(proxy.ListenClient);
            server = new Thread(proxy.ListenServer);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            client.Start();
            server.Start();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            client.Abort();
            server.Abort();
        } 

        private void lstbx_Server_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstbx_Server.SelectedIndex;
            byte[] data = serverLog[index];

            lblServerPacket.Text = BitConverter.ToString(data);
            lblServerASCII.Text = Encoding.ASCII.GetString(data);
        }

        private void lstbx_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstbx_Client.SelectedIndex;
            byte[] data = clientLog[index];

            lblClientPacket.Text = BitConverter.ToString(data);
            lblClientASCII.Text = Encoding.ASCII.GetString(data);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string convert = txtConvert.Text;
            

            char[] split = new char[1];
            split[0] = '-';
            string[] temp = convert.Split(split);
            byte[] data = new byte[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                data[i] = Convert.ToByte(temp[i].Trim());
            }

            txtConvert.Text = Encoding.ASCII.GetString(data);

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<byte[]> clientfilteredlist = new List<byte[]>();
            List<byte[]> serverfilteredlist = new List<byte[]>();

            string convert = txtFilter0.Text;
            char[] split = new char[1];
            split[0] = '-';
            string[] temp = convert.Split(split);
            byte[] data = new byte[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                data[i] = Convert.ToByte(temp[i]);
            }

            bool match = false;
            foreach (byte[] b in clientLog)
            {
                match = false;
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == b[i])
                    {
                        match = true;
                    }
                    else
                    {
                        match = false;
                        break;
                    }
                }
                if (match == true)
                {
                    clientfilteredlist.Add(b);
                }
            }

            foreach (byte[] b in serverLog)
            {
                match = false;
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == b[i])
                    {
                        match = true;
                    }
                    else
                    {
                        match = false;
                        break;
                    }
                }
                if (match == true)
                {
                    serverfilteredlist.Add(b);
                }
            }

            lstbx_Server.Items.Clear();
            lstbx_Client.Items.Clear();

            foreach (byte[] b in serverfilteredlist)
            {
                lstbx_Server.Items.Add(BitConverter.ToString(b));
            }

            foreach (byte[] b in clientfilteredlist)
            {
                lstbx_Client.Items.Add(BitConverter.ToString(b));
            }
            clientLog = clientfilteredlist;
            serverLog = serverfilteredlist;
        }
    }
}
