using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Armor
{
    public class HelmetMapping : SubclassMap<Helmet>
    {
        public HelmetMapping()
        {
            Table("Helmet");

            KeyColumn("Id");

        }
    }
}
