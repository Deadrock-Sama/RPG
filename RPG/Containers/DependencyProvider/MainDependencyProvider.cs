using Castle.MicroKernel.Registration;
using RPG.Components.MainMenuNS;
using RPG.Components.MainMenuNS.Items;
using RPG.Components.Menus;
using RPG.Components.PlayerNS;
using RPG.Components.PlayerNS.PlayerPage.PlayerActionMenu.Items;
using RPG.Components.PlayerSelection;
using RPG.Components.PlayerSelection.Items;
using RPG.ConsoleInteraction;
using RPG.Navigation;
using System.Collections.Generic;

namespace RPG.Components.Containers
{
    public class MainDependencyProvider : IDependencyProvider
    {
        public IEnumerable<IRegistration> GetRegistrations()
        {
            yield return Component.For<Game>();
            
            yield return Component.For<ConsoleManager>();
           
            yield return Component.For<MainMenuShower>();
            
            yield return Component.For<PlayerMenuShower>();
            
            yield return Component.For<MainMenu, IMenu>();
            
            yield return Component.For<PlayerMenu, IMenu>();
            
            yield return Component.For<IMainMenuItem>()
                   .ImplementedBy<StartGameMenuItem>();
            
            yield return Component.For<IMainMenuItem>()
                .ImplementedBy<SettingsMenuItem>();
            
            yield return Component.For<IMainMenuItem>()
                .ImplementedBy<ExitMenuItem>();
            
            yield return Component.For<IPlayerMenuItem>()
                .ImplementedBy<NewPlayerMenuItem>();
            
            yield return Component.For<IPlayerMenuItem, IPlayerInfoPageMenuItem>()
                .ImplementedBy<BackMenuItem>();
            
            yield return Component.For<PlayerRepository>();
              
            yield return Component.For<AppNavigator>();
        }
    }
}
