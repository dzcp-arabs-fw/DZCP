using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DZCP.Bootstrap
{
    public static class Loader
    {
        public static List<IPlugin> Plugins = new List<IPlugin>();

        public static void Initialize()
        {
            Console.WriteLine("[DZCP] Initializing...");
            LoadPlugins();
        }

        public static void LoadPlugins()
        {
            string pluginPath = "Plugins/";
            if (!Directory.Exists(pluginPath))
                Directory.CreateDirectory(pluginPath);

            foreach (var file in Directory.GetFiles(pluginPath, "*.dll"))
            {
                Assembly assembly = Assembly.LoadFile(file);
                foreach (var type in assembly.GetTypes())
                {
                    if (typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface)
                    {
                        IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                        Plugins.Add(plugin);
                        plugin.OnLoad();
                    }
                }
            }
            Console.WriteLine($"[DZCP] Loaded {Plugins.Count} plugins.");
        }
    }

    public interface IPlugin
    {
        void OnLoad();

        void Initialize();
    }
}