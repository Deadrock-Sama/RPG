using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Food
{
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
