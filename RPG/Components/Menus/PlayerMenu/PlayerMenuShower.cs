using System;

namespace RPG.Components.Menus.PlayerMenu
{
    public class PlayerMenuShower : ConsoleMenuShower
    {
        private AppNavigator _navigator;

        public PlayerMenuShower(PlayerMenu playerMenu, ConsoleManager consoleManager, AppNavigator navigator) : base(playerMenu, consoleManager)
        {
            _navigator = navigator;//?
        }

        protected override void _consoleManager_KeyPressed(ConsoleKey obj)
        {
            base._consoleManager_KeyPressed(obj);

            if (obj == ConsoleKey.Escape)
            {
                _navigator.Back();
            }

        }
    }
}
