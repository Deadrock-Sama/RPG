using Core.DBInteraction;
using Core.PlayerNS;
using Core.Users;
using System.Collections.Generic;
using System.Linq;

namespace TelegramAPI.TelegramBotNS
{
    public class GameSession
    {

        private IGameComponent _currentComponent;
        private readonly Dictionary<string, IGameComponent> _gameComponents = new();
        private User _User;
        private Player _Player;
        private readonly RepositoryShell _Repo; 

        public GameSession(IEnumerable<IGameComponent> components, string userID, RepositoryShell repo)
        {
            _Repo = repo;
            SetUser(userID);
            SetPlayer();
            SetComponents(components);
            SetCurrentComponent();
        }


        void SetUser(string userID)
        {
            _User = _Repo.GetAll<User>().FirstOrDefault(u => u.Login == userID);

            if (_User == default(User))
            {

                CreateUser(userID);
                
            }
        
        }

        void CreateUser(string userID)
        {

            _User = new User();
            _User.Login = userID;

            _Repo.AddOrUpdate(_User);

        }

        void SetPlayer()
        {
            _Player = _Repo.GetAll<Player>().FirstOrDefault(c => c.User == _User);


            if (_Player == default(Player))
            {
                CreatePlayer();
            }
        }

        void CreatePlayer()
        { 
            _currentComponent = _gameComponents.GetValueOrDefault("/start");
        }

        void SetCurrentComponent()
        {
            //можно реализовать сохранение и получение компонента из БД

            if (_currentComponent == null) {
                _currentComponent = _gameComponents.GetValueOrDefault("/start");
                _currentComponent.SendStartMessage();
            }

            
        }
       
        void SetComponents(IEnumerable<IGameComponent> components)
        {
            foreach (var component in components)
            {
                _gameComponents.Add(component.TranslationCommand, component);
            }
        }

        public void HandleCommand(string command)
        {
            if (_gameComponents.ContainsKey(command))
            {
                if (_currentComponent.IsAnotherComponentAvailable(command))
                {
                    _currentComponent = _gameComponents[command];
                }
            }
            if (_currentComponent.IsComponentAvailable())
                _currentComponent.HandleCommand(command);
            else
            {
                _currentComponent = null;
                SetCurrentComponent();
            }
        }
    }
}
