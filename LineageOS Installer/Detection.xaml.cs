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
        Adb adb = new Adb();

        public Detection()
        {
            InitializeComponent();
        }

        public void PullProp()
        {
            adb.Start();
            adb.Pull("system/build.prop");
            Console.WriteLine(adbPull_Output);
            adb.Stop();
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
