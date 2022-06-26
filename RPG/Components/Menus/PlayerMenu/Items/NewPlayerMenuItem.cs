using RPG.Components.PlayerComponent;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.Menus.PlayerMenu.Items
{
    internal class NewPlayerMenuItem : IMenuItem
    {
 
        public string Name => "Новый игрок";

        public void Open()
        {
            Console.WriteLine("Вы создали нового игрока");
        }
    }
}
