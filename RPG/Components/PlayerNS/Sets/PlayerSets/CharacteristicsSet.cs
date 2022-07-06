﻿using RPG.Components.PlayerNS.Inventory.Equipment;

namespace RPG.Components.PlayerNS.Sets.PlayerSets
{
    public class CharacteristicsSet
    {
        public int BaseHP => 100;
        public int BaseMP => 100;
        public int BaseXP => 100;

        public int HP;
        public int MP;
        public int XP;

        public EquipmentSet EquipmentSet { get; set; }

        public CharacteristicsSet(EquipmentSet equipmentSet)
        {
            this.EquipmentSet = equipmentSet;

            var bonus = equipmentSet.recieveStatsBonus();

            HP = (int)(BaseHP * bonus.HPMultiplier) + bonus.HPBonus;
            MP = (int)(BaseMP * bonus.MPMultiplier) + bonus.MPBonus;
            XP = (int)(BaseXP * bonus.XPMultiplier) + bonus.XPBonus;
        }

    }
}
