using System;
using DZCP.Core;

namespace DZCP.Modules
{
    public class AntiCheatModule : IModule
    {
        public void Initialize()
        {
            Console.WriteLine("[DZCP] Anti-Cheat Module Loaded.");
        }

        public void DetectCheater(string player, string reason)
        {
            Console.WriteLine($"[AntiCheat] Player {player} flagged for cheating: {reason}");
        }
    }
}