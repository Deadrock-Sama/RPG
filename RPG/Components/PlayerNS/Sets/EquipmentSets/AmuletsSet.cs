using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets;
using RPG.Components.PlayerNS.Sets;

namespace RPG.Components.PlayerNS.Sets.EquipmentSets
{
    public class AmuletsSet : ISet
    {
        private readonly IStatsController _Ring;
        private readonly IStatsController _Necklace;
        private readonly IStatsController _Earring;
        private readonly IStatsController _Bracelet;

        public StatsBonus StatsBonus => recieveStatsBonus();

        public AmuletsSet(Ring ring, Necklace necklace, Earring earring, Bracelet bracelet)
        {
            _Ring = ring.Stats;
            _Necklace = necklace.Stats;
            _Earring = earring.Stats;
            _Bracelet = bracelet.Stats;
        }


        private StatsBonus recieveStatsBonus()
        {
            var bonus = new StatsBonus();
            bonus = bonus + _Ring + _Necklace + _Earring + _Bracelet;

            return bonus;
        }
    }
}
