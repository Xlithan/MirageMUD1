using System;
using System.Threading.Tasks;
using MirageMUD.Shared.Networking;
using MirageMUD.Client.Services;

namespace MirageMUD.Client.Game
{
    public static class ClientGameLogic
    {
        public static async Task SendSync(NetworkClient client)
        {
            await client.SendAsync((int)ClientPacketId.CSync, writer =>
            {
                writer.Write("Hello from client");
            });
        }
    }
}