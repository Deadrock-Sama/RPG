using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Core.Containers;
using Core.DBInteraction;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Telegram.Bot;
using TelegramAPI.TelegramBotNS;

namespace RPG.Containers.DependencyProvider
{
    internal class TelegramDependencyProvider : IDependencyProvider
    {

        private readonly IRepositoryShell _repositoryShell;
        private readonly ISessionFactory _sessionFactory;
        private readonly ITelegramBotClient _telegramBotClient;
        private readonly IWindsorContainer _container;

        public TelegramDependencyProvider(IRepositoryShell repositoryShell, ITelegramBotClient bot, IWindsorContainer container)
        {
            _repositoryShell = repositoryShell;
            _telegramBotClient = bot;
            _container = container;
        }

        public IEnumerable<IRegistration> GetRegistrations()
        {

            yield return Component.For<GameManager>();

            yield return Component.For<IRepositoryShell, RepositoryShell>()
               .Instance(_repositoryShell);

            yield return Component.For<ITelegramBotClient>()
                .Instance(_telegramBotClient);

            yield return Component.For<CancellationTokenSource>();

            yield return Component.For<TelegramCommandsReader>();

        }
    }
}
