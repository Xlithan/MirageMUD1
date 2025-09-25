using System;
using System.Collections.Generic;
using System.IO;
using Shared.Utilities;

namespace Client.Config
{
    public sealed class ClientConfig
    {
        public string ServerHost { get; set; } = "127.0.0.1";
        public int ServerPort { get; set; } = 5000;

        public bool Fullscreen { get; set; } = false;
        public int MusicVolume { get; set; } = 70; // 0..100
        public int SfxVolume { get; set; } = 70;   // 0..100

        // Optional: simple keybind map (string names to keys)
        public Dictionary<string, string> Keybinds { get; set; } = new()
        {
            ["MoveUp"] = "W",
            ["MoveDown"] = "S",
            ["MoveLeft"] = "A",
            ["MoveRight"] = "D",
            ["Attack"] = "Space"
        };

        public static string BaseDir =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MirageMUD");

        public static string PathFile => System.IO.Path.Combine(BaseDir, "client.config.json");

        public static ClientConfig Load() =>
            JsonConfig.LoadOrCreate(PathFile, () => new ClientConfig());

        public void Save() => JsonConfig.Save(PathFile, this);
    }
}