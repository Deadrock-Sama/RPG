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

        private readonly IRepositoryShell _repository;
        private readonly ISessionFactory _sessionFactory;
        private readonly ITelegramBotClient _telegramBotClient;
        private readonly IWindsorContainer _container;

        public TelegramDependencyProvider(IRepositoryShell repository, ITelegramBotClient bot, IWindsorContainer container)
        {

            _repository = repository;
            _telegramBotClient = bot;
            _container = container;
        }

        public IEnumerable<IRegistration> GetRegistrations()
        {

            yield return Component.For<GameManager>();

            yield return Component.For<IRepositoryShell>()
               .Instance(_repository);

            yield return Component.For<ITelegramBotClient>()
                .Instance(_telegramBotClient);

            yield return Component.For<CancellationTokenSource>();

            yield return Component.For<TelegramCommandsReader>();

        }
    }
}
