namespace RPG.Components.PlayerNS.Sets
{
    public interface IStatsController
    {
        public double XPMultiplier { get; }
        public double HPMultiplier { get; }
        public double MPMultiplier { get; }

        public int XPBonus { get; }
        public int HPBonus { get; }
        public int MPBonus { get; } 

    
    }
}
