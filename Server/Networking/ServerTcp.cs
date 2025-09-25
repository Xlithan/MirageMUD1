﻿using Shared.Models;
using Shared.Networking;
using System;
using System.Collections.Generic;

namespace Server.Networking
{
    public partial class ServerTcp
    {
        // SLoginOk = 3
        public void SendLoginOk(int clientId, bool success, string message, string accountId)
        {
            using var writer = new PacketWriter((int)ServerPacketId.SLoginOk);
            writer.Write(success);
            writer.Write(message ?? "");
            writer.Write(accountId ?? "");
            SendBytes(clientId, writer.ToArray());
        }

        // SAllChars = 2
        public void SendAllChars(int clientId, List<CharacterSummary> chars)
        {
            using var writer = new PacketWriter((int)ServerPacketId.SAllChars);
            writer.Write(chars.Count);
            foreach (var c in chars)
            {
                writer.Write(c.Id);
                writer.Write(c.Name);
                writer.Write(c.Class);
                writer.Write(c.Level);
            }
            SendBytes(clientId, writer.ToArray());
        }
        public void SendAlert(int clientId, string msg)
        {
            using var w = new PacketWriter((int)ServerPacketId.SAlertMsg);
            w.Write(msg ?? "");
            SendBytes(clientId, w.ToArray());
        }
        public void SendInGame(int clientId)
        {
            using var w = new PacketWriter((int)ServerPacketId.SInGame);
            SendBytes(clientId, w.ToArray());
        }
        public void SendSync(int clientId, string msg)
        {
            using var w = new PacketWriter((int)ServerPacketId.SSync);
            w.Write(msg ?? "");
            SendBytes(clientId, w.ToArray());
        }
    }
}