using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Windows.Threading;

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

        public string getDeviceManufacturer()
        {
            StreamReader BuildProp = new StreamReader(Directory.GetCurrentDirectory().ToString() + "\\build.prop");
            string line;
            while ((line = BuildProp.ReadLine()) != null)
            {
                if (line.Contains("ro.product.manufacturer"))
                {
                    return line.Replace("ro.product.manufacturer=", null);
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

        public void getDeviceInfo()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += _getDeviceInfo;
            var frame = new DispatcherFrame();
            worker.RunWorkerCompleted += (sender, args) =>
            {
                frame.Continue = false;
            };
            worker.RunWorkerAsync();
            Dispatcher.PushFrame(frame);
        }

        public void _getDeviceInfo(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            string auth = adb.isAuthorized();
            if (auth == "authorized")
            {
                Dispatcher.Invoke(() => Start_Button.IsEnabled = false);
                Dispatcher.Invoke(() => Status_Label.Content = "Status: Pulling build.prop...");
                PullProp();
                string codename = getDeviceCodename();
                string manufactuer = getDeviceManufacturer();
                Dispatcher.Invoke(() => Status_Label.Content = "Device codename: " + codename);
                Dispatcher.Invoke(() => Status_Label.Foreground = Brushes.Green);
                Dispatcher.Invoke(() => Title.Text = "Checking device compatibility...");
                Dispatcher.Invoke(() => Loading_Bar.Visibility = Visibility.Visible);
                Console.WriteLine("http://github.com/lineageos/android_device_" + manufactuer + "_" + codename);
                HttpWebRequest search = (HttpWebRequest)WebRequest.Create("http://github.com/lineageos/android_device_" + manufactuer + "_" + codename);
                search.UserAgent = "Mozilla";
                search.Method = "GET";
                bool result = false;
                try
                {
                    HttpWebResponse response = (HttpWebResponse)search.GetResponse();
                    Console.WriteLine(response.StatusCode.ToString());
                    if (response.StatusCode.ToString() == "OK")
                    {
                        result = true;
                    }
                } catch
                {
                    result = false;
                }

                if (result == true)
                {
                    Dispatcher.Invoke(() => Status_Label.Content = "Device is compatible!");
                    Dispatcher.Invoke(() => Loading_Bar.Visibility = Visibility.Hidden);
                }

                if (result == false)
                {
                    Dispatcher.Invoke(() => Status_Label.Content = "Device is not compatible.");
                    Dispatcher.Invoke(() => Status_Label.Foreground = Brushes.Red);
                    Dispatcher.Invoke(() => Loading_Bar.Visibility = Visibility.Hidden);
                }
            }
            if (auth == "unauthorized")
            {
                Dispatcher.Invoke(() => Status_Label.Content = "Device is unauthorized. Did you accept the USB debugging request?");
                Dispatcher.Invoke(() => Start_Button.IsEnabled = true);
            }
            if (auth == "none")
            {
                Dispatcher.Invoke(() => Status_Label.Content = "Device not found. Do you have USB debugging enabled?");
                Dispatcher.Invoke(() => Start_Button.IsEnabled = true);
            }
        }

        public void getDeviceCompatibility()
        {

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
            getDeviceInfo();
            Console.WriteLine("Done!");
        }
    }
}
