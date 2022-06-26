using RPG.Components.PlayerComponent;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.Menus.PlayerMenu.Items
{
    internal class PlayerMenuItem : IMenuItem
    {
        private readonly Player _player;
        private readonly string _name;
        public string Name  => _name; 

        public void Open()
        {
            Console.WriteLine($"Вы выбрали игрока {Name}") ;
        }

        public PlayerMenuItem(Player player)
        {
            _player = player;
            _name = player.Name;
        }
    }
}
