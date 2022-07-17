using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.PlayerNS.Sets.EquipmentSets
{
    class WeaponSet : ISet
     {
        public IWeapon Weapon { get; set; }

        public WeaponSet(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public StatsBonus recieveStatsBonus()
        {
            var bonus = new StatsBonus(Weapon);
            return bonus;
        }


    }
}
