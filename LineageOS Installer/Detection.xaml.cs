using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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

        public string getDeviceCodename()
        {
            StreamReader BuildProp = new StreamReader(Directory.GetCurrentDirectory().ToString() + "\\build.prop");
            string line;
            while ((line = BuildProp.ReadLine()) != null)
            {
                if (line.Contains("ro.product.device"))
                {
                    return line.Replace("ro.product.device=", null);
                }
                if (line.Contains("ro.cm.device"))
                {
                    return (line.Replace("ro.cm.device=", null));
                }
            }
            return null;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            adb.Start();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            string auth = adb.isAuthorized();
            if (auth == "authorized")
            {
                Start_Button.IsEnabled = false;
                Status_Label.Content = "Status: Pulling build.prop...";
                PullProp();
                Status_Label.Content = "Device codename: " + getDeviceCodename();
            }
            if (auth == "unauthorized")
            {
                Status_Label.Content = "Device is unauthorized. Did you accept the USB debugging request?";
                Start_Button.IsEnabled = true;
            }
            if (auth == "none")
            {
                Status_Label.Content = "Device not found. Do you have USB debugging enabled?";
                Start_Button.IsEnabled = true;
            }
        }
    }
}
