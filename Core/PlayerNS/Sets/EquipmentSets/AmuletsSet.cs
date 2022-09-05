using Core.PlayerNS.CharacteristicsNS;
using Core.PlayerNS.InventoryNS.Equipment.Amulets;

namespace Core.PlayerNS.Sets.EquipmentSets
{
    public class AmuletsSet : ISet
    {
        public StatsBonus StatsBonus => RecieveStatsBonus();

        private readonly IStatsController _ring;
        private readonly IStatsController _necklace;
        private readonly IStatsController _earring;
        private readonly IStatsController _bracelet;

        public AmuletsSet(Ring ring, Necklace necklace, Earring earring, Bracelet bracelet)
        {
            _ring = ring.Stats;
            _necklace = necklace.Stats;
            _earring = earring.Stats;
            _bracelet = bracelet.Stats;
        }


        private StatsBonus RecieveStatsBonus()
        {
            var bonus = new StatsBonus();
            bonus = bonus + _ring + _necklace + _earring + _bracelet;

            return bonus;
        }
    }
}
