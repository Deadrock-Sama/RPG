using RPG.Components.MainMenuNS.Items;
using RPG.Components.Menus;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Components.MainMenuNS
{

    public class MainMenu : IMenu
    {
        public List<IMenuItem> MenuItems { get; }

        public MainMenu(IEnumerable<IMainMenuItem> mainMenuItems)
        {
            MenuItems = mainMenuItems.OfType<IMenuItem>().ToList();

        }
    }
}
