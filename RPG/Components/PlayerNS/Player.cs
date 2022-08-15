using RPG.Components.PlayerNS.Classes;
using RPG.Components.PlayerNS.PlayerPage.PlayerInfo;
using RPG.Components.PlayerNS.Sets.PlayerSets;
using RPG.DBInteraction.Mappings;
using RPG.Components.PlayerNS.InventoryNS;
using RPG.Components.PlayerNS.Sets.EquipmentSets;
using RPG.Components.Users;

namespace RPG.Components.PlayerNS
{

    public class Player : DbEntity
    {
        public virtual PlayerBasicInfo Info { get; set; }
        public virtual PlayerClass PlayerClass { get; set; }
        public virtual EquipmentStatsSet Equipment { get; set; }
        public virtual Sets.PlayerSets.Characteristics CharacteristicsSet { get; set; }
        public virtual SkillsSet SkillsSet { get; set; }

        public virtual User User { get; set; } 

        public virtual Inventory Inventory { get; set; }

        public Player(string name)
        {
            Info = new PlayerBasicInfo { Name = name };
        }
        public Player() {
            //Info = new PlayerBasicInfo { };
        }

    }
}
