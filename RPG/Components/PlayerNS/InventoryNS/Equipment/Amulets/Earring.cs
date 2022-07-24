using FluentNHibernate.Mapping;
using System;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class Earring : Amulet
    {


    }

    public class EarringMapping : SubclassMap<Earring>
    {
        public EarringMapping()
        {
            Table("Earrings");

            KeyColumn("EarringID");

        }
    }
}
