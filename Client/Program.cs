using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.App;         // <-- for ClientUI.Attach
using Client.Config;
using Client.Forms;
using Client.Services;

class Program
{
	[STAThread]
	static async Task Main()
	{
		var config = new ClientConfig
		{
			ServerHost = "127.0.0.1",
			ServerPort = 5000
		};

		var client = new NetworkClient();
        _ = await client.TryConnectAsync(config);

        Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);

		var form = new MainMenuForm(client, config); // pass the client into the form
		ClientUI.Attach(form);               // <-- so packet handler can call form helpers

		Application.Run(form);

		// optional: clean shutdown
		try { client.Dispose(); } catch { /* ignore */ }
	}
}