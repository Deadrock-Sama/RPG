using FluentNHibernate.Mapping;
using System;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class Necklace : Amulet
    {



    }

    public class NecklaceMapping : ClassMap<Necklace>
    {
        public NecklaceMapping()
        {
            Id(e => e.Id);
            Map(e => e.Name);
            Map(e => e.Description);
            Map(e => e.XPMultiplier);
            Map(e => e.HPMultiplier);
            Map(e => e.MPMultiplier);
            Map(e => e.XPBonus);
            Map(e => e.HPBonus);
            Map(e => e.MPBonus);

        }
    }

}
