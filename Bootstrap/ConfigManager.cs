using System;
using System.IO;
using Newtonsoft.Json;

namespace DZCP.Bootstrap
{
    public static class ConfigManager
    {
        private static string configPath = "Configs/settings.json";
        public static dynamic Settings { get; private set; }

        public static void LoadConfig()
        {
            if (!File.Exists(configPath))
            {
                File.WriteAllText(configPath, "{ \"ServerName\": \"DZCP Server\", \"MaxPlayers\": 50 }");
                Console.WriteLine("[DZCP] Created default config file.");
            }

            string json = File.ReadAllText(configPath);
            Settings = JsonConvert.DeserializeObject<dynamic>(json);
            Console.WriteLine("[DZCP] Configuration loaded.");
        }

        public static void SaveConfig()
        {
            string json = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            File.WriteAllText(configPath, json);
            Console.WriteLine("[DZCP] Configuration saved.");
        }
    }
}