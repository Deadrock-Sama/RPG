using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Resources.Potions
{
    public class PotionMapping : SubclassMap<Potion>
    {
        public PotionMapping()
        {
            KeyColumn("Id");
            Map(e => e.Name);
            Map(e => e.Description);
            Map(e => e.EffectsMethod);

        }
    }

}
