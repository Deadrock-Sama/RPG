namespace Core.PlayerNS.Sets
{
    public interface IStatsController
    {
        double XPMultiplier { get; }
        double HPMultiplier { get; }
        double MPMultiplier { get; }
        double ATKMultiplier { get; }

        int XPBonus { get; }
        int HPBonus { get; }
        int MPBonus { get; }
        int ATKBonus { get; }

        double CritChance { get; }
        double CritDMG { get; }


    }
}
