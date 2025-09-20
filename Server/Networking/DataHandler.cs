using MirageMUD.Server.Game;
using MirageMUD.Shared.Networking;
using System;

namespace MirageMUD.Server.Networking
{
    public static class DataHandler
    {
        public static async Task Handle(int clientId, PacketReader reader, ServerTcp server)
        {
            switch ((ClientPacketId)reader.Id)
            {
                case ClientPacketId.CSync:
                    string msg = reader.ReadString();
                    Console.WriteLine($"[Server] Client {clientId} sync: {msg}");
                    if (server.TryGetClient(clientId, out var conn))
                    {
                        await ServerGameLogic.SendSync(conn);
                    }
                    break;

                default:
                    Console.WriteLine($"[Server] Unhandled client packet {reader.Id} from {clientId}");
                    break;
            }
        }
    }
}