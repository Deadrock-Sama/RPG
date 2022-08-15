using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.PlayerNS.Sets.EquipmentSets
{
    public class WeaponSet : ISet
     {
        public IWeapon Weapon { get; set; }

        public StatsBonus StatsBonus => recieveStatsBonus();
        public WeaponSet(IWeapon weapon)
        {
            Weapon = weapon;
        }

        private StatsBonus recieveStatsBonus()
        {
            return Weapon.Stats;
        }


    }
}
