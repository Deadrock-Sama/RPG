using RPG.Components.PlayerNS.PlayerPage.PlayerActionMenu;
using RPG.Components.PlayerNS.PlayerPage.PlayerInfo;
using RPG.Navigation;

namespace RPG.Components.PlayerNS.PlayerPage
{
    public class PlayerPageShower : INavigatorContent
    {
        private readonly PlayerActionMenuShower _menu;
        private readonly PlayerBasicInfoShower _info;

        public PlayerPageShower(PlayerActionMenuShower menu, PlayerBasicInfoShower info)
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
