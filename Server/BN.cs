using System;
using System.Text;
using System.IO;
using System.Net;

namespace Server
{
    class Bn
    {
        public static byte[] ER(byte[] data)
        {
            var header = new byte[9];

            header[0] = 66;
            header[1] = 78;
            header[2] = 69;
            header[3] = 82;
            header[4] = 85;
            header[5] = 2;
            header[6] = 20;
            header[7] = 0;
            header[8] = Convert.ToByte(Server.ServerName.Length);

            var serverName = Encoding.ASCII.GetBytes(Server.ServerName);

            var stream = new MemoryStream();
            
            stream.Write(header, 0, header.Length);
            stream.Write(serverName, 0, serverName.Length);

            Console.WriteLine("Replied to BNER");
            return stream.ToArray();
        }

        public static byte[] XR(byte[] data)
        {
            var header = new byte[20];

            header[0] = 66;
            header[1] = 78;
            header[2] = 88;
            header[3] = 82;
            header[4] = 2;
            header[5] = 20;
            header[6] = 253; // unknown
            header[7] = 0;  // unknown
            header[8] = 1;  // minimum level
            header[9] = 40; // max level
            header[10] = 0; // current player count
            header[11] = 6; // max players
            header[12] = 1; // allow local characters
            header[13] = 0; // pvp mode
            header[14] = 1; // player pause enabled
            header[15] = 1; // only one party
            header[16] = 1; // enforce legal characters
            header[17] = 1; // item level restrictions
            header[18] = 3; //server version
            header[19] = Convert.ToByte(Server.ModuleName.Length);

            var moduleName = Encoding.ASCII.GetBytes(Server.ModuleName);

            var stream = new MemoryStream();

            stream.Write(header, 0, header.Length);
            stream.Write(moduleName, 0, moduleName.Length);

            Console.WriteLine("Replied to BNXI");
            return stream.ToArray();
        }

        public static byte[] LR(byte[] data)
        {
            var header = new byte[11];

            header[0] = 66;
            header[1] = 78;
            header[2] = 76;
            header[3] = 82;
            header[4] = 2;
            header[5] = 20;
            header[6] = data[6];
            header[7] = data[7];
            header[8] = data[8];
            header[9] = data[9];
            header[10] = data[10];

            var stream = new MemoryStream();
            stream.Write(header, 0, header.Length);

            Console.WriteLine("Replied to BNLM");
            return stream.ToArray();
        }

        public static byte[] DR(byte[] data)
        {
            var header = new byte[6];

            header[0] = 66;
            header[1] = 78;
            header[2] = 68;
            header[3] = 82;
            header[4] = 2;
            header[5] = 20;

            var serverDesc = Encoding.ASCII.GetBytes(Server.ServerDescription);
            var moduleDesc = Encoding.ASCII.GetBytes(Server.ModuleDescription);
            var serverVersion = Encoding.ASCII.GetBytes(Server.Version);

            var serverDescLength = BitConverter.GetBytes(serverDesc.Length);
            var moduleDescLength = BitConverter.GetBytes(moduleDesc.Length);
            var serverVersionLength = BitConverter.GetBytes(serverVersion.Length);

            var gameType = new byte[2] {0, 0};

            var stream = new MemoryStream();

            stream.Write(header, 0, header.Length);
            stream.Write(serverDescLength, 0, serverDescLength.Length);
            stream.Write(serverDesc, 0, serverDesc.Length);

            stream.Write(moduleDescLength, 0, moduleDescLength.Length);
            stream.Write(moduleDesc, 0, moduleDesc.Length);

            stream.Write(serverVersionLength, 0, serverVersionLength.Length);
            stream.Write(serverVersion, 0, serverVersion.Length);

            stream.Write(gameType, 0, gameType.Length);

            Console.WriteLine("Replied to BNDS");
            return stream.ToArray();
        }
    
        public static byte[] CR(byte[] data)
        {
            
            
            string hash1;
            int port;
            string ip;

            var stream = new MemoryStream(data);
            var playernamelength = new byte[1];

            // Read playername
            stream.Seek(18, SeekOrigin.Begin);
            stream.Read(playernamelength, 0, 1);
            var playernamearray = new byte[Convert.ToInt32(playernamelength[0])];
            stream.Read(playernamearray, 0, Convert.ToInt32(playernamelength[0]));
            string playername = System.Text.Encoding.ASCII.GetString(playernamearray);

            // Read hash
            var hasharray = new byte[8];
            stream.Seek(1, SeekOrigin.Current);
            stream.Read(hasharray, 0, 8);
            hash1 = System.Text.Encoding.ASCII.GetString(hasharray);

            var connection = new Connection();
            connection.PlayerName = playername;
            connection.Hash1 = hash1;

            Server.Connections.Add(connection);

            byte[] reply = new byte[73] {0x42, 0x4E, 0x43, 0x52, 0x01, 0x14, 0x56, 0x20, 0xFB, 0xB4, 0xC7, 0xBF, 0xF0, 0x36, 0x15, 0x8E, 0xAA, 0x11, 0x4D, 0x52, 0xCD, 0x0A, 0x75, 0xA3, 0xAB, 0xBF, 0x94, 0x2C, 0xE9, 0x2D, 0x28, 0x68, 0xB3, 0x75, 0xCD, 0xA1, 0x45, 0xD1, 0x4E, 0x25, 0x20, 0xBD, 0xA4, 0x9A, 0xEB, 0x76, 0xBD, 0x09, 0x9B, 0xBB, 0xBE, 0xA4, 0x1E, 0x2F, 0xDF, 0xAD, 0x16, 0xE4, 0xF3, 0x4D, 0x90, 0xB6, 0x8B, 0x41, 0xCC, 0xC1, 0xC7, 0xC3, 0x67, 0x88, 0xB3, 0xFF, 0x14};

            return reply;
        }

        public static byte[] VR(byte[] data)
        {
            return new byte[9] { 0x42, 0x4e, 0x56, 0x52, 0x41, 0x57, 0x1b, 0x5c, 0x0b };
        }
    }
}
