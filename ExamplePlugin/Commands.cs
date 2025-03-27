using System;
using DZCP.Core;

namespace DZCP.ExamplePlugin
{
    public static class Commands
    {
        public static void RegisterCommands()
        {
            CommandManager.RegisterCommand("plugininfo", ShowPluginInfo);
        }

        private static void ShowPluginInfo(string[] args)
        {
            Console.WriteLine("[ExamplePlugin] هذا البلُغن يعمل باستخدام DZCP Framework!");
        }
    }
}