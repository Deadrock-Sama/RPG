using RPG.Components.Menus.PlayerMenu;
using System;

namespace RPG
{
    public class StartGameMenuItem : IMenuItem
    {
        public string Name => "Старт"; 

        public void Open()
        {
            Console.WriteLine($"Открыт пункт меню {Name}");

            var cm = new ConsoleManager();

            var menu = new PlayerMenu();
            var menuShower = new ConsoleMenuShower(menu, cm);

            menuShower.Show();

            while (true)
            {

            }
        }
    }
}
