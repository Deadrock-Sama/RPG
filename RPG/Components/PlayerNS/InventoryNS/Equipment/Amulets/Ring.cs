using FluentNHibernate.Mapping;
using System;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class Ring : Amulet
    {


    }

    public class RingMapping : SubclassMap<Ring>
    {
        public RingMapping()
        {
            Table("Necklaces");

            KeyColumn("NecklaceID");

        }
    }

}
