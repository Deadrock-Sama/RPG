using RPG.Components.Menus.PlayerActionMenu;
using RPG.Components.Navigation;

namespace RPG.Components.Menus.PlayerInfoPageComponent
{
    public class PlayerActionPageShower : INavigatorContent
    {
        private readonly PlayerActionMenuShower _menu;
        private readonly PlayerInfoShower _info;

        public PlayerActionPageShower(PlayerActionMenuShower menu, PlayerInfoShower info)
        {
            _menu = menu;
            _info = info;
        }

        public void Hide()
        {
            _menu.Hide();
        }

        public void Show()
        {
            _info.Show();
            _menu.Show();
        }
    }
}
