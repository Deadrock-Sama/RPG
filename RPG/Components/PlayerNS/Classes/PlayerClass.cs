using FluentNHibernate.Mapping;
using RPG.Components.PlayerNS.Characteristics;
using RPG.DBInteraction.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.PlayerNS.Classes
{
    public class PlayerClass : DbEntity, IPlayerClass
    {
        public virtual StatsBonus Stats { get; set; }
    }
    public class PlayerClassMapping : ClassMap<PlayerClass>
    {
        public PlayerClassMapping()
        {
            Id(e => e.Id);    
            References(e => e.Stats).Cascade.AllDeleteOrphan()
                .Not.LazyLoad();
            
        }
    }

}
