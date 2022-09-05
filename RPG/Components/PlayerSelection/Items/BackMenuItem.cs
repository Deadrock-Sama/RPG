using RPG.Components.PlayerNS.PlayerPage.PlayerActionMenu.Items;
using RPG.Navigation;

namespace RPG.Components.PlayerSelection.Items
{
    internal class BackMenuItem : IPlayerMenuItem, IPlayerInfoPageMenuItem
    {
        public string Name => "Назад";
     
        private readonly AppNavigator _navigator;
        
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
