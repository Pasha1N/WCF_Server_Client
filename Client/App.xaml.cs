﻿using Client.ViewModel;
using System.Windows;

namespace Client
{

    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainViewModel mainViewModel = new MainViewModel();
            View.MainWindow mainWindow = new View.MainWindow(mainViewModel);
            mainWindow.Show();
        }
    }
}