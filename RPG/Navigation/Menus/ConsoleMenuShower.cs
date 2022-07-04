using RPG.Components.Navigation;
using System;
using System.Linq;

namespace RPG.Components.Menus
{
    public class ConsoleMenuShower : INavigatorContent
    {
        private bool _isMenuOpen;
        private readonly IMenu _Menu;
        private readonly ConsoleManager _consoleManager;

        public ConsoleMenuShower(IMenu mainMenu, ConsoleManager consoleManager)
        {
            _Menu = mainMenu;
            _consoleManager = consoleManager;

        }

        protected virtual void _consoleManager_KeyPressed(ConsoleKey obj)
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

            if (numb >= _Menu.MenuItems.Count)
                return;

            _Menu.MenuItems[numb].Open();


        }

        public virtual void Show()
        {
            _consoleManager.KeyPressed += _consoleManager_KeyPressed;

            string msg = string.Join(Environment.NewLine, _Menu.MenuItems.Select(i => $"{_Menu.MenuItems.IndexOf(i)}. {i.Name}"));
            _consoleManager.ShowAndReadKey(msg);

            _isMenuOpen = true;
        }

        public void Hide()
        {
            _consoleManager.KeyPressed -= _consoleManager_KeyPressed;
            _isMenuOpen = false;
        }
    }
}
