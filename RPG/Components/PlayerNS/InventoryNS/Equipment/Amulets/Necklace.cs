using FluentNHibernate.Mapping;
using System;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class Necklace : Amulet
    {



    }

    public class NecklaceMapping : SubclassMap<Necklace>
    {
        public NecklaceMapping()
        {
            Table("Necklaces");

            KeyColumn("NecklaceID");

        }
    }

}
