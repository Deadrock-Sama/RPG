using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.Inventory.Equipment.Armor;

namespace RPG.Components.PlayerNS.Inventory.Equipment.Sets
{
    internal class ArmorSet
    {
        private readonly IArmor _Helmet;
        private readonly IArmor _Chest;
        private readonly IArmor _Leggins;
        private readonly IArmor _Boots;

        public ArmorSet(Helmet helmet, Chest chest, Leggins leggins, Boots boots)
        {
            _Helmet = helmet;
            _Chest = chest;
            _Leggins = leggins;
            _Boots = boots;
        }

        public StatsBonus recieveStatsBonus()
        {
            var bonus = new StatsBonus();
            bonus.HPMultiplier = (_Helmet.HPMultiplier + _Chest.HPMultiplier + _Leggins.HPMultiplier + _Boots.HPMultiplier) - 3;
            bonus.MPMultiplier = (_Helmet.MPMultiplier + _Chest.MPMultiplier + _Leggins.MPMultiplier + _Boots.MPMultiplier) - 3;
            bonus.XPMultiplier = (_Helmet.XPMultiplier + _Chest.XPMultiplier + _Leggins.XPMultiplier + _Boots.XPMultiplier) - 3;
            bonus.HPBonus = (_Helmet.HPBonus + _Chest.HPBonus + _Leggins.HPBonus + _Boots.HPBonus);
            bonus.MPBonus = (_Helmet.MPBonus + _Chest.MPBonus + _Leggins.MPBonus + _Boots.MPBonus);
            bonus.XPBonus = (_Helmet.XPBonus + _Chest.XPBonus + _Leggins.XPBonus + _Boots.XPBonus);

            return bonus;
        }
    }
}
