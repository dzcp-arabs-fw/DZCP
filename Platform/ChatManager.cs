using System;
using System.Collections.Generic;

namespace DZCP.Platform
{
    public static class ChatManager
    {
        private static List<string> chatLogs = new List<string>();

        public static void SendGlobalMessage(string message)
        {
            Console.WriteLine($"[GlobalChat] {message}");
            chatLogs.Add($"[Global] {message}");
        }

        public static void SendPrivateMessage(string sender, string receiver, string message)
        {
            Console.WriteLine($"[PM] {sender} -> {receiver}: {message}");
            chatLogs.Add($"[PM] {sender} -> {receiver}: {message}");
        }

        public static List<string> GetChatLogs()
        {
            return chatLogs;
        }
    }
}