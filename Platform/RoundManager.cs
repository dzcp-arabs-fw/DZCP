using System;

namespace DZCP.Platform
{
    public static class RoundManager
    {
        private static bool isRoundActive = false;

        public static void StartRound()
        {
            if (isRoundActive)
            {
                Console.WriteLine("[RoundManager] A round is already in progress.");
                return;
            }

            isRoundActive = true;
            Console.WriteLine("[RoundManager] A new round has started.");
        }

        public static void EndRound()
        {
            if (!isRoundActive)
            {
                Console.WriteLine("[RoundManager] No active round to end.");
                return;
            }

            isRoundActive = false;
            Console.WriteLine("[RoundManager] The round has ended.");
        }

        public static bool IsRoundActive()
        {
            return isRoundActive;
        }
    }
}