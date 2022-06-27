using Castle.MicroKernel.ModelBuilder.Inspectors;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using RPG.Components.Menus;
using RPG.Components.Menus.PlayerMenu;
using RPG.Components.Menus.PlayerMenu.Items;
using RPG.Components.PlayerComponent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public interface INavigatorContent { }
    public interface IShowing: INavigatorContent
    {
        void Show();
    }
    public interface IHidding: INavigatorContent
    {
        void OnHide();
    }
    class AppNavigator
    {
        private List<INavigatorContent> _stack {get;}

        public INavigatorContent Current { get; }
        public void Show(INavigatorContent content)
        {

        }

        public void Back()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            var propertyResolver = container.Kernel.ComponentModelBuilder.Contributors
                .OfType<PropertiesDependenciesModelInspector>()
                .Single();

            container.Kernel.ComponentModelBuilder.RemoveContributor(propertyResolver);
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel, true));

            container.Register(
                Component.For<Game>(),
                Component.For<ConsoleManager>(),
                Component.For<MainMenuShower>(),
                Component.For<PlayerMenuShower>(),
                Component.For<MainMenu, IMenu>(),
                Component.For<PlayerMenu, IMenu>(),
                Component.For<IMainMenuItem>()
                    .ImplementedBy<StartGameMenuItem>(),
                Component.For<IMainMenuItem>()
                    .ImplementedBy<SettingsMenuItem>(),
                Component.For<IMainMenuItem>()
                    .ImplementedBy<ExitMenuItem>(),
                Component.For<IPlayerMenuItem>()
                    .ImplementedBy<NewPlayerMenuItem>(),
                Component.For<IPlayerMenuItem>()
                    .ImplementedBy<BackMenuItem>(),
                Component.For<IWindsorContainer>()
                    .Instance(container),
                Component.For<PlayerRepository>());





            var mainMenuShower = container.Resolve<MainMenuShower>();


            mainMenuShower.Show();

            //cm.ShowAndReadLine("Введите строку");




            container.Resolve<Game>();


            while (true)
            {

            }

            //bool firstStart = true;

            //Setup setup = new RegularSetup();
            //if (firstStart)
            //{
            //    setup = new FirstSetup();
            //}
            //setup.startGame();

            //Console.ReadLine();
        }

        private static void Cm_LineWritten(string obj)
        {
            Console.WriteLine($"Введена строка {obj}");
        }

        private static void Cm_KeyPressed(ConsoleKey obj)
        {
            Console.WriteLine($"Нажата клавиша {obj}");
        }
    }
}
