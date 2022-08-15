﻿using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Armor
{
    public class ChestMapping : SubclassMap<Chest>
    {
        public ChestMapping()
        {
            Table("Chests");

            KeyColumn("Id");
        }
    }
}
