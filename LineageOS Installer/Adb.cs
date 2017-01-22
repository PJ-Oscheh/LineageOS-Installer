using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LineageOS_Installer
{
    class Adb
    {
        string currentDir = Directory.GetCurrentDirectory().ToString();
        string tempDir = Path.GetTempPath() + "LineageOS-Installer";
        string pullOutput;

        private void ExtractResource(string resource, string path)
        {
            if (!File.Exists(path))
            {
                string[] resourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
                Stream stream = GetType().Assembly.GetManifestResourceStream(resource);
                byte[] bytes = new byte[(int)stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                File.WriteAllBytes(path, bytes);
            }
        }

        public void Start()
        {
            if (!Directory.Exists(tempDir))
            {
                Directory.CreateDirectory(tempDir);
            }
            Console.WriteLine(tempDir);
            Console.WriteLine(tempDir + "\\adb.exe");
            // Extract adb and libraries
            ExtractResource("LineageOS_Installer.adb.adb.exe", tempDir + "\\adb.exe");
            ExtractResource("LineageOS_Installer.adb.AdbWinApi.dll", tempDir + "\\AdbWinApi.dll");
            ExtractResource("LineageOS_Installer.adb.AdbWinUsbApi.dll", tempDir + "\\AdbWinUsbApi.dll");
            

            // Start ADB server
            if (System.Diagnostics.Process.GetProcessesByName("adb.exe").Length == 0)
            {
                System.Diagnostics.Process startAdb = new System.Diagnostics.Process();
                startAdb.StartInfo.FileName = tempDir + "\\adb.exe";
                startAdb.StartInfo.Arguments = "start-server";
                startAdb.StartInfo.CreateNoWindow = true;
                startAdb.StartInfo.UseShellExecute = false;
                startAdb.StartInfo.RedirectStandardOutput = true;
                startAdb.Start();
            }
            
        }

        public void Stop()
        {
            // Stop ADB server
            System.Diagnostics.Process stopAdb = new System.Diagnostics.Process();
            stopAdb.StartInfo.FileName = tempDir + "\\adb.exe";
            stopAdb.StartInfo.Arguments = "kill-server";
            stopAdb.StartInfo.CreateNoWindow = true;
            stopAdb.StartInfo.UseShellExecute = false;
            stopAdb.StartInfo.RedirectStandardOutput = true;
            stopAdb.Start();

            // Kill process
            foreach (var process in System.Diagnostics.Process.GetProcessesByName("adb.exe"))
            {
                process.Kill();
            }

            // Delete leftover files
            /* This functionality does not work yet */
            //File.SetAttributes(currentDir + "\\adb.exe", FileAttributes.Normal);
            //File.SetAttributes(currentDir + "\\AdbWinApi.dll", FileAttributes.Normal);
            //File.SetAttributes(currentDir + "\\AdbWinUsbApi.dll", FileAttributes.Normal);
            //Console.WriteLine(currentDir + "\\adb.exe");
            //File.Delete(currentDir + "\\adb.exe");
            //File.Delete(currentDir + "\\AdbWinApi.dll");
            //File.Delete(currentDir + "\\AdbWinUsbApi.dll");
        }

        public string isAuthorized()
        {
            System.Diagnostics.Process devicesAdb = new System.Diagnostics.Process();
            devicesAdb.StartInfo.FileName = tempDir + "\\adb.exe";
            devicesAdb.StartInfo.Arguments = "devices";
            devicesAdb.StartInfo.CreateNoWindow = true;
            devicesAdb.StartInfo.UseShellExecute = false;
            devicesAdb.StartInfo.RedirectStandardOutput = true;
            devicesAdb.Start();
            string devicesOutput = devicesAdb.StandardOutput.ReadToEnd().Replace("List of devices attached", null);
            if (devicesOutput.Contains("unauthorized"))
            {
                Console.WriteLine("Device unautorized.");
                return "unauthorized";
            }
            if (devicesOutput.Contains("device"))
            {
                Console.WriteLine("Device authorized.");
                return "authorized";
            }
            else
            {
                Console.WriteLine("No devices were found. Is USB debugging enabled?");
                return "none";
            }
        }

        public void Pull(string file)
        {
            System.Diagnostics.Process pullAdb = new System.Diagnostics.Process();
            pullAdb.StartInfo.FileName = tempDir + "\\adb.exe";
            pullAdb.StartInfo.Arguments = "pull " + file;
            pullAdb.StartInfo.CreateNoWindow = true;
            pullAdb.StartInfo.UseShellExecute = false;
            pullAdb.StartInfo.RedirectStandardOutput = true;
            pullAdb.Start();
            pullOutput = pullAdb.StandardOutput.ReadToEnd().Replace("\r\n", null);
        }
    }
}
