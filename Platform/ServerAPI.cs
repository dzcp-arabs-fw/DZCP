using System;

namespace DZCP.Platform
{
    public static class ServerAPI
    {
        public static void RestartServer()
        {
            Console.WriteLine("[ServerAPI] Restarting server...");
            // كود لإعادة تشغيل الخادم
        }

        public static void ChangeMap(string mapName)
        {
            Console.WriteLine($"[ServerAPI] Changing map to {mapName}...");
            // كود لتغيير الخريطة
        }

        public static int GetPlayerCount()
        {
            // كود للحصول على عدد اللاعبين
            return 10; // قيمة تجريبية
        }
    }
}