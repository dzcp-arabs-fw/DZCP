using System;
using System.Collections.Generic;

namespace DZCP.Platform
{
    public static class PlayerAPI
    {
        private static List<string> players = new List<string>();

        public static void AddPlayer(string playerName)
        {
            players.Add(playerName);
            Console.WriteLine($"[PlayerAPI] {playerName} joined the game.");
        }

        public static void RemovePlayer(string playerName)
        {
            players.Remove(playerName);
            Console.WriteLine($"[PlayerAPI] {playerName} left the game.");
        }

        public static void SendMessage(string playerName, string message)
        {
            Console.WriteLine($"[Chat] {playerName}: {message}");
            // كود لإرسال رسالة للاعب داخل اللعبة
        }

        public static List<string> GetAllPlayers()
        {
            return players;
        }
    }
}