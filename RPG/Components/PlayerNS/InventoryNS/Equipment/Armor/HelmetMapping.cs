using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Armor
{
    public class HelmetMapping : SubclassMap<Helmet>
    {
        public HelmetMapping()
        {
            Table("Helmet");

            KeyColumn("HelmetID");

        }
    }
}
