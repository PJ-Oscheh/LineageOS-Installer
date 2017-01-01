using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LineageOS_Installer
{
    /// <summary>
    /// Interaction logic for Detection.xaml
    /// </summary>
    public partial class Detection : Window
    {
        string adbPull_Output;
        string currentDir = Directory.GetCurrentDirectory().ToString();

        public Detection()
        {
            InitializeComponent();
        }

        void ExtractResource(string resource, string path)
        {
            string[] resourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            Stream stream = GetType().Assembly.GetManifestResourceStream(resource);
            byte[] bytes = new byte[(int)stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            File.WriteAllBytes(path, bytes);
        }

        public void PullProp()
        {
            
            ExtractResource("LineageOS_Installer.adb.adb.exe", currentDir + "\\adb.exe");
            ExtractResource("LineageOS_Installer.adb.AdbWinApi.dll", currentDir + "\\AdbWinApi.dll");
            ExtractResource("LineageOS_Installer.adb.AdbWinUsbApi.dll", currentDir + "\\AdbWinUsbApi.dll");
            System.Diagnostics.Process adbPull = new System.Diagnostics.Process();
            adbPull.StartInfo.FileName = "cmd.exe";
            adbPull.StartInfo.Arguments = "/c adb.exe pull system/build.prop";
            adbPull.StartInfo.CreateNoWindow = true;
            adbPull.StartInfo.UseShellExecute = false;
            adbPull.StartInfo.RedirectStandardOutput = true;
            adbPull.Start();

            adbPull_Output = adbPull.StandardOutput.ReadToEnd().Replace("\r\n", null);
            Console.WriteLine(adbPull_Output);

            File.Delete(currentDir + "\\adb.exe");
            File.Delete(currentDir + "\\AdbWinApi.dll");
            File.Delete(currentDir + "\\AdbWinUsbApi.dll");
        }

        public string ReadProp(string value)
        {
            StreamReader BuildProp = new StreamReader(Directory.GetCurrentDirectory().ToString() + "\\build.prop");
            string line;
            while ((line = BuildProp.ReadLine()) != null)
            {
                if (line.Contains(value))
                {
                    return line.Replace(value + "=", null);
                }
            }
            return null;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PullProp();
            Status_Label.Content = "Device version: " + ReadProp("ro.build.version.release");
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.Delete(currentDir + "\\build.prop");
        }
    }
}
