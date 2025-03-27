using System;
using System.Net;

namespace DZCP.Bootstrap
{
    public static class UpdateChecker
    {
        private static string updateUrl = "https://example.com/dzcp/version.txt"; // استبدلها بمصدر حقيقي

        public static void CheckForUpdates()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string latestVersion = client.DownloadString(updateUrl).Trim();
                    string currentVersion = "1.0.0"; // قم بتحديث هذا بناءً على إصدار DZCP الحالي

                    if (latestVersion != currentVersion)
                        Console.WriteLine($"[DZCP] New version available: {latestVersion}. Please update!");
                    else
                        Console.WriteLine("[DZCP] You are using the latest version.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[DZCP] Failed to check for updates: {ex.Message}");
                }
            }
        }
    }
}