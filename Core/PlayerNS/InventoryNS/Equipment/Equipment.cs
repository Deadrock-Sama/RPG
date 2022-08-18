using Core.PlayerNS.CharacteristicsNS;
using RPG.Components.PlayerNS.InventoryNS.Resources.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.PlayerNS.InventoryNS.Equipment
{
    public class Equipment : Item, IEquipment
    {
        public virtual StatsBonus Stats { get; set; }

        public virtual bool isAbleToWear()
        {
            throw new NotImplementedException();
        }
    }
}
