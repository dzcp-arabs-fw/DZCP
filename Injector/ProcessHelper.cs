using System;
using System.Diagnostics;
using System.Linq;

namespace DZCP.Injector
{
    public static class ProcessHelper
    {
        public static Process GetServerProcess()
        {
            return Process.GetProcessesByName("SCPSL").FirstOrDefault();
        }

        public static bool IsServerRunning()
        {
            return GetServerProcess() != null;
        }
    }
}