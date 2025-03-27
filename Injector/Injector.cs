using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DZCP.Injector
{
    public static class Injector
    {
        private const string ProcessName = "SCPSL"; // اسم عملية خادم SCP:SL
        private static string DZCPAssemblyPath = "DZCP.dll"; // ملف DLL الذي سيتم حقنه

        public static void Inject()
        {
            Console.WriteLine("[Injector] البحث عن عملية الخادم...");

            Process gameProcess = Process.GetProcessesByName(ProcessName).FirstOrDefault();
            if (gameProcess == null)
            {
                Console.WriteLine("[Injector] لم يتم العثور على عملية الخادم. تأكد من تشغيل SCP:SL Server.");
                return;
            }

            Console.WriteLine($"[Injector] تم العثور على الخادم! (PID: {gameProcess.Id})");

            if (!File.Exists(DZCPAssemblyPath))
            {
                Console.WriteLine($"[Injector] لم يتم العثور على الملف {DZCPAssemblyPath}، تأكد من أن DZCP.dll موجود.");
                return;
            }

            try
            {
                Console.WriteLine("[Injector] يتم تحميل DZCP داخل الخادم...");
                Assembly.LoadFile(Path.GetFullPath(DZCPAssemblyPath));
                Console.WriteLine("[Injector] تم حقن DZCP بنجاح!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Injector] فشل الحقن: {ex.Message}");
            }
        }
    }
}