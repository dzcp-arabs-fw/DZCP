using System;
using System.Collections.Generic;

namespace DZCP.Core
{
    public static class CommandManager
    {
        private static Dictionary<string, Action<string[]>> commands = new Dictionary<string, Action<string[]>>();

        public static void RegisterCommand(string command, Action<string[]> action)
        {
            commands[command] = action;
        }

        public static void ExecuteCommand(string command, string[] args)
        {
            if (commands.ContainsKey(command))
                commands[command](args);
            else
                Console.WriteLine($"[DZCP] Command '{command}' not found.");
        }
    }
}