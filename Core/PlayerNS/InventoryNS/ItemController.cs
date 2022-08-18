using Core.DBInteraction.Mappings;
using Core.PlayerNS;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Food
{
    public class ItemController : DbEntity
    {
        public virtual Item Item { get; set; }
        public virtual int Count { get; set; }
        public virtual Player Player { get; set; }
    }

}
