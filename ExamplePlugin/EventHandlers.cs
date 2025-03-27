using System;
using DZCP.Platform;

namespace DZCP.ExamplePlugin
{
    public static class EventHandlers
    {
        public static void RegisterEvents()
        {
            GameEvents.OnPlayerJoin += WelcomePlayer;
            GameEvents.OnPlayerDeath += LogPlayerDeath;
        }

        private static void WelcomePlayer(string playerName)
        {
            Console.WriteLine($"[ExamplePlugin] أهلاً وسهلاً باللاعب {playerName}!");
            ChatManager.SendGlobalMessage($"مرحبًا {playerName} في DZCP Example Plugin!");
        }

        private static void LogPlayerDeath(string playerName)
        {
            Console.WriteLine($"[ExamplePlugin] اللاعب {playerName} قد مات!");
        }
    }
}