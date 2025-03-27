using System;
using System.IO;
using System.Reflection;

namespace DZCP.Bootstrap
{
    public static class DependencyLoader
    {
        private static string dependencyPath = "Dependencies/";

        public static void LoadDependencies()
        {
            if (!Directory.Exists(dependencyPath))
                Directory.CreateDirectory(dependencyPath);

            foreach (var file in Directory.GetFiles(dependencyPath, "*.dll"))
            {
                try
                {
                    Assembly.LoadFile(Path.GetFullPath(file));
                    Console.WriteLine($"[DZCP] Loaded dependency: {Path.GetFileName(file)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[DZCP] Failed to load {Path.GetFileName(file)}: {ex.Message}");
                }
            }
        }
    }
}