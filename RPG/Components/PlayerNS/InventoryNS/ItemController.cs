using RPG.DBInteraction.Mappings;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Food
{
    public class ItemController : DbEntity
    {
        public Item Item { get; set; }
        public int Count { get; set; }
    }

}
