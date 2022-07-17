using RPG.Components.Containers;
using RPG.Components.MainMenuNS;
using RPG.Containers;
using RPG.DBInteraction;
using RPG.DBInteraction.Mappings;
using RPG.Navigation;

namespace RPG.Components
{
    public class Game
    {

        private string _ConnectionString = "Server=localhost;Database=RPG;User ID=postgres;Password=postgres;";

        public Game()
        {
        }

        public void Start()
        {

            var mappings = new MappingConfigurator();
            var mappingRegistar = new MappingsRegistrar();

            mappings = mappingRegistar.AddMappings(mappings);

            var dbConfigurator = new DbConfigurator(_ConnectionString, mappings);
            var sessionFactory = dbConfigurator.CreateSessionFactory();
            var repo = new RepositoryShell(sessionFactory);


            var container = new ContainerBuilder().Create();
            container.Register(new MainDependencyProvider(repo, sessionFactory));

            //Start
            var navigator = container.Resolve<AppNavigator>();
            var mainMenuShower = container.Resolve<MainMenuShower>();
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
