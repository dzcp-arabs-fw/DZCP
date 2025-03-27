using System;
using DZCP.Platform;

namespace DZCP.ExampleModule
{
    public static class ExampleHandler
    {
        public static void RegisterEvents()
        {
            GameEvents.OnPlayerJoin += WelcomePlayer;
        }

        private static void WelcomePlayer(string playerName)
        {
            Console.WriteLine($"[ExampleHandler] أهلاً وسهلاً باللاعب {playerName}!");
            ChatManager.SendGlobalMessage($"مرحبًا {playerName} في الخادم!");
        }
    }
}