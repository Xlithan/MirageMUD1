using MirageMUD.Server.Config;
using MirageMUD.Server.Networking;

class Program
{
    static async Task Main()
    {
        var config = new ServerConfig
        {
            ListenIp = "127.0.0.1",
            Port = 5000
        };

        var server = new ServerTcp(config);
        server.Start();

        Console.WriteLine("[Server] Running. Press Enter to exit...");
        await Task.Run(Console.ReadLine); // Keeps app alive until Enter is pressed
    }
}