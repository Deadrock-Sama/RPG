using Core.PlayerNS.CharacteristicsNS;
using Core.PlayerNS.InventoryNS.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.PlayerNS.Sets.EquipmentSets
{
    public class WeaponSet : ISet
    {
        public IWeapon Weapon { get; set; }
        public StatsBonus StatsBonus => RecieveStatsBonus();

        public WeaponSet(IWeapon weapon)
        {
            Weapon = weapon;
        }

        private StatsBonus RecieveStatsBonus()
        {
            return Weapon.Stats;
        }


    }
}
