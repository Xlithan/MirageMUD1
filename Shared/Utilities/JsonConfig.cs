using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MirageMUD.Shared.Utilities
{
    public static class JsonConfig
    {
        private static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static T LoadOrCreate<T>(string path, Func<T> createDefault)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path)!);

            if (!File.Exists(path))
            {
                var fresh = createDefault();
                Save(path, fresh);
                return fresh;
            }

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<T>(json, Options)
                   ?? throw new InvalidOperationException($"Failed to parse config {path}");
        }

        public static void Save<T>(string path, T data)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path)!);
            var json = JsonSerializer.Serialize(data, Options);
            File.WriteAllText(path, json);
        }
    }
}