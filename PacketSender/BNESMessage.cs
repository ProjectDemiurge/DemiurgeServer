using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketSender
{
    class BNESMessage : Message
    {
        private byte _unknown1; //appears to be ? in query msg's
        private byte _unknown2;
        private byte _unknown3;

        public BNESMessage(byte[] inBytes)
        {
            base.header[0] = (byte)'B';
            base.header[1] = (byte)'N';
            base.header[2] = (byte)'E';
            base.header[3] = (byte)'S';  //?!!:)


            _unknown1 = inBytes[4];
            _unknown2 = inBytes[5];
            _unknown3 = inBytes[6];
        }

        public byte Unknown1
        {
            get { return _unknown1; }
        }

        public byte Unknown2
        {
            get { return _unknown2; }
        }

        public byte Unknown3
        {
            get { return _unknown3; }
        }   

    }
}
