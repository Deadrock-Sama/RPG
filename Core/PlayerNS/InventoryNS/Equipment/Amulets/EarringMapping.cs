using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class EarringMapping : SubclassMap<Earring>
    {
        public EarringMapping()
        {
            Table("Earrings");

            KeyColumn("Id");

        }
    }
}
