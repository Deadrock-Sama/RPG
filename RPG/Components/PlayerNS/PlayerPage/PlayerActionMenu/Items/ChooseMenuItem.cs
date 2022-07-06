using System;

namespace RPG.Components.PlayerNS.PlayerPage.PlayerActionMenu.Items
{
    internal class ChooseMenuItem : IPlayerInfoPageMenuItem
    {
        public string Name => "Выбрать";

        public void Open()
        {
            Console.WriteLine("Игра началась");
        }
    }
}
