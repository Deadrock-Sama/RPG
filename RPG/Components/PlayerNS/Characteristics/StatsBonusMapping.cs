using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.Characteristics
{
  
    public class StatsBonusMapping : ClassMap<StatsBonus>
    {
        public StatsBonusMapping()
        {
            Id(e => e.Id);
            Map(e => e.HPMultiplier);
            Map(e => e.MPMultiplier);
            Map(e => e.XPMultiplier);
            Map(e => e.ATKMultiplier);
            Map(e => e.ATKBonus);
            Map(e => e.HPBonus);
            Map(e => e.MPBonus);
            Map(e => e.XPBonus);
            Map(e => e.CritChance);
            Map(e => e.CritDMG);

        }
    }
}
