using RPG.Components.Menus;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{    public class MainMenu : IMenu
    {
        public List<IMenuItem> MenuItems { get; }

        public MainMenu()
        {
            MenuItems = new IMenuItem[]
            {
                new ExitMenuItem(),
                new SettingsMenuItem(),
                new StartGameMenuItem(),
            }.ToList();
        }
    }
}
