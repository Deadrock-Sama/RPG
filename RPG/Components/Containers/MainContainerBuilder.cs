using Castle.MicroKernel.Registration;
using Castle.Windsor;
using RPG.Components.Menus;
using RPG.Components.Menus.PlayerInfoPageComponent;
using RPG.Components.Menus.PlayerMenu;
using RPG.Components.Menus.PlayerMenu.Items;
using RPG.Components.PlayerComponent;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.Containers
{
    class MainContainerBuilder : ContainerBuilder
    {
        public WindsorContainer Create()
        {
            var container = base.Create();
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
                Component.For<IPlayerMenuItem, IPlayerInfoPageMenuItem>()
                    .ImplementedBy<BackMenuItem>(),
                Component.For<PlayerRepository>(),
                Component.For<AppNavigator>());

            return container;

        }

    }
}
