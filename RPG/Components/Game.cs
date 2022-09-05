using Castle.Windsor;
using Core.Containers;
using Core.DBInteraction;
using Core.DBInteraction.Mappings;
using RPG.Components.Containers;
using RPG.Components.MainMenuNS;
using RPG.Containers;
using RPG.Navigation;

namespace RPG.Components
{
    public class Game
    {

        private const string _connectionString = "Server=localhost;Database=RPG;User ID=postgres;Password=postgres;";
       
        private readonly IWindsorContainer _container;

        public Game()
        {

            var mappings = new MappingConfigurator();
            var mappingRegistar = new MappingsRegistrar();

            mappings = mappingRegistar.AddMappings(mappings);

            var dbConfigurator = new DbConfigurator(_connectionString, mappings);
            var sessionFactory = dbConfigurator.CreateSessionFactory();
            var repositoryShell = new RepositoryShell(sessionFactory);

            _container = new ContainerBuilder().Create();
            _container.Register(new MainDependencyProvider(repositoryShell, sessionFactory));

        }

        public void Start()
        {

            var navigator = _container.Resolve<AppNavigator>();
            var mainMenuShower = _container.Resolve<MainMenuShower>();
            navigator.Show(mainMenuShower);

            while (true)
            {

            }

        }

        public void Stop()
        {

        }
    }
}
