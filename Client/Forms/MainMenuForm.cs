using Client.Config;
using Client.Game;
using Client.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class MainMenuForm : Form
    {
        private readonly NetworkClient _client;
        private readonly ClientConfig _config;

        public MainMenuForm(NetworkClient client, ClientConfig config)
        {
            _client = client;
            _config = config;
            InitializeComponent();
            InitializeNavigation();
        }
    }
}