using System;
using System.Threading;

namespace DZCP.Bootstrap
{
    public static class LogoLoader
    {
        public static void Initialize()
        {
            // تحميل الشعار في الكونسول
            DisplayLogo();

            Console.WriteLine("[DZCP] يتم تحميل الإطار...");
            LoadPlugins();
        }

        private static void DisplayLogo()
        {
            Console.Clear(); // تنظيف الشاشة
            Console.ForegroundColor = ConsoleColor.Cyan; // تغيير لون النص
            
            string[] logo = new string[]
            {
                "██████╗ ███████╗ ██████╗ ██████╗ ",  
                "██╔══██╗██╔════╝██╔═══██╗██╔══██╗",  
                "██████╔╝███████╗██║   ██║██████╔╝",  
                "██╔═══╝ ╚════██║██║   ██║██╔═══╝ ",  
                "██║     ███████║╚██████╔╝██║     ",  
                "╚═╝     ╚══════╝ ╚═════╝ ╚═╝     ",  
                "    DZCP Framework v1.0 🚀     "
            };

            foreach (string line in logo)
            {
                Console.WriteLine(line);
                Thread.Sleep(100); // تأثير ظهور تدريجي
            }
            
            Console.ResetColor();
            Console.WriteLine("\n[DZCP] تم تشغيل الإطار بنجاح!\n");
        }

        private static void LoadPlugins()
        {
            Console.WriteLine("[DZCP] يتم تحميل البلُغنات...");
            // كود تحميل الإضافات
        }
    }
}