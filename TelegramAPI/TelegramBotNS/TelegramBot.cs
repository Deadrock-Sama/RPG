using Core.Containers;
using Core.DBInteraction;
using RPG.Containers.DependencyProvider;
using System.Threading;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS
{
    public class TelegramBot
    {

        private ITelegramBotClient _Bot;
        private TelegramCommandsReader _Reader;
        private CancellationTokenSource _MainCancellationTokenSource;
        public TelegramBot()
        {

            _Bot = new TelegramBotClient("5426691903:AAGMj6d142-lOwy9etsuAn7TV0pfyNbVrtI");
            var repositoryShell = new RepositoryShell();
            var container = new ContainerBuilder().Create();
            container.Register(new TelegramDependencyProvider(repositoryShell, _Bot, container));

            _Reader = container.Resolve<TelegramCommandsReader>();
            _MainCancellationTokenSource = container.Resolve<CancellationTokenSource>();
        }

        public void Start()
        {
            _Bot.StartReceiving(_Reader.HandleUpdateAsync, _Reader.HandleErrorAsync, null, _MainCancellationTokenSource.Token);

        }
    }
}



