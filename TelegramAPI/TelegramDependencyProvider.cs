using Castle.MicroKernel.Registration;
using NHibernate;
using RPG.Components.Containers;
using RPG.DBInteraction;
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

        private readonly IRepositoryShell _repository;
        private readonly ISessionFactory _sessionFactory;
        private readonly ITelegramBotClient _telegramBotClient;

        public TelegramDependencyProvider(IRepositoryShell repository, ISessionFactory sessionFactory, ITelegramBotClient bot)
        {

            _repository = repository;
            _sessionFactory = sessionFactory;
            _telegramBotClient = bot;

        }

        public IEnumerable<IRegistration> GetRegistrations()
        {
            yield return Component.For<ISessionFactory>()
                .Instance(_sessionFactory);

            yield return Component.For<IRepositoryShell>()
               .Instance(_repository);

            yield return Component.For<ITelegramBotClient>()
                .Instance(_telegramBotClient);

            yield return Component.For<CancellationTokenSource>();

            yield return Component.For<TelegramCommandsReader>();

        }
    }
}
