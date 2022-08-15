using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.InventoryNS.Equipment.Armor;
using RPG.Components.PlayerNS.Sets;

namespace RPG.Components.PlayerNS.Sets.EquipmentSets
{
    public class ArmorSet : ISet
    {
        private readonly IStatsController _Helmet;
        private readonly IStatsController _Chest;
        private readonly IStatsController _Leggins;
        private readonly IStatsController _Boots;

        public StatsBonus StatsBonus => recieveStatsBonus();

        public ArmorSet(Helmet helmet, Chest chest, Leggins leggins, Boots boots)
        {
            _Helmet = helmet.Stats;
            _Chest = chest.Stats;
            _Leggins = leggins.Stats;
            _Boots = boots.Stats;
        }

        private StatsBonus recieveStatsBonus()
        {
            var bonus = new StatsBonus();
            bonus = bonus + _Helmet + _Chest + _Leggins + _Boots;

            return bonus;
        }
    }
}
