﻿using Core.Containers;
using Core.DBInteraction;
using ObjectsCreator.MVVM.Models;
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

            var repo = new RepositoryShell();
            var container = new ContainerBuilder().Create();
            container.Register(new ObjectsCreatorDependencyProvider(repo));

            var window = container.Resolve<DefaultWindow>();
            var navigator = container.Resolve<AppNavigator>();
            window.Content = container.Resolve<MainContentViewModel>();

            window.Show();
            navigator.Show(container.Resolve<AuthorizationViewModel>());
        }
    }
}
