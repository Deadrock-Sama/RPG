using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.Menus
{
    public interface IMenu
    {
        List<IMenuItem> MenuItems { get; }

    }
}
