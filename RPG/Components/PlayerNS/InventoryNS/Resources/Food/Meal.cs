using FluentNHibernate.Mapping;
using RPG.DBInteraction.Mappings;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Food
{
    public class Meal : DbEntity, IInventoryItem
    {

        public string Name { get; set; }
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
