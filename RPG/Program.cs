using RPG.Components.Containers;
using RPG.Components.MainMenuNS;
using RPG.Containers;
using RPG.Navigation;

namespace RPG
{

    class Program
    {
        static void Main(string[] args)
        {
            var container = new ContainerBuilder().Create();
            container.Register(new MainDependencyProvider());

            var navigator = container.Resolve<AppNavigator>();
            var mainMenuShower = container.Resolve<MainMenuShower>();
            navigator.Show(mainMenuShower);

            while (true)
            {

            }

        }
    }
}
