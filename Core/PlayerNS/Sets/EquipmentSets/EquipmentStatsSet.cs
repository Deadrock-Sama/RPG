using Core.PlayerNS.CharacteristicsNS;

namespace Core.PlayerNS.Sets.EquipmentSets
{
    public class EquipmentStatsSet : ISet
    {
        public StatsBonus StatsBonus => RecieveStatsBonus();

        private readonly ArmorSet _armorSet;
        private readonly AmuletsSet _amuletsSet;
        private readonly WeaponSet _weapon;
        public EquipmentStatsSet(ArmorSet ArmorSet, AmuletsSet AmuletsSet, WeaponSet Weapon)
        {
            _armorSet = ArmorSet;
            _amuletsSet = AmuletsSet;
            _weapon = Weapon;
        }

        public EquipmentStatsSet()
        {

        }

        private StatsBonus RecieveStatsBonus()
        {
            var amuletsBonus = _amuletsSet.StatsBonus;
            var armorBonus = _armorSet.StatsBonus * amuletsBonus;
            var weaponBonus = _weapon.StatsBonus;

            var bonus = new StatsBonus();
            bonus = armorBonus + amuletsBonus + weaponBonus;
            return bonus;
        }

     

    }
}
