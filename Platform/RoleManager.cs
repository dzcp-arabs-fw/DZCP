using System;
using System.Collections.Generic;

namespace DZCP.Platform
{
    public static class RoleManager
    {
        private static Dictionary<string, string> playerRoles = new Dictionary<string, string>();

        public static void SetRole(string playerName, string role)
        {
            playerRoles[playerName] = role;
            Console.WriteLine($"[RoleManager] {playerName} is now a {role}.");
        }

        public static string GetRole(string playerName)
        {
            return playerRoles.ContainsKey(playerName) ? playerRoles[playerName] : "Unknown";
        }

        public static void RemoveRole(string playerName)
        {
            if (playerRoles.ContainsKey(playerName))
            {
                playerRoles.Remove(playerName);
                Console.WriteLine($"[RoleManager] {playerName} role removed.");
            }
        }
    }
}