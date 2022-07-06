using Castle.Windsor;
using RPG.Components.Containers;
using RPG.Components.PlayerNS;
using RPG.Components.PlayerNS.PlayerPage;
using RPG.Components.PlayerNS.PlayerPage.PlayerInfo;
using RPG.Containers;
using RPG.Navigation;
using System;

namespace RPG.Components.PlayerSelection.Items
{
    internal class PlayerMenuItem : IPlayerMenuItem
    {
        private readonly string _name;
        private readonly PlayerBasicInfo _playerInfo;
        private readonly PlayerRepository _repository;
        private readonly IWindsorContainer _container;
        private AppNavigator _navigator;

        public string Name => _name;

        public void Open()
        {
            var player = _repository.GetPlayerByInfo(_playerInfo);

            var child = new ContainerBuilder().CreateChild(_container);
            child.Register(new PlayerDependencyProvider(player));

            _navigator.Show(child.Resolve<PlayerPageShower>());


            Console.WriteLine($"Вы выбрали игрока {Name}");
        }

        public PlayerMenuItem(PlayerBasicInfo playerInfo, PlayerRepository repository, IWindsorContainer container, AppNavigator navigator)
        {
            _name = playerInfo.Name;
            _playerInfo = playerInfo;
            _repository = repository;
            _container = container;
            _navigator = navigator;
        }
    }
}
