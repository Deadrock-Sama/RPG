using Core.PlayerNS.CharacteristicsNS;
using Core.PlayerNS.InventoryNS.Equipment.Armor;

namespace Core.PlayerNS.Sets.EquipmentSets
{
    public class ArmorSet : ISet
    {
        public StatsBonus StatsBonus => RecieveStatsBonus();

        private readonly IStatsController _helmet;
        private readonly IStatsController _chest;
        private readonly IStatsController _leggins;
        private readonly IStatsController _boots;

        public ArmorSet(Helmet helmet, Chest chest, Leggins leggins, Boots boots)
        {
            _helmet = helmet.Stats;
            _chest = chest.Stats;
            _leggins = leggins.Stats;
            _boots = boots.Stats;
        }

        private StatsBonus RecieveStatsBonus()
        {
            var bonus = new StatsBonus();
            bonus = bonus + _helmet + _chest + _leggins + _boots;

            return bonus;
        }
    }
}
