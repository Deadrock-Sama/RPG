using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Components.PlayerComponent
{
    public class PlayerRepository
    {

        public List<PlayerBasicInfo> BasicInfos => Players.Select(p => p.Info).ToList();

        private List<Player> Players { get; }


        public PlayerRepository()
        {
            Players = new List<Player>() { 
                new Player("Deadrock"),
                new Player("Felto"),
                new Player("Dextevir")   
            };
 
        }

        public Player GetPlayerByInfo(PlayerBasicInfo info)
        {
            return Players.FirstOrDefault(p => p.Info == info);
        }

    }
}
