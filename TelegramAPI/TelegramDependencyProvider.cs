using Castle.MicroKernel.Registration;
using Core.DBInteraction;
using NHibernate;
using RPG.Components.Containers;
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

        public TelegramDependencyProvider(IRepositoryShell repository, ITelegramBotClient bot)
        {

            _repository = repository;
            _telegramBotClient = bot;

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
