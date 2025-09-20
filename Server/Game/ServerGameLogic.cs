using MirageMUD.Server.Networking;
using MirageMUD.Shared.Networking;
using System;
using System.Threading.Tasks;

namespace MirageMUD.Server.Game
{
    public static class ServerGameLogic
    {
        public static async Task SendSync(ClientConnection conn)
        {
            await conn.SendAsync((int)ServerPacketId.SSync, writer =>
            {
                writer.Write("Hello from server");
            });
        }
    }
}
