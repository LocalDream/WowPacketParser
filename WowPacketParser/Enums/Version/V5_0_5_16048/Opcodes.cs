using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_0_5_16048
{
    public static class Opcodes_5_0_5
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {   
            {Opcode.CMSG_GUILD_DISBAND, 0x0062},
            {Opcode.CMSG_AUTH_SESSION, 0x008A},
            {Opcode.CMSG_GROUP_RAID_CONVERT, 0x034F},
            {Opcode.CMSG_COMMENTATOR_START_WARGAME, 0x0361},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x0523},
            {Opcode.CMSG_CHANNEL_MODERATOR, 0x0581},
            {Opcode.CMSG_GUILD_EVENT_LOG_QUERY, 0x06C3},
            {Opcode.CMSG_REALM_SPLIT, 0x0820},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x08AE},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x0956},
            {Opcode.SMSG_ADDON_INFO, 0x09C6},
            {Opcode.SMSG_AUTH_RESPONSE, 0x0E20},
            {Opcode.SMSG_CHAR_ENUM, 0x0E28},
            {Opcode.SMSG_MOTD, 0x0952},
            {Opcode.SMSG_UPDATE_OBJECT, 0x08F7},
        };
    }
}