using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.Menus.PlayerInfoPageComponent.Items
{
    internal class ConfirmMenuItem : IPlayerInfoPageMenuItem
    {
        public string Name => "Подтвердить";

        public void Open()
        {
            Console.WriteLine("Игра началась");
        }
    }
}
