using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public class ConsoleMainMenuShower
    {
        private bool _isMenuOpen;

        private readonly MainMenu _mainMenu;
        private readonly ConsoleManager _consoleManager;

        public ConsoleMainMenuShower(MainMenu mainMenu, ConsoleManager consoleManager)
        {
            _mainMenu = mainMenu;
            _consoleManager = consoleManager;
            _consoleManager.KeyPressed += _consoleManager_KeyPressed;
        }

        private void _consoleManager_KeyPressed(ConsoleKey obj)
        {
            if (!_isMenuOpen)
                return;

            var strKey = obj.ToString();
            if (strKey.Length != 2)
                return;
            if (strKey[0] != 'D')
                return;

            int numb;

            if (!int.TryParse($"{strKey[1]}", out numb))
            {
                return;
            }


            if (numb >= _mainMenu.MenuItems.Count)
                return;


            _consoleManager.Show($"Открыт пункт меню {_mainMenu.MenuItems[numb].Name}");

            _isMenuOpen = false;
        }

        public void Show()
        {
            string msg = string.Join(Environment.NewLine, _mainMenu.MenuItems.Select(i => $"{_mainMenu.MenuItems.IndexOf(i)}. {i.Name}"));
            _consoleManager.ShowAndReadKey(msg);

            _isMenuOpen = true;
        }
    }

    public class MainMenu
    {
        public List<IMenuItem> MenuItems { get; }

        public MainMenu()
        {
            MenuItems = new IMenuItem[]
            {
                new ExitMenuItem(),
                new SettingsMenuItem(),
                new StartGameMenuItem(),
            }.ToList();
        }
    }
}
