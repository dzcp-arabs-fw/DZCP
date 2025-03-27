using System;
using System.Collections.Generic;

namespace DZCP.Core
{
    public static class ModuleManager
    {
        private static List<IModule> modules = new List<IModule>();

        public static void RegisterModule(IModule module)
        {
            modules.Add(module);
            Console.WriteLine($"[DZCP] Registered Module: {module.GetType().Name}");
        }

        public static List<IModule> GetModules()
        {
            return modules;
        }
    }

    public interface IModule
    {
        void Initialize();
    }
}