using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.Inventory.Equipment.Amulets;

namespace RPG.Components.PlayerNS.Inventory.Equipment.Sets
{
    internal class AmuletsSet
    {
        private readonly IAmulet _Ring;
        private readonly IAmulet _Necklace;
        private readonly IAmulet _Earring;
        private readonly IAmulet _Bracelet;

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
            bonus.HPMultiplier = (_Ring.HPMultiplier + _Necklace.HPMultiplier + _Earring.HPMultiplier + _Bracelet.HPMultiplier) - 3;
            bonus.MPMultiplier = (_Ring.MPMultiplier + _Necklace.MPMultiplier + _Earring.MPMultiplier + _Bracelet.MPMultiplier) - 3;
            bonus.XPMultiplier = (_Ring.XPMultiplier + _Necklace.XPMultiplier + _Earring.XPMultiplier + _Bracelet.XPMultiplier) - 3;
            bonus.HPBonus = (_Ring.HPBonus + _Necklace.HPBonus + _Earring.HPBonus + _Bracelet.HPBonus);
            bonus.MPBonus = (_Ring.MPBonus + _Necklace.MPBonus + _Earring.MPBonus + _Bracelet.MPBonus);
            bonus.XPBonus = (_Ring.XPBonus + _Necklace.XPBonus + _Earring.XPBonus + _Bracelet.XPBonus);

            return bonus;
        }
    }
}
