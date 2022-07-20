using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Potions
{
    public class PotionMapping : ClassMap<Potion>
    {
        public PotionMapping()
        {
            Id(e => e.Id);
            Map(e => e.Name);
            Map(e => e.Description);

        }
    }

}
