using Core.PlayerNS;
using RPG.Components.PlayerNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramAPI.Views
{
    public class PlayerView
    {

        private Player _Player;

        public PlayerView(Player player)
        {
            _Player = player;
        }

        public string View { get {

                string representation = $"У вас персонаж {_Player.Info.Name} класса {_Player.PlayerClass}";


                return representation;
            } } 

    }
}
