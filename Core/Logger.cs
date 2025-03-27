using System;
using System.IO;

namespace DZCP.Core
{
    public static class Logger
    {
        private static string logPath = "Logs/log.txt";

        public static void Log(string message)
        {
            string logMessage = $"[{DateTime.Now}] {message}";
            Console.WriteLine(logMessage);
            File.AppendAllText(logPath, logMessage + Environment.NewLine);
        }
    }
}