using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.PlayerComponent
{

    public class Player
    {

        public PlayerBasicInfo Info { get; set; }

        public Player(string name)
        {
            Info = new PlayerBasicInfo { Name = name };
        }

    }
}
