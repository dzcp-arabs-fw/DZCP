using System;
using System.Collections.Generic;

namespace DZCP.Platform
{
    public static class BanSystem
    {
        private static List<string> bannedPlayers = new List<string>();

        public static void BanPlayer(string playerName)
        {
            if (bannedPlayers.Contains(playerName))
            {
                Console.WriteLine($"[BanSystem] {playerName} is already banned.");
                return;
            }

            bannedPlayers.Add(playerName);
            Console.WriteLine($"[BanSystem] {playerName} has been banned.");
        }

        public static void UnbanPlayer(string playerName)
        {
            if (!bannedPlayers.Contains(playerName))
            {
                Console.WriteLine($"[BanSystem] {playerName} is not banned.");
                return;
            }

            bannedPlayers.Remove(playerName);
            Console.WriteLine($"[BanSystem] {playerName} has been unbanned.");
        }

        public static bool IsPlayerBanned(string playerName)
        {
            return bannedPlayers.Contains(playerName);
        }
    }
}