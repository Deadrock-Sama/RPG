using RPG.Components.Menus.PlayerInfoPageComponent;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Components.Menus.PlayerActionMenu
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
