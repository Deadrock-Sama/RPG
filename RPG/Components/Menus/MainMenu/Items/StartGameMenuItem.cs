using RPG.Components.Menus.PlayerMenu;
using System;

namespace RPG
{
    public class StartGameMenuItem : IMainMenuItem
    {
        private readonly PlayerMenuShower _playerMenu;

        public string Name => "Старт";


        public StartGameMenuItem(PlayerMenuShower playerMenu)
        {
            _playerMenu = playerMenu;
        }

        public void Open()
        {
            Console.WriteLine($"Открыт пункт меню {Name}");

            _playerMenu.Show();

        }
    }
}
