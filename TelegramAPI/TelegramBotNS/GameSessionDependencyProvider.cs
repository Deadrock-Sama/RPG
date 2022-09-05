using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Core.Containers;
using Core.PlayerNS;
using System.Collections.Generic;
using Telegram.Bot.Types;
using TelegramAPI.TelegramBotNS.Components;
using GameUser = Core.Users.User;

namespace TelegramAPI.TelegramBotNS
{
    public class GameSessionDependencyProvider : IDependencyProvider
    {
        private readonly IWindsorContainer _container;
        private readonly GameUser _user;
        private readonly Chat _Chat;
        public GameSessionDependencyProvider(IWindsorContainer container, GameUser user, Chat chat)
        {
            _container = container;
            _user = user;
            _Chat = chat;
        }

        public IEnumerable<IRegistration> GetRegistrations()
        {
            yield return Component
                .For<GameSession>();
            yield return Component
                .For<IWindsorContainer>()
                .Instance(_container);

            yield return Component.For<StartGameComponent, IGameComponent>();

            yield return Component.For<CreatingPlayerComponent, IGameComponent>();

            yield return Component.For<BattleComponent, IGameComponent>();

            yield return Component.For<CityComponent, IGameComponent>();

            yield return Component.For<InventoryComponent, IGameComponent>();

            yield return Component.For<JourneyComponent, IGameComponent>();

            yield return Component.For<PlayerComponent, IGameComponent>();

            yield return Component.For<ShopComponent, IGameComponent>();

            yield return Component.For<GameUser>()
                .Instance(_user);

            yield return Component.For<Player>(); //проверить, подтянется ли пользователь

            yield return Component.For<Chat>()
                .Instance(_Chat);

            yield return Component.For<SessionMessageSender>();

        }
    }
}
