using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Resources.Food
{
    public class MealMapping : SubclassMap<Meal>
    {
        public MealMapping()
        {
            KeyColumn("Id");
            Map(e => e.Name);
            Map(e => e.Description);

        }
    }

}
