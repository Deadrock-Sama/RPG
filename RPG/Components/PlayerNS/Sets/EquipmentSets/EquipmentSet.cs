using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.Inventory.Equipment.Sets;
using RPG.Components.PlayerNS.Inventory.Equipment.Weapons;

namespace RPG.Components.PlayerNS.Inventory.Equipment
{
    public class EquipmentSet
    {
        private readonly ArmorSet _ArmorSet;
        private readonly AmuletsSet _AmuletsSet;
        private readonly IWeapon _Weapon;

        public StatsBonus recieveStatsBonus()
        {
            var armorBonus = _ArmorSet.recieveStatsBonus();
            var amuletsBonus = _AmuletsSet.recieveStatsBonus();
            
            var bonus = new StatsBonus();
            bonus.HPMultiplier = (armorBonus.HPMultiplier + amuletsBonus.HPMultiplier + _Weapon.HPMultiplier) - 2;
            bonus.MPMultiplier = (armorBonus.MPMultiplier + amuletsBonus.MPMultiplier + _Weapon.MPMultiplier) - 2;
            bonus.XPMultiplier = (armorBonus.XPMultiplier + amuletsBonus.XPMultiplier + _Weapon.XPMultiplier) - 2;
            bonus.HPBonus = ((int)(armorBonus.HPBonus * amuletsBonus.HPMultiplier) + amuletsBonus.HPBonus + _Weapon.HPBonus);
            bonus.MPBonus = ((int)(armorBonus.MPBonus * amuletsBonus.MPMultiplier) + amuletsBonus.MPBonus + _Weapon.MPBonus);
            bonus.XPBonus = ((int)(armorBonus.XPBonus * amuletsBonus.XPMultiplier) + amuletsBonus.XPBonus + _Weapon.XPBonus);

            return bonus;
        }

    }
}
