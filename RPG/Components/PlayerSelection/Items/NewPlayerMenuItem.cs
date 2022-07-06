using System;

namespace RPG.Components.PlayerSelection.Items
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
