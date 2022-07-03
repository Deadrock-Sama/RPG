using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.Menus.PlayerInfoPageComponent
{
    internal class PlayerInfoPageShower : ConsoleMenuShower
    {
        private PlayerInfoPage _playerInfoPage;
        private AppNavigator _navigator;

        public PlayerInfoPageShower(PlayerInfoPage PlayerInfoPage, ConsoleManager consoleManager, AppNavigator navigator) : base(PlayerInfoPage, consoleManager)
        {
            _playerInfoPage = PlayerInfoPage;
            _navigator = navigator;
        }

        public override void Show()
        {
            _playerInfoPage.ShowBasicInfo();
            base.Show();
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
