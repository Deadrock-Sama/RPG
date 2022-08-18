using Core.PlayerNS.CharacteristicsNS;
using Core.PlayerNS.InventoryNS.Equipment.Amuclets;
using RPG.Components.PlayerNS.InventoryNS.Resources.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class Amulet : Equipment, IAmulet
    {
        public virtual StatsBonus Stats { get; set; }

        public virtual bool isAbleToWear()
        {
            throw new NotImplementedException();
        }
    }


}
