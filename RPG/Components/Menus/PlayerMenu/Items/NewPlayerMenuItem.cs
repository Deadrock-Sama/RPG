using System;

namespace RPG.Components.Menus.PlayerMenu.Items
{
    internal class NewPlayerMenuItem : IPlayerMenuItem
    {
 
        public string Name => "Новый игрок";

        public void Open()
        {
            Console.WriteLine("Вы создали нового игрока");
        }
    }
}
