using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DZCP.Bootstrap
{
    public static class SecurityManager
    {
        private static string[] protectedFiles = { "Loader.cs", "ConfigManager.cs", "ServiceManager.cs" };

        public static void VerifyIntegrity()
        {
            foreach (var file in protectedFiles)
            {
                string filePath = $"Bootstrap/{file}";
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"[DZCP] Warning: Critical file {file} is missing!");
                    continue;
                }

                string hash = ComputeHash(File.ReadAllText(filePath));
                Console.WriteLine($"[DZCP] Verified {file}: {hash}");
            }
        }

        private static string ComputeHash(string content)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(content));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}