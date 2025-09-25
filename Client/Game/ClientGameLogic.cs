using System.Text.Json;
using System.Threading.Tasks;
using Shared.Networking;
using Client.Services;

namespace Client.Game
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

        public static async Task SendLogin(NetworkClient client, string user, string pass, string ver = "dev")
        {
            await client.SendAsync((int)ClientPacketId.CLogin, writer =>
            {
                writer.Write(user);
                writer.Write(pass);
                writer.Write(ver);
            });
        }

        public static async Task UseCharacter(NetworkClient client, string characterId)
        {
            await client.SendAsync((int)ClientPacketId.CUseChar, w => w.Write(characterId)); // server: ReadString()
        }

        public static async Task DeleteCharacter(NetworkClient client, string characterId)
        {
            await client.SendAsync((int)ClientPacketId.CDelChar, w => w.Write(characterId)); // server: ReadString()
        }

        public static async Task SendNewAccount(NetworkClient client, string username, string email, string password)
        {
            await client.SendAsync((int)ClientPacketId.CNewAccount, writer =>
            {
                writer.Write(username);
                writer.Write(email);
                writer.Write(password);
            });
        }
    }
}