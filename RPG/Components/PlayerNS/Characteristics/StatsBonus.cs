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

        public StatsBonus(double XPMultiplier, double MpMultiplier, double HPMultiplier, int XPBonus, int MPBonus, int HPBonus)
        {
            this.XPMultiplier = XPMultiplier;
            this.MPMultiplier = MpMultiplier;
            this.HPMultiplier = HPMultiplier;
            this.XPBonus = XPBonus;
            this.HPBonus = HPBonus;
            this.MPBonus = MPBonus;
        }


        public StatsBonus()
        {

        }
    }
}
