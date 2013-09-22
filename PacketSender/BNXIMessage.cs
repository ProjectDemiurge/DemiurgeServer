using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketSender
{
    class BNXIMessage : Message
    {
        private byte _unknown1; //Ascii ?, messages seem to be query
        private byte _unknown2;  


        public BNXIMessage(byte[] inBytes)
        {
            base.header[0] = (byte)'B';
            base.header[1] = (byte)'N';
            base.header[2] = (byte)'X';
            base.header[3] = (byte)'I';  //?!!:)

            _unknown1 = inBytes[4];
            _unknown2 = inBytes[5];
        }

        public byte Unknown1
        {
            get { return _unknown1; }
        }

        public byte Unknown2
        {
            get { return _unknown2; }
        }
    }
}
