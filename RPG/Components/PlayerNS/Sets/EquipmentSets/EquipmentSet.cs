using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.Inventory.Equipment.Sets;
using RPG.Components.PlayerNS.Inventory.Equipment.Weapons;
using RPG.Components.PlayerNS.Sets.EquipmentSets;

namespace RPG.Components.PlayerNS.Inventory.Equipment
{
    public class EquipmentSet : ISet
    {
        private readonly ArmorSet _ArmorSet;
        private readonly AmuletsSet _AmuletsSet;
        private readonly WeaponSet _Weapon;

        public StatsBonus recieveStatsBonus()
        {
            var amuletsBonus = _AmuletsSet.recieveStatsBonus();
            var armorBonus = _ArmorSet.recieveStatsBonus() * amuletsBonus;
            var weaponBonus = _Weapon.recieveStatsBonus();

            var bonus = new StatsBonus();
            bonus = armorBonus + amuletsBonus + weaponBonus;
            return bonus;
        }

    }
}
