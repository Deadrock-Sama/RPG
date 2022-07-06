using RPG.Components.PlayerSelection;
using RPG.Navigation;
using System;

namespace RPG.Components.MainMenuNS.Items
{
    public class StartGameMenuItem : IMainMenuItem
    {
        private AppNavigator _navigator;
        private readonly PlayerMenuShower _playerMenu;

        public string Name => "Старт";


        public StartGameMenuItem(PlayerMenuShower playerMenu, AppNavigator navigator)
        {
            _navigator = navigator;
            _playerMenu = playerMenu;
        }

        public void Open()
        {
            Console.WriteLine($"Открыт пункт меню {Name}");

            _navigator.Show(_playerMenu);

        }
    }
}
