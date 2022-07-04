using Castle.MicroKernel.ModelBuilder.Inspectors;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using RPG.Components.Containers;
using RPG.Components.Menus;
using RPG.Components.Menus.PlayerMenu;
using RPG.Components.Menus.PlayerMenu.Items;
using RPG.Components.Navigation;
using RPG.Components.PlayerComponent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public static class ContainerExtensions
    {
        public static IWindsorContainer Register(this IWindsorContainer container, IDependencyProvider provider)
        {
            return container.Register(provider.GetRegistrations().ToArray());
        }
        public static IWindsorContainer Register(this IWindsorContainer container, IEnumerable<IRegistration> registrations)
        {
            return container.Register(registrations.ToArray());
        }
    }


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
