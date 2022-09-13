using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Core.Containers;
using Core.DBInteraction;
using Core.PlayerNS;
using System.Collections.Generic;
using System.Linq;
using Telegram.Bot.Types;
using TelegramAPI.TelegramBotNS.Components;
using GameUser = Core.Users.User;

namespace TelegramAPI.TelegramBotNS
{
    public class GameSessionDependencyProvider : IDependencyProvider
    {
        private readonly IWindsorContainer _container;
        private readonly GameUser _user;
        private readonly Chat _chat;
        private readonly Player _player;

        public GameSessionDependencyProvider(IWindsorContainer container, GameUser user, Chat chat)
        {
            _container = container;
            _user = user;
            _chat = chat;
            //Не хорошо. Я бы вероятнее, добавил обертку. По типу класс "User taker",
            //у которого в констуркторе лежит пользователь и через него вытягивается игрок 
            _player = container.Resolve<RepositoryShell>().GetAll<Player>().FirstOrDefault(p => p.User == _user);
        }

        public IEnumerable<IRegistration> GetRegistrations()
        {

            yield return Component.For<IGameComponent>()
                .ImplementedBy<StartGameComponent>();

            yield return Component.For<IGameComponent>()
                .ImplementedBy<BattleComponent>();

            yield return Component.For<IGameComponent>()
                .ImplementedBy<CityComponent>();

            yield return Component.For<IGameComponent>()
                .ImplementedBy<InventoryComponent>();

            yield return Component.For<IGameComponent>()
                .ImplementedBy<JourneyComponent>();

            yield return Component.For<IGameComponent>()
                .ImplementedBy<PlayerComponent>();
           
            yield return Component.For<IGameComponent>()
                .ImplementedBy<CreatingPlayerComponent>();
           
            yield return Component.For<IGameComponent>()
                .ImplementedBy<ShopComponent>();

            yield return Component.For<GameUser>()
                .Instance(_user);

            yield return Component
         .For<GameSession>();

            if (_player != null)
            {
                yield return Component.For<Player>()
                .Instance(_player);
            }
            else
            {
                yield return Component.For<Player>();
            }

            yield return Component.For<Chat>()
                .Instance(_chat);

            yield return Component.For<SessionMessageSender>();

        }
    }
}
