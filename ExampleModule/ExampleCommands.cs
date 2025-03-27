using System;
using DZCP.Core;

namespace DZCP.ExampleModule
{
    public static class ExampleCommands
    {
        public static void RegisterCommands()
        {
            CommandManager.RegisterCommand("info", ShowServerInfo);
        }

        private static void ShowServerInfo(string[] args)
        {
            Console.WriteLine("[ExampleCommands] هذا الخادم يستخدم DZCP Framework!");
        }
    }
}