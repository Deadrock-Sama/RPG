using Core.Containers;
using Core.DBInteraction;
using ObjectsCreator.MVVM.Models;
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

            var repositoryShell = new RepositoryShell();
            var container = new ContainerBuilder().Create();
            container.Register(new ObjectsCreatorDependencyProvider(repositoryShell));

            var window = container.Resolve<DefaultWindow>();
            var navigator = container.Resolve<AppNavigator>();
            window.Content = container.Resolve<MainContentViewModel>();

            window.Show();
            navigator.Show(container.Resolve<AuthorizationViewModel>());
        }
    }
}
