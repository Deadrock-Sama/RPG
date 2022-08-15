using RPG.Components.PlayerNS.Sets.EquipmentSets;

namespace RPG.Components.PlayerNS.Sets.PlayerSets
{
    public class Characteristics
    {
        public int BaseHP => 100;
        public int BaseMP => 100;
        public int BaseXP => 100;

        public int HP;
        public int MP;
        public int XP;

        public EquipmentStatsSet EquipmentSet { get; set; }

        public Characteristics(EquipmentStatsSet equipmentSet)
        {
            this.EquipmentSet = equipmentSet;

            var bonus = equipmentSet.StatsBonus;

            HP = (int)(BaseHP * bonus.HPMultiplier) + bonus.HPBonus;
            MP = (int)(BaseMP * bonus.MPMultiplier) + bonus.MPBonus;
            XP = (int)(BaseXP * bonus.XPMultiplier) + bonus.XPBonus;
        }

    }
}
