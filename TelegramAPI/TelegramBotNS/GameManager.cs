using Castle.Windsor;
using Core.Containers;
using Core.DBInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Timers;
using Telegram.Bot.Types;
using GameUser = Core.Users.User;

namespace TelegramAPI.TelegramBotNS
{
    public interface ISessionCountEditor
    {
        void Add();
        void Remove();
        void Clear();
    }
    public interface ISessionCount
    {
        IObservable<int> CountObservable { get; }
        int Count { get; }
    }

    public class OpendSessionsService : ISessionCount, ISessionCountEditor
    {
        private readonly BehaviorSubject<int> _countSubject = new BehaviorSubject<int>(0);
        public IObservable<int> CountObservable => _countSubject;
        public int Count => _countSubject.Value;

        public void Add()
        {
            _countSubject.OnNext(Count + 1);
        }

        public void Clear()
        {
            _countSubject.OnNext(0);
        }

        public void Remove()
        {
            _countSubject.OnNext(Count - 1);
        }
    }


    public class GameManager
    {
        private readonly IWindsorContainer _container;
        private readonly Dictionary<string, GameSession> _openedSessions = new();
        private readonly Dictionary<string, IWindsorContainer> _containers = new();
        private readonly RepositoryShell _repositoryShell;
        private readonly ISessionCountEditor _sessionCountEditor;
        private Timer _timer;

        public GameManager(IWindsorContainer container, RepositoryShell repositoryShell, ISessionCountEditor sessionCountEditor)
        {
            _container = container;
            _repositoryShell = repositoryShell;
            _sessionCountEditor = sessionCountEditor;
            SetTimer();
        }

        public void HandleCommand(string command, string userId, Chat chat)
        {
            if (_openedSessions.ContainsKey(userId))
            {
                _openedSessions[userId].HandleCommand(command);
            }
            else
            {
                _sessionCountEditor.Add();
                var user = GetUser(userId);
                var child = new ContainerBuilder().CreateChild(_container);
                child.Register(new GameSessionDependencyProvider(child, user, chat));

                var newSession = child.Resolve<GameSession>();
                _openedSessions.Add(userId, newSession);
                _containers.Add(userId, child);

                newSession.HandleCommand(command);
            }
        }

        private void SetTimer()
        {

            double interval = 5.0 * 60 * 1000;
            _timer = new Timer(interval);
            _timer.Elapsed += Timer_Elapsed;

            _timer.Start();

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (var session in _openedSessions)
            {
                if (session.Value.IsNeedToClose)
                {
                    _sessionCountEditor.Remove();
                    _openedSessions.Remove(session.Key);
                }
            }
        }

        private GameUser GetUser(string userID)
        {
            var user = _repositoryShell.GetAll<GameUser>().FirstOrDefault(u => u.Login == userID);

            if (user == default)
            {
                user = CreateUser(userID);
            }

            return user;
        }

        private GameUser CreateUser(string userID)
        {

            var user = new GameUser();
            user.Login = userID;
            //try-exception?
            _repositoryShell.AddOrUpdate(user);

            return user;

        }

    }
}
