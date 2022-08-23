using Core.DBInteraction.Mappings;
using Core.PlayerNS.Sets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.PlayerNS.CharacteristicsNS
{
    public partial class StatsBonus : DbEntity, IStatsController
    {
        public virtual double XPMultiplier { get; set; }
        public virtual double MPMultiplier { get; set; }
        public virtual double HPMultiplier { get; set; }
        public virtual double ATKMultiplier { get; set; }
        public virtual int XPBonus { get; set; }
        public virtual int HPBonus { get; set; }
        public virtual int MPBonus { get; set; }
        public virtual int ATKBonus { get; set; }

        public virtual double CritChance { get; set; }
        public virtual double CritDMG { get; set; }


        public StatsBonus(double XPMultiplier, double MPMultiplier, double HPMultiplier, double ATKMultiplier, int XPBonus, int MPBonus, int HPBonus, int ATKBonus, double CritChance, double CritDMG)
        {
            this.XPMultiplier = XPMultiplier;
            this.MPMultiplier = MPMultiplier;
            this.HPMultiplier = HPMultiplier;
            this.ATKMultiplier = ATKMultiplier;
            this.XPBonus = XPBonus;
            this.HPBonus = HPBonus;
            this.MPBonus = MPBonus;
            this.ATKBonus = ATKBonus;
            this.CritChance = CritChance;
            this.CritDMG = CritDMG;

        }
        public StatsBonus(IStatsController stats)
        {
            XPMultiplier = stats.XPMultiplier;
            MPMultiplier = stats.MPMultiplier;
            HPMultiplier = stats.HPMultiplier;
            ATKMultiplier = stats.ATKMultiplier;
            XPBonus = stats.XPBonus;
            HPBonus = stats.HPBonus;
            MPBonus = stats.MPBonus;
            ATKBonus = stats.ATKBonus;
            CritChance = stats.CritChance;
            CritDMG = stats.CritDMG;
        }

        public StatsBonus()
        {

        }

        public static StatsBonus operator +(StatsBonus statsBonus1, IStatsController statsBonus2)
        {
            return SummBonuses(statsBonus1, statsBonus2);
        }

        public static StatsBonus operator +(StatsBonus statsBonus1, StatsBonus statsBonus2)
        {
            return SummBonuses(statsBonus1, statsBonus2);
        }

        private static StatsBonus SummBonuses(StatsBonus statsBonus1, IStatsController statsBonus2)
        {

            var bonus = new StatsBonus(statsBonus1);

            bonus.HPMultiplier += statsBonus2.HPMultiplier - 1;
            bonus.MPMultiplier += statsBonus2.MPMultiplier - 1;
            bonus.XPMultiplier += statsBonus2.XPMultiplier - 1;
            bonus.ATKMultiplier += statsBonus2.ATKMultiplier - 1;
            bonus.HPBonus += statsBonus2.HPBonus;
            bonus.MPBonus += statsBonus2.MPBonus;
            bonus.XPBonus += statsBonus2.XPBonus;
            bonus.ATKBonus += statsBonus2.ATKBonus;

            bonus.CritChance += statsBonus2.CritChance;
            bonus.CritDMG += statsBonus2.CritDMG;

            return bonus;
        }

        public static StatsBonus operator *(StatsBonus statsBonus1, StatsBonus statsBonus2)
        {
            var bonus = new StatsBonus(statsBonus1);

            bonus.HPBonus *= (int)statsBonus2.HPMultiplier;
            bonus.MPBonus *= (int)statsBonus2.MPMultiplier;
            bonus.XPBonus *= (int)statsBonus2.XPMultiplier;
            bonus.ATKBonus *= (int)statsBonus2.ATKMultiplier;

            return bonus;
        }
    }
}
