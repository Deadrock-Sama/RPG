﻿using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.Inventory.Equipment.Amulets;
using RPG.Components.PlayerNS.Sets;
using RPG.Components.PlayerNS.Sets.EquipmentSets;

namespace RPG.Components.PlayerNS.Inventory.Equipment.Sets
{
    public class AmuletsSet : ISet
    {
        private readonly IStatsController  _Ring;
        private readonly IStatsController _Necklace;
        private readonly IStatsController _Earring;
        private readonly IStatsController _Bracelet;

        public AmuletsSet(Ring ring, Necklace necklace, Earring earring, Bracelet bracelet)
        {
            _Ring = ring;
            _Necklace = necklace;
            _Earring = earring;
            _Bracelet = bracelet;
        }

        public StatsBonus recieveStatsBonus()
        {
            var bonus = new StatsBonus();
            bonus = bonus + _Ring + _Necklace + _Earring + _Bracelet;
           
            return bonus;
        }
    }
}
