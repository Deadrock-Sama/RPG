using RPG.Components.Menus;
using System;
using System.Linq;

namespace RPG
{
    public class ConsoleMenuShower :IShowing
    {
        private bool _isMenuOpen;

        private readonly IMenu _Menu;
        private readonly ConsoleManager _consoleManager;

        public ConsoleMenuShower(IMenu mainMenu, ConsoleManager consoleManager)
        {
            _Menu = mainMenu;
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


            if (numb >= _Menu.MenuItems.Count)
                return;


            _Menu.MenuItems[numb].Open();

            

            _isMenuOpen = false;
        }

        public void Show()
        {
            string msg = string.Join(Environment.NewLine, _Menu.MenuItems.Select(i => $"{_Menu.MenuItems.IndexOf(i)}. {i.Name}"));
            _consoleManager.ShowAndReadKey(msg);

            _isMenuOpen = true;
        }
    }
}
