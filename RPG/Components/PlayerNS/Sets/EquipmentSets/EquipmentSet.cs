using RPG.Components.PlayerNS.Characteristics;

namespace RPG.Components.PlayerNS.Sets.EquipmentSets
{
    public class EquipmentSet : ISet
    {
        private readonly ArmorSet _ArmorSet;
        private readonly AmuletsSet _AmuletsSet;
        private readonly WeaponSet _Weapon;

        public StatsBonus StatsBonus => recieveStatsBonus();

        private StatsBonus recieveStatsBonus()
        {
            var amuletsBonus = _AmuletsSet.StatsBonus;
            var armorBonus = _ArmorSet.StatsBonus * amuletsBonus;
            var weaponBonus = _Weapon.StatsBonus;

            var bonus = new StatsBonus();
            bonus = armorBonus + amuletsBonus + weaponBonus;
            return bonus;
        }

    }
}
