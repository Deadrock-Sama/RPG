using Core.DBInteraction;
using Core.PlayerNS;
using Core.Users;
using System;
using System.Collections.Generic;
using TelegramAPI.TelegramBotNS.Components;

namespace TelegramAPI.TelegramBotNS
{
    public class GameSession
    {

        public bool IsNeedToClose => (DateTime.Compare(DateTime.Now, _lastActivity.AddMinutes(15.0)) < 0);

        private DateTime _lastActivity;
        private IGameComponent _currentComponent;
        private readonly Dictionary<string, IGameComponent> _gameComponents = new();
        private readonly User _user;
        private readonly Player _player;
        private readonly RepositoryShell _repositoryShell;

        public GameSession(IEnumerable<IGameComponent> components, User user, RepositoryShell repositoryShell, Player player)
        {
            _repositoryShell = repositoryShell;
            _user = user;
            _player = player;

            if (_player.Info == default)
            {
                CreatePlayer();
            }

            // пересмотреть систему хранения инфы и старта


            SetComponents(components);
            SetCurrentComponent();
        }

        public void HandleCommand(string command)
        {
            _lastActivity = DateTime.Now;

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

        private void CreatePlayer()
        {
            _currentComponent = _gameComponents.GetValueOrDefault("/start");
        }

        private void SetCurrentComponent()
        {
            //можно реализовать сохранение и получение компонента из БД

            if (_player == default || _player.Id == 0)
            {
                _currentComponent = _gameComponents.GetValueOrDefault("/start");
                _currentComponent.SendStartMessage();
            }
            else
            {
                _currentComponent = _gameComponents.GetValueOrDefault("/city");
                _currentComponent.SendStartMessage();
            }


        }

        private void SetComponents(IEnumerable<IGameComponent> components)
        {
            foreach (var component in components)
            {
                _gameComponents.Add(component.TranslationCommand, component);
            }
        }


    }
}
