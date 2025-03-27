using System;
using System.IO;
using Newtonsoft.Json;

namespace DZCP.ExamplePlugin
{
    public static class PluginConfig
    {
        private static readonly string ConfigPath = "Configs/PluginConfig.json";
        public static ConfigData Settings { get; private set; }

        public static void LoadConfig()
        {
            if (!File.Exists(ConfigPath))
            {
                Console.WriteLine("[ExamplePlugin] لم يتم العثور على ملف الإعدادات، يتم إنشاء ملف جديد...");
                Settings = new ConfigData();
                SaveConfig();
            }
            else
            {
                string json = File.ReadAllText(ConfigPath);
                Settings = JsonConvert.DeserializeObject<ConfigData>(json);
                Console.WriteLine("[ExamplePlugin] تم تحميل إعدادات البلُغن بنجاح.");
            }
        }

        public static void SaveConfig()
        {
            string json = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            File.WriteAllText(ConfigPath, json);
            Console.WriteLine("[ExamplePlugin] تم حفظ إعدادات البلُغن.");
        }
    }

    public class ConfigData
    {
        public bool EnableFeature { get; set; } = true;
        public string WelcomeMessage { get; set; } = "مرحبًا بك في DZCP Example Plugin!";
    }
}