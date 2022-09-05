using Core.DBInteraction.Mappings;
using Core.PlayerNS.InventoryNS;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Food
{
    public class Item : DbEntity, IInventoryItem
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string EffectsMethod { get; set; }
    }

}
