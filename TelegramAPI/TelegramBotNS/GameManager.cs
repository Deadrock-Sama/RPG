using Castle.Windsor;
using Core.Containers;
using System.Collections.Generic;
using Telegram.Bot.Types;

namespace TelegramAPI.TelegramBotNS
{
    public class GameManager
    {
        private readonly IWindsorContainer _container;
        private readonly Dictionary<string, GameSession> _opendSessions = new();
        private readonly Dictionary<string, IWindsorContainer> _containers = new();
        //Реализовать закрытие сессий

        public GameManager(IWindsorContainer container)
        {
            _container = container;
        }

        public void HandleCommand(string command, string userId, Chat chat)
        {
            if (_opendSessions.ContainsKey(userId))
            {
                _opendSessions[userId].HandleCommand(command);
            }
            else
            {
                var child = new WindsorContainer();
                _container.AddChildContainer(child);
                child.Register(new GameSessionDependencyProvider(child, userId, chat));

                var newSession = child.Resolve<GameSession>();
                _opendSessions.Add(userId, newSession);
                _containers.Add(userId, child);

                newSession.HandleCommand(command);
            }
        }
    }
}
