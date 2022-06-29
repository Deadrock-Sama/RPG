using System;

namespace RPG.Components.Menus.PlayerMenu.Items
{
    internal class BackMenuItem : IPlayerMenuItem
    {
        private AppNavigator _navigator;

        public string Name => "Назад";

        public BackMenuItem(AppNavigator navigator)
        {
            _navigator = navigator;
        }

        public void Open()
        {
            _navigator.Back();
        }
    }
}
