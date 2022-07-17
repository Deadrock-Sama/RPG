using Castle.MicroKernel.Registration;
using NHibernate;
using RPG.Components.MainMenuNS;
using RPG.Components.MainMenuNS.Items;
using RPG.Components.Menus;
using RPG.Components.PlayerNS;
using RPG.Components.PlayerNS.PlayerPage.PlayerActionMenu.Items;
using RPG.Components.PlayerSelection;
using RPG.Components.PlayerSelection.Items;
using RPG.ConsoleInteraction;
using RPG.DBInteraction;
using RPG.Navigation;
using System.Collections.Generic;

namespace RPG.Components.Containers
{
    public class MainDependencyProvider : IDependencyProvider
    {
        private readonly IRepositoryShell _repository;
        private readonly ISessionFactory _sessionFactory;

        public MainDependencyProvider(IRepositoryShell repository, ISessionFactory sessionFactory)
        {
            _repository = repository;
            _sessionFactory = sessionFactory;
        }




        public IEnumerable<IRegistration> GetRegistrations()
        {
            yield return Component.For<ISessionFactory>()
                .Instance(_sessionFactory);

            yield return Component.For<IRepositoryShell>()
               .Instance(_repository);

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
