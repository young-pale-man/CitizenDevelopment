using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CitizenDevelopment1.ViewModels;

namespace CitizenDevelopment1
{
    public partial class App : Application
    {   
       
        protected override void OnStartup(StartupEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();

            window.DataContext = new MainViewModel();

            base.OnStartup(e);
        }
    }
}
