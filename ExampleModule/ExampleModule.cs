using System;
using DZCP.Core;
using DZCP.Platform;

namespace DZCP.ExampleModule
{
    public class ExampleModule : IModule
    {
        public void Initialize()
        {
            Console.WriteLine("[ExampleModule] تم تحميل الوحدة التجريبية!");

            // تسجيل أحداث عند دخول اللاعب وخروجه
            GameEvents.OnPlayerJoin += OnPlayerJoin;
            GameEvents.OnPlayerDeath += OnPlayerDeath;

            // تسجيل أمر جديد داخل اللعبة
            CommandManager.RegisterCommand("example", ExampleCommand);
        }

        private void OnPlayerJoin(string playerName)
        {
            Console.WriteLine($"[ExampleModule] اللاعب {playerName} انضم إلى اللعبة!");
        }

        private void OnPlayerDeath(string playerName)
        {
            Console.WriteLine($"[ExampleModule] اللاعب {playerName} قد مات!");
        }

        private void ExampleCommand(string[] args)
        {
            Console.WriteLine("[ExampleModule] لقد استخدمت أمر الاختبار!");
        }
    }
}