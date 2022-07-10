using RPG.Components.PlayerNS.Sets;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.PlayerNS.Characteristics
{
    public class StatsBonus : IStatsController
    {
        public double XPMultiplier { get; set; }
        public double MPMultiplier { get; set; }
        public double HPMultiplier { get; set; }
        public int XPBonus { get; set; }
        public int HPBonus { get; set; }
        public int MPBonus { get; set; }

        public StatsBonus(double XPMultiplier, double MPMultiplier, double HPMultiplier, int XPBonus, int MPBonus, int HPBonus)
        {
            this.XPMultiplier = XPMultiplier;
            this.MPMultiplier = MPMultiplier;
            this.HPMultiplier = HPMultiplier;
            this.XPBonus = XPBonus;
            this.HPBonus = HPBonus;
            this.MPBonus = MPBonus;
        }
        public StatsBonus(IStatsController stats)
        {
            this.XPMultiplier = stats.XPMultiplier;
            this.MPMultiplier = stats.MPMultiplier;
            this.HPMultiplier = stats.HPMultiplier;
            this.XPBonus = stats.XPBonus;
            this.HPBonus = stats.HPBonus;
            this.MPBonus = stats.MPBonus;
        }

        public static StatsBonus operator +(StatsBonus statsBonus1, IStatsController statsBonus2)
        {
            var bonus = new StatsBonus(statsBonus1);
            bonus.HPMultiplier += (statsBonus2.HPMultiplier - 1);
            bonus.MPMultiplier += (statsBonus2.MPMultiplier - 1);
            bonus.XPMultiplier += (statsBonus2.XPMultiplier - 1);
            bonus.HPBonus += statsBonus2.HPBonus;
            bonus.MPBonus += statsBonus2.MPBonus;
            bonus.XPBonus += statsBonus2.XPBonus;

            return bonus;
        }

        public static StatsBonus operator +(StatsBonus statsBonus1, StatsBonus statsBonus2)
        {
            var bonus = new StatsBonus(statsBonus1);
            bonus.HPMultiplier += (statsBonus2.HPMultiplier - 1);
            bonus.MPMultiplier += (statsBonus2.MPMultiplier - 1);
            bonus.XPMultiplier += (statsBonus2.XPMultiplier - 1);
            bonus.HPBonus += statsBonus2.HPBonus;
            bonus.MPBonus += statsBonus2.MPBonus;
            bonus.XPBonus += statsBonus2.XPBonus;

            return bonus;
        }

        public static StatsBonus operator *(StatsBonus statsBonus1, StatsBonus statsBonus2)
        {
            var bonus = new StatsBonus(statsBonus1);

            bonus.HPBonus *= (int)statsBonus2.HPMultiplier;
            bonus.MPBonus *= (int)statsBonus2.MPMultiplier;
            bonus.XPBonus *= (int)statsBonus2.XPMultiplier;

            return bonus;
        }

        public StatsBonus()
        {

        }
    }
}
