using RPG.DBInteraction.Mappings;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Materials
{
    public class Material : DbEntity, IInventoryItem
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

    }

}
