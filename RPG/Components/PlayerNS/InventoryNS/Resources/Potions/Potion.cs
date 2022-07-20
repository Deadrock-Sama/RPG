using RPG.DBInteraction.Mappings;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Potions
{
    public class Potion : DbEntity, IInventoryItem
    {

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

    }

}
