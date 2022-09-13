using Core.DBInteraction.Mappings;
using Core.PlayerNS;

namespace Core.PlayerNS.InventoryNS
{
    public class ItemController : DbEntity
    {
        public virtual Item Item { get; set; }
        public virtual int Count { get; set; }
        public virtual Player Player { get; set; }
    }

}
