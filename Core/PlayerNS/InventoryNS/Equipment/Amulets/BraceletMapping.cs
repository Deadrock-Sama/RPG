using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class BraceletMapping : SubclassMap<Bracelet>
    {
        public BraceletMapping()
        {
            Table("Bracelets");

            KeyColumn("Id");

        }
    }
}
