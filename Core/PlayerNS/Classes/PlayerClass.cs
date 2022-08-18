using Core.DBInteraction.Mappings;
using Core.PlayerNS.CharacteristicsNS;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.PlayerNS.Classes
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
