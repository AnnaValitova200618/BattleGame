using EEEeee.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EEEeee
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal static void SwitchMainWindow(Window window) 
        {
            Current.MainWindow?.Close();
            Current.MainWindow = window;
            Current.MainWindow.Show();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            SwitchMainWindow(new MainWindow());
        }
    }
}
