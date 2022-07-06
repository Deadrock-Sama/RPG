using RPG.Components.PlayerNS.PlayerPage.PlayerActionMenu.Items;
using RPG.Navigation;

namespace RPG.Components.PlayerSelection.Items
{
    internal class BackMenuItem : IPlayerMenuItem, IPlayerInfoPageMenuItem
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
