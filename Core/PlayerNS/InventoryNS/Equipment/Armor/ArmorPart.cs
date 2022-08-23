using Core.PlayerNS.CharacteristicsNS;
using RPG.Components.PlayerNS.InventoryNS.Resources.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.PlayerNS.InventoryNS.Equipment.Armor
{

    public class ArmorPart : Equipment, IArmor
    {
        public virtual StatsBonus Stats { get; set; }

        public virtual bool isAbleToWear()
        {
            throw new NotImplementedException();
        }
    }
}
