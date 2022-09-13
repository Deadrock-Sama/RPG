using Core.DBInteraction.Mappings;
using Core.PlayerNS.Classes;
using Core.PlayerNS.InventoryNS;
using Core.PlayerNS.Sets.EquipmentSets;
using Core.PlayerNS.Sets.PlayerSets;
using Core.Users;

namespace Core.PlayerNS
{

    public class Player : DbEntity
    {
        public virtual PlayerBasicInfo Info { get; set; }
        public virtual PlayerClass PlayerClass { get; set; }
        public virtual EquipmentStatsSet Equipment { get; set; }
        public virtual Characteristics CharacteristicsSet { get; set; }
        public virtual SkillsSet SkillsSet { get; set; }
        public virtual User User { get; set; }
        public virtual Inventory Inventory { get; set; }

        public Player(User user)
        {
            User = user; 
        }

        public Player(string name)
        {
            Info = new PlayerBasicInfo { Name = name };
        }
        public Player()
        {
            
        }

       

    }
}
