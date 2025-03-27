using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DZCP.Injector
{
    public static class MemoryManager
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr hObject);

        private const int PROCESS_ALL_ACCESS = 0x1F0FFF;

        public static void InjectCode(Process process, byte[] shellcode)
        {
            IntPtr processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, process.Id);
            if (processHandle == IntPtr.Zero)
            {
                Console.WriteLine("[MemoryManager] فشل فتح عملية SCP:SL.");
                return;
            }

            IntPtr allocatedMemory = Marshal.AllocHGlobal(shellcode.Length);
            Marshal.Copy(shellcode, 0, allocatedMemory, shellcode.Length);

            IntPtr bytesWritten;
            bool result = WriteProcessMemory(processHandle, allocatedMemory, shellcode, (uint)shellcode.Length, out bytesWritten);

            if (result)
                Console.WriteLine("[MemoryManager] تم حقن الشيفرة البرمجية بنجاح!");
            else
                Console.WriteLine("[MemoryManager] فشل في حقن الشيفرة البرمجية!");

            CloseHandle(processHandle);
        }
    }
}