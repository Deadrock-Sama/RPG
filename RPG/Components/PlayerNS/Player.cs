using RPG.Components.PlayerNS.Classes;
using RPG.Components.PlayerNS.Inventory.Equipment;
using RPG.Components.PlayerNS.PlayerPage.PlayerInfo;
using RPG.Components.PlayerNS.Sets.PlayerSets;

namespace RPG.Components.PlayerNS
{

    public class Player
    {

        public PlayerBasicInfo Info { get; set; }
        public IPlayerClass PlayerClass { get; set; }
        public EquipmentSet Equipment { get; set; }
        public CharacteristicsSet  CharacteristicsSet { get; set; }
        public SkillsSet SkillsSet { get; set; }
        public Player(string name)
        {
            Info = new PlayerBasicInfo { Name = name };
        }

    }
}
