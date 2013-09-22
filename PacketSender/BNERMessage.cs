using System;
using System.Text;

namespace PacketSender
{
    class BNERMessage : Message
    {
        private byte _unknown1; 
        private byte[] _unknown2;  //Length: 2
        private byte _unknown3;  //Last byte of BNER
        private byte _stringLength;
        private String _serverName; //String.sizeof = stringLength

        public BNERMessage(byte[] inBytes)
        {
            base.header[0] = (byte)'B';
            base.header[1] = (byte)'N';
            base.header[2] = (byte)'E';
            base.header[3] = (byte)'R';  //?!!:)


            _unknown1 = inBytes[4];
            _unknown2[0] = inBytes[5];
            _unknown2[1] = inBytes[6];
            _unknown3 = inBytes[7];
            _stringLength = inBytes[8];

            _serverName = Encoding.ASCII.GetString(inBytes, 9, _stringLength);
        }

        public byte Unknown1
        {
            get { return _unknown1; }
        }

        public byte[] Unknown2
        {
            get { return _unknown2; }
        }

        public byte Unknown3
        {
            get { return _unknown3; }
        }

        public byte ServerLength
        {
            get { return _stringLength; }
        }

        public String ServerName
        {
            get { return _serverName; }
        }
    }
}
