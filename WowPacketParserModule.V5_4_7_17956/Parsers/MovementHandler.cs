﻿using System;
using WowPacketParser.Enums;
using WowPacketParser.Enums.Version;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using CoreParsers = WowPacketParser.Parsing.Parsers;
using Guid = WowPacketParser.Misc.Guid;

namespace WowPacketParserModule.V5_4_7_17956.Parsers
{
    public static class MovementHandler
    {
        [HasSniffData]
        [Parser(Opcode.SMSG_LOGIN_VERIFY_WORLD, ClientVersionBuild.V5_4_7_17898, ClientVersionBuild.V5_4_7_17956)]
        [Parser(Opcode.SMSG_LOGIN_VERIFY_WORLD, ClientVersionBuild.V5_4_7_17956)]
        public static void HandleLoginVerifyWorld(Packet packet)
        {
            packet.ReadSingle("Orientation");
            CoreParsers.MovementHandler.CurrentMapId = (uint)packet.ReadEntryWithName<Int32>(StoreNameType.Map, "Map");
            packet.ReadSingle("Z");
            packet.ReadSingle("X");
            packet.ReadSingle("Y");

            packet.AddSniffData(StoreNameType.Map, (int)CoreParsers.MovementHandler.CurrentMapId, "NEW_WORLD");
        }

        [HasSniffData]
        [Parser(Opcode.SMSG_NEW_WORLD, ClientVersionBuild.V5_4_7_17898, ClientVersionBuild.V5_4_7_17956)]
        [Parser(Opcode.SMSG_NEW_WORLD, ClientVersionBuild.V5_4_7_17956)]
        public static void HandleNewWorld(Packet packet)
        {
            CoreParsers.MovementHandler.CurrentMapId = (uint)packet.ReadEntryWithName<Int32>(StoreNameType.Map, "Map");
            packet.ReadSingle("Y");
            packet.ReadSingle("Z");
            packet.ReadSingle("Orientation");
            packet.ReadSingle("X");

            packet.AddSniffData(StoreNameType.Map, (int)CoreParsers.MovementHandler.CurrentMapId, "NEW_WORLD");
        }
    }
}
