using Castle.Windsor;
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

        public string Name  => _name; 

        public void Open()
        {
            _repository.GetPlayerByInfo(_playerInfo);

            var child = new WindsorContainer();
            _container.AddChildContainer(child);

            Console.WriteLine($"Вы выбрали игрока {Name}") ;
        }

        public PlayerMenuItem(PlayerBasicInfo playerInfo, PlayerRepository repository, IWindsorContainer container)
        {
            _name = playerInfo.Name;
            _playerInfo = playerInfo;
            _repository = repository;
            _container = container;
        }
    }
}
