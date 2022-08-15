﻿using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.InventoryNS.Resources.Food;
using RPG.DBInteraction.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class Amulet : Equipment, IAmulet
    {     
        public virtual StatsBonus Stats { get; set; }

        public virtual bool isAbleToWear()
        {
            throw new NotImplementedException();
        }
    }


}
