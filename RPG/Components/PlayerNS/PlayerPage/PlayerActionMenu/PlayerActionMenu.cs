using RPG.Components.MainMenuNS.Items;
using RPG.Components.Menus;
using RPG.Components.PlayerNS.PlayerPage.PlayerActionMenu.Items;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Components.PlayerNS.PlayerPage.PlayerActionMenu
{
    public class PlayerActionMenu : IMenu
    {
        public List<IMenuItem> MenuItems { get; } = new List<IMenuItem>();
        public PlayerActionMenu(IEnumerable<IPlayerInfoPageMenuItem> playerMenuItems)
        {
            MenuItems = playerMenuItems.OfType<IMenuItem>().ToList();
        }
    }
}
