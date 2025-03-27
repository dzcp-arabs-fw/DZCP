using System;
using System.Collections.Generic;

namespace DZCP.Bootstrap
{
    public static class ServiceManager
    {
        private static Dictionary<string, IService> services = new Dictionary<string, IService>();

        public static void RegisterService(string name, IService service)
        {
            services[name] = service;
            service.Start();
            Console.WriteLine($"[DZCP] Service {name} started.");
        }

        public static void StopAllServices()
        {
            foreach (var service in services.Values)
                service.Stop();

            Console.WriteLine("[DZCP] All services stopped.");
        }
    }

    public interface IService
    {
        void Start();
        void Stop();
    }
}