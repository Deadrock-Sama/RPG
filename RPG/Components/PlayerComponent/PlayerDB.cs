using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.PlayerComponent
{
    internal class PlayerDB
    {

        public List<Player> Players { get; }


        public PlayerDB()
        {
            Players = new List<Player>() { 
                new Player("Deadrock"),
                new Player("Felto"),
                new Player("Dextevir")   
            };
 
        }

    }
}
