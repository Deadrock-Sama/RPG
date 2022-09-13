using Core.DBInteraction.Mappings;

namespace Core.PlayerNS.InventoryNS
{
    public class Item : DbEntity, IInventoryItem
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string EffectsMethod { get; set; }
    }

}
