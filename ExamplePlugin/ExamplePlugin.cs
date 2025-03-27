using System;
using DZCP.Bootstrap;
using DZCP.Core;
using DZCP.Platform;

namespace DZCP.ExamplePlugin
{
    public class ExamplePlugin : IPlugin
    {
        public void OnLoad()
        {
            Console.WriteLine("[ExamplePlugin] تم تحميل البلُغن التجريبي بنجاح!");

            // تحميل إعدادات البلُغن
            PluginConfig.LoadConfig();

            // تسجيل الأحداث
            EventHandlers.RegisterEvents();

            // تسجيل الأوامر الخاصة بالبلُغن
            Commands.RegisterCommands();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}