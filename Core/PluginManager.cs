using System;
using System.Collections.Generic;
using DZCP.Bootstrap;

namespace DZCP.Core
{
    public static class PluginManager
    {
        private static List<IPlugin> plugins = new List<IPlugin>();

        public static void RegisterPlugin(IPlugin plugin)
        {
            plugins.Add(plugin);
            Console.WriteLine($"[DZCP] Registered Plugin: {plugin.GetType().Name}");
        }

        public static void UnloadPlugin(IPlugin plugin)
        {
            plugins.Remove(plugin);
            Console.WriteLine($"[DZCP] Unloaded Plugin: {plugin.GetType().Name}");
        }

        public static List<IPlugin> GetLoadedPlugins()
        {
            return plugins;
        }
    }
}