﻿using ObjectsCreator.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ObjectsCreator
{


    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var window = new DefaultWindow();
            var navigator = new AppNavigator();
            window.Content = new MainContentViewModel(navigator);

            window.Show();
            navigator.Show(new AuthorizationViewModel(navigator));
        }
    }
}
