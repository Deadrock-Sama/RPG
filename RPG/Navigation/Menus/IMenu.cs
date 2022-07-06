using RPG.Components.MainMenuNS.Items;
using System.Collections.Generic;

namespace RPG.Components.Menus
{
    public interface IMenu
    {
        List<IMenuItem> MenuItems { get; }

    }
}
