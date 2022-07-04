using RPG.Components.Menus;
using System;

namespace RPG
{
    public class MainMenuShower : ConsoleMenuShower
    {
        public MainMenuShower(MainMenu mainMenu, ConsoleManager consoleManager) : base(mainMenu, consoleManager)
        {
        }

        protected override void _consoleManager_KeyPressed(ConsoleKey obj)
        {
            base._consoleManager_KeyPressed(obj);

            if (obj == ConsoleKey.Escape)
            {
               Environment.Exit(0);
            }

        }

    }
}
