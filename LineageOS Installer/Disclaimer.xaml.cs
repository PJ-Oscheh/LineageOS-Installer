using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for Disclaimer.xaml
    /// </summary>
    public partial class Disclaimer : Window
    {
        public Disclaimer()
        {
            InitializeComponent();
        }

        private void Agree_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Next_Button.IsEnabled = true;
        }

        private void Agree_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Next_Button.IsEnabled = false;
        }
    }
}
