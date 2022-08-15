using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.Sets;

namespace RPG.Components.PlayerNS.Classes
{
    public interface IPlayerClass 
    {
        public  StatsBonus Stats { get; set; }
    }
}
