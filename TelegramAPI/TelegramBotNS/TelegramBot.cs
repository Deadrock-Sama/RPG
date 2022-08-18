using Core.DBInteraction;
using Core.DBInteraction.Mappings;
using RPG.Components.Containers;
using RPG.Containers;
using RPG.Containers.DependencyProvider;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramAPI.TelegramBotNS
{
    public class TelegramBot
    {

        private ITelegramBotClient _Bot;
        private TelegramCommandsReader _Reader;
        private string _ConnectionString = "Server=localhost;Database=RPG;User ID=postgres;Password=postgres;";
        private CancellationTokenSource _MainCancellationTokenSource;
        public TelegramBot()
        {

            _Bot = new TelegramBotClient("5426691903:AAGMj6d142-lOwy9etsuAn7TV0pfyNbVrtI");

            var mappings = new MappingConfigurator();
            var mappingRegistar = new MappingsRegistrar();

            mappings = mappingRegistar.AddMappings(mappings);

            var dbConfigurator = new DbConfigurator(_ConnectionString, mappings);
            var sessionFactory = dbConfigurator.CreateSessionFactory();
            var repo = new RepositoryShell(sessionFactory);

            var container = new ContainerBuilder().Create();
            container.Register(new TelegramDependencyProvider(repo, sessionFactory, _Bot));

            _Reader = container.Resolve<TelegramCommandsReader>();
            _MainCancellationTokenSource = container.Resolve<CancellationTokenSource>();
        }

        public void Start()
        {
            _Bot.StartReceiving(_Reader.HandleUpdateAsync, _Reader.HandleErrorAsync, null, _MainCancellationTokenSource.Token);

        }
    }
}



