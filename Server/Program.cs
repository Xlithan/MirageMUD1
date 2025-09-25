using Server.Database;
using Server.Game;
using Server.Config;
using Server.Networking;
using Shared.Networking;

namespace Server
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var dataDir = Path.Combine(AppContext.BaseDirectory, "Data");
            Directory.CreateDirectory(dataDir);

            var repo = new JsonAccountRepository(dataDir);
            var logic = new ServerGameLogic(repo);
            var cfg = ServerConfig.Load();
            var tcp = new ServerTcp(cfg);
            var handler = new DataHandler(logic, tcp);

            tcp.OnPacket += (id, pid, payload) =>
            {
                handler.HandlePacket(id, pid, payload.Span);
            };

            tcp.Start();
            Console.WriteLine("[Server] Press Enter to quit...");
            Console.ReadLine();
            tcp.Stop();
        }
    }
}