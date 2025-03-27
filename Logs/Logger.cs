using System;
using System.IO;

namespace DZCP.Logs
{
    public static class Logger
    {
        private static readonly string LogDirectory = "Logs/";
        private static readonly string GeneralLogFile = LogDirectory + "log_general.txt";
        private static readonly string ErrorLogFile = LogDirectory + "log_errors.txt";
        private static readonly string DebugLogFile = LogDirectory + "log_debug.txt";
        private static readonly string WarningLogFile = LogDirectory + "log_warnings.txt";

        static Logger()
        {
            if (!Directory.Exists(LogDirectory))
                Directory.CreateDirectory(LogDirectory);
        }

        public static void Log(string message)
        {
            WriteLog(GeneralLogFile, "[INFO] " + message);
        }

        public static void LogError(string message)
        {
            WriteLog(ErrorLogFile, "[ERROR] " + message);
            WriteLog(GeneralLogFile, "[ERROR] " + message);
        }

        public static void LogDebug(string message)
        {
            WriteLog(DebugLogFile, "[DEBUG] " + message);
            WriteLog(GeneralLogFile, "[DEBUG] " + message);
        }

        public static void LogWarning(string message)
        {
            WriteLog(WarningLogFile, "[WARNING] " + message);
            WriteLog(GeneralLogFile, "[WARNING] " + message);
        }

        private static void WriteLog(string filePath, string message)
        {
            string logMessage = $"[{DateTime.Now}] {message}";
            Console.WriteLine(logMessage);
            File.AppendAllText(filePath, logMessage + Environment.NewLine);
        }
    }
}