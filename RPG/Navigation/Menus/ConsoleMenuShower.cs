using RPG.ConsoleInteraction;
using RPG.Navigation;
using System;
using System.Linq;

namespace RPG.Components.Menus
{
    public class ConsoleMenuShower : INavigatorContent
    {
        private bool _isMenuOpened;
        private readonly IMenu _menu;
        private readonly ConsoleManager _consoleManager;

        public ConsoleMenuShower(IMenu mainMenu, ConsoleManager consoleManager)
        {
            _menu = mainMenu;
            _consoleManager = consoleManager;

        }

        protected virtual void _consoleManager_KeyPressed(ConsoleKey obj)
        {
            if (!_isMenuOpened)
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

            if (numb >= _menu.MenuItems.Count)
                return;

            _menu.MenuItems[numb].Open();

        }

        public virtual void Show()
        {
            _consoleManager.KeyPressed += _consoleManager_KeyPressed;

            string msg = string.Join(Environment.NewLine, _menu.MenuItems.Select(i => $"{_menu.MenuItems.IndexOf(i)}. {i.Name}"));
            _consoleManager.ShowAndReadKey(msg);

            _isMenuOpened = true;
        }

        public void Hide()
        {
            _consoleManager.KeyPressed -= _consoleManager_KeyPressed;
            _isMenuOpened = false;
        }
    }
}
