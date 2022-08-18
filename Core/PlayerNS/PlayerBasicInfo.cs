using Core.DBInteraction.Mappings;

namespace Core.PlayerNS
{

    public class PlayerBasicInfo : DbEntity
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

    }
}
