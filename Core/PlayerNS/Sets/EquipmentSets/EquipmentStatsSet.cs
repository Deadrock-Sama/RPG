using Core.PlayerNS.CharacteristicsNS;

namespace Core.PlayerNS.Sets.EquipmentSets
{
    public class EquipmentStatsSet : ISet
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

        public EquipmentStatsSet(ArmorSet ArmorSet, AmuletsSet AmuletsSet, WeaponSet Weapon)
        {
            _ArmorSet = ArmorSet;
            _AmuletsSet = AmuletsSet;
            _Weapon = Weapon;
        }

        public EquipmentStatsSet()
        {

        }

    }
}
