using FluentNHibernate.Mapping;
using RPG.DBInteraction.Mappings;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Food
{
    public class InventoryItemController : ItemController
    {
    }

    public class ItemController : DbEntity
    {
        public Item Item { get; set; }
        public int Count { get; set; }
    }

    public class Item : DbEntity
    {
        public virtual string Name { get; set; }
    }


    public class Meal : Item, IInventoryItem
    {
        public virtual string Description { get; set; }
    }

    public class MealMapping : ClassMap<Meal>
    {
        public MealMapping()
        {
            Id(e => e.Id);
            Map(e => e.Name);
            Map(e => e.Description);

        }
    }

}
