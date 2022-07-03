using RPG.Components.PlayerComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Components.Menus.PlayerInfoPageComponent
{
    internal class PlayerInfoPage : IMenu
    {
        public List<IMenuItem> MenuItems { get; } = new List<IMenuItem>();
        private PlayerBasicInfoShower _playerBasicInfoShower;

        public void ShowBasicInfo()
        {
            _playerBasicInfoShower.Show();
        }

        public PlayerInfoPage(IEnumerable<IPlayerInfoPageMenuItem> playerMenuItems, PlayerBasicInfoShower playerBasicInfoShower)
        {
            MenuItems = playerMenuItems.OfType<IMenuItem>().ToList();
            _playerBasicInfoShower = playerBasicInfoShower;
        }
    }
}
