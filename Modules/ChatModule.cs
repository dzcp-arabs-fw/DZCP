using System;
using DZCP.Core;

namespace DZCP.Modules
{
    public class ChatModule : IModule
    {
        public void Initialize()
        {
            Console.WriteLine("[DZCP] Chat Module Loaded.");
        }

        public void SendMessage(string playerName, string message)
        {
            Console.WriteLine($"[Chat] {playerName}: {message}");
        }
    }
}