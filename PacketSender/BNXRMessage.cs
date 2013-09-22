using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketSender
{
    /// <summary>
    /// Server Info message.
    /// Where is Difficulty, AutoSave Interval (minutes), Game Type, PvP Setting, Password required?
    /// </summary>
    class BNXRMessage : Message
    {
        private byte[] _unknown1;  //Length: 2  See BNER. Curiously, no preceding 85
        private byte[] _unknown2;  //Length: 2
        private byte[] _unknown3;  //Length: 2
        private byte _minLevel;
        private byte _maxLevel;
        private byte _currPlayers;
        private byte _maxPlayers;
        private bool _localAllowed;
        private bool _enforceLegal;
        private bool _itemLevelRestrict;
        private bool _onlyOneParty;
        private bool _playerPauseEnabled;
        private bool _reloadWhenEmpty;
        private bool _postToInternet;
        private byte _stringLength;
        String _moduleName;

        public BNXRMessage(byte[] inBytes)
        {
            base.header[0] = (byte)'B';
            base.header[1] = (byte)'N';
            base.header[2] = (byte)'X';
            base.header[3] = (byte)'R';  //?!!:)

            _unknown1[0] = inBytes[4];
            _unknown1[1] = inBytes[5];
            _unknown2[0] = inBytes[6];
            _unknown2[1] = inBytes[7];
            _unknown3[0] = inBytes[8];
            _unknown3[1] = inBytes[9];
            _minLevel = inBytes[10];
            _maxLevel = inBytes[11];
            _currPlayers = inBytes[12];
            _maxPlayers = inBytes[13];
            _localAllowed = Convert.ToBoolean(inBytes[14]);
            _enforceLegal = Convert.ToBoolean(inBytes[15]);
            _itemLevelRestrict = Convert.ToBoolean(inBytes[16]);
            _onlyOneParty = Convert.ToBoolean(inBytes[17]);
            _playerPauseEnabled = Convert.ToBoolean(inBytes[18]);
            _reloadWhenEmpty = Convert.ToBoolean(inBytes[19]);
            _postToInternet = Convert.ToBoolean(inBytes[20]);
            _stringLength = inBytes[21];

            _moduleName = Encoding.ASCII.GetString(inBytes, 22, _stringLength);
        }

        public byte[] Unknown1
        {
            get { return _unknown1; }
        }

        public byte[] Unknown2
        {
            get { return _unknown2; }
        }

        public byte[] Unknown3
        {
            get { return _unknown3; }
        }

        public byte MinLevel
        {
            get { return _minLevel; }
        }

        public byte MaxLevel
        {
            get { return _maxLevel; }
        }

        public byte CurrPlayers
        {
            get { return _currPlayers; }
        }

        public byte MaxPlayers
        {
            get { return _maxPlayers; }
        }

        public bool LocalAllowed
        {
            get { return _localAllowed; }
        }

        public bool EnforceLegal
        {
            get { return _enforceLegal; }
        }

        public bool ItemLevelRestrict
        {
            get { return _itemLevelRestrict; }
        }

        public bool OnlyOneParty
        {
            get { return _onlyOneParty; }
        }

        public bool PlayerPauseEnabled
        {
            get { return _playerPauseEnabled; }
        }

        public bool ReloadWhenEmpty
        {
            get { return _reloadWhenEmpty; }
        }

        public bool PostToInternet
        {
            get { return _postToInternet; }
        }

        public byte ServerLength
        {
            get { return _stringLength; }
        }

        public String ModuleName
        {
            get { return _moduleName; }
        }
    }
}
