using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketSender
{
    class BNLRMessage : Message
    {
        private byte _unknown1; //Ascii ?, messages seem to be query
        private byte _unknown2; //Starts at 3 and packets keep sending until it == 1
        private byte[] _unknown3; //0 0 0


        public BNLRMessage(byte[] inBytes)
        {
            base.header[0] = (byte)'B';
            base.header[1] = (byte)'N';
            base.header[2] = (byte)'L';
            base.header[3] = (byte)'R';  //?!!:)

            _unknown1 = inBytes[4];
            _unknown2 = inBytes[5];
            _unknown3[0] = inBytes[6];
            _unknown3[1] = inBytes[7];
            _unknown3[2] = inBytes[8];
        }

        public byte Unknown1
        {
            get { return _unknown1; }
        }

        public byte Unknown2
        {
            get { return _unknown2; }
        }


        public byte[] Unknown3
        {
            get { return _unknown3; }
        }


    }
}
