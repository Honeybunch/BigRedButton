using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace BigRedButton
{

    class ProcessTools
    {
        private static uint PROCESS_QUERY_LIMITED_INFORMATION = 0x1000;

        /// <summary>
        /// Gets the name of the executable file from the given process
        /// </summary>
        /// <param name="process">The process to get the executable from</param>
        /// <returns>The name of the executable</returns>
        public static string GetProcessExecutableName(Process process) 
        {
            string path = GetProcessExecutablePath(process);

            return GetFileNameFromPath(path);
        }

        public static string GetFileNameFromPath(string path) 
        {
            int splitIndex = path.LastIndexOf("\\") + 1;

            string name = path.Substring(splitIndex);

            //If there is a trailing " character remove it
            if (name.EndsWith("\""))
                name = name.TrimEnd('"');

            return name;
        }

        /// <summary>
        /// Gets the path of the exectable file from the given process
        /// </summary>
        /// <param name="Process">The process to get the executable from</param>
        /// <returns>The path to the executable</returns>
        public static string GetProcessExecutablePath(Process Process)
        {
            if (Environment.OSVersion.Version.Major >= 6)
                return GetExecutablePathElevated(Process.Id);

            return Process.MainModule.FileName;
        }

        private static string GetExecutablePathElevated(int ProcessId) 
        {
            StringBuilder buffer = new StringBuilder(1024);
            IntPtr hprocess = OpenProcess(PROCESS_QUERY_LIMITED_INFORMATION, false, ProcessId);

            //If we opened the process
            if (hprocess != IntPtr.Zero) 
            {
                try
                {
                    int size = buffer.Capacity;
                    if (QueryFullProcessImageName(hprocess, 0, buffer, out size))
                        return buffer.ToString();
                }
                finally
                {
                    CloseHandle(hprocess);
                }
            }

            return null;
        }

        /// <summary>
        /// Returns the currently focused process
        /// </summary>
        /// <returns>the currently focued process</returns>
        public static Process GetForegroundProcess() 
        {
            IntPtr hwnd = GetForegroundWindow();

            if (hwnd == null)
                return null;

            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);

            foreach(Process p in Process.GetProcesses())
            {
                if (p.Id == pid)
                    return p;
            }

            return null;
        }
        

        [DllImport("kernel32.dll")]
        private static extern bool QueryFullProcessImageName(IntPtr hprocess, int dwFlags, StringBuilder lpExeName, out int size);

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(uint dwDesiredAccess,
                       bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hHandle);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint processId);
    }
}
