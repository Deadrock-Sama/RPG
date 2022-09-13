using Core.PlayerNS.CharacteristicsNS;
using RPG.Components.PlayerNS.InventoryNS.Resources.Food;

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class Weapon : Equipment, IWeapon
    {
        public virtual StatsBonus Stats { get; set; }

        public virtual bool IsStartItem { get; set; }

        public virtual bool isAbleToWear()
        {
            throw new NotImplementedException();
        }
    }
}
