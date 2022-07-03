using Castle.MicroKernel.Registration;
using Castle.Windsor;
using RPG.Components.Containers;
using RPG.Components.Menus.PlayerInfoPageComponent;
using RPG.Components.Menus.PlayerInfoPageComponent.Items;
using RPG.Components.PlayerComponent;
using System;

namespace RPG.Components.Menus.PlayerMenu.Items
{
    internal class PlayerMenuItem : IPlayerMenuItem
    {
        private readonly string _name;
        private readonly PlayerBasicInfo _playerInfo;
        private readonly PlayerRepository _repository;
        private readonly IWindsorContainer _container;
        private AppNavigator _navigator;

        public string Name  => _name; 

        public void Open()
        {
            var player = _repository.GetPlayerByInfo(_playerInfo);

            var child = new PlayerContainerBuilder(player).Create();
            _container.AddChildContainer(child);

            
            _navigator.Show(child.Resolve<PlayerInfoPageShower>());


            Console.WriteLine($"Вы выбрали игрока {Name}") ;
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
