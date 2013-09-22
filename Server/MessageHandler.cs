using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class MessageHandler
    {
        public byte[] Handle(byte[] data, Server server)
        {
            if (data[0] == 66 && data[1] == 78)
            {
                Console.WriteLine("Found BN packet)");
                return BnProtocol(data);
            }
            else if (data[0] == 999)
            {
                return MProtocol(data, server);
            }
            else
            {
                Console.WriteLine("Unknown Packet");
                throw new NotImplementedException();
            }
        }

        private byte[] BnProtocol(byte[] data)
        {
            if (data[2] == 69 && data[3] == 83)
            {
                Console.WriteLine("BNER Packet Received");
                return Bn.ER(data);
            }
            if (data[2] == 88 && data[3] == 73)
            {
                Console.WriteLine("BNXI Packet Received");
                return Bn.XR(data);
            }
            if (data[2] == 76 && data[3] == 77)
            {
                Console.WriteLine("BNLM Packet Received");
                return Bn.LR(data);
            }
            if (data[2] == 68 && data[3] == 83)
            {
                Console.WriteLine("BNDS Packet Received");
                return Bn.DR(data);
            }
            if (data[2] == 67 && data[3] == 83)
            {
                Console.WriteLine("BNCS Packet Received");
                return Bn.CR(data);
            }
            if (data[2] == 86 && data[3] == 83)
            {
                Console.WriteLine("BNCS Packet Received");
                return Bn.VR(data);
            }
            throw new NotImplementedException();
        }

        private byte[] MProtocol(byte[] data, Server server)
        {
            throw new NotImplementedException();
        }
    }
}
