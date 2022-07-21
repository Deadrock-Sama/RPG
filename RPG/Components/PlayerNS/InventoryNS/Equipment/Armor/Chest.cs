using FluentNHibernate.Mapping;
using System;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Armor
{
    public class Chest : ArmorPart
    {


    }

    public class ChestMapping : SubclassMap<Chest>
    {
        public ChestMapping()
        {
            Table("fwafwad");

            KeyColumn("trrrr");           
        }
    }
}
