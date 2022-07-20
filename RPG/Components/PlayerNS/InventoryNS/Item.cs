using RPG.DBInteraction.Mappings;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Food
{
    public class Item : DbEntity
    {
        public virtual string Name { get; set; }
    }

}
