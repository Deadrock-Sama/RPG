using Castle.MicroKernel.ModelBuilder.Inspectors;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using RPG.Components.Containers;
using RPG.Components.Menus;
using RPG.Components.Menus.PlayerMenu;
using RPG.Components.Menus.PlayerMenu.Items;
using RPG.Components.PlayerComponent;
using System;
using System.Linq;

namespace RPG
{

    class Program
    {
        static void Main(string[] args)
        {

            var container = new MainContainerBuilder().Create();

            var navigator = container.Resolve<AppNavigator>();
            var mainMenuShower = container.Resolve<MainMenuShower>();
            navigator.Show(mainMenuShower);

            while (true)
            {

            }

        }
    }
}
