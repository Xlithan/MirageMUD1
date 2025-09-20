using System;
using MirageMUD.Shared.Networking;

namespace MirageMUD.Client.Game
{
    public static class DataHandler
    {
        public static void Handle(PacketReader reader)
        {
            switch ((ServerPacketId)reader.Id)
            {
                case ServerPacketId.SAlertMsg:
                    string alert = reader.ReadString();
                    Console.WriteLine($"[Client] Alert: {alert}");
                    // TODO: display in game UI
                    break;

                case ServerPacketId.SSync:
                    string reply = reader.ReadString();
                    Console.WriteLine($"[Client] Sync reply: {reply}");
                    break;

                default:
                    Console.WriteLine($"[Client] Unhandled server packet: {reader.Id}");
                    break;
            }
        }
    }
}