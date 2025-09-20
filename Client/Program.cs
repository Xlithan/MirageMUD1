using MirageMUD.Client.Config;
using MirageMUD.Client.Game;
using MirageMUD.Client.Services;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("kernel32.dll")]
    private static extern bool AllocConsole();

    [STAThread]
    static async Task Main()
    {
        AllocConsole(); // attach a console window
        var config = new ClientConfig
        {
            ServerHost = "127.0.0.1",
            ServerPort = 5000
        };

        var client = new NetworkClient();
        await client.ConnectAsync(config);

        // Immediately send sync
        await ClientGameLogic.SendSync(client);

        Console.WriteLine("[Client] Press Enter to quit...");
        await Task.Run(Console.ReadLine);
    }
}