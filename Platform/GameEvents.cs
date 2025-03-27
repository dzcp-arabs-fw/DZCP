using System;

namespace DZCP.Platform
{
    public static class GameEvents
    {
        public static event Action<string> OnPlayerDeath;
        public static event Action<string> OnPlayerJoin;

        public static void TriggerPlayerDeath(string playerName)
        {
            Console.WriteLine($"[GameEvents] {playerName} has died.");
            OnPlayerDeath?.Invoke(playerName);
        }

        public static void TriggerPlayerJoin(string playerName)
        {
            Console.WriteLine($"[GameEvents] {playerName} has joined the game.");
            OnPlayerJoin?.Invoke(playerName);
        }
    }
}