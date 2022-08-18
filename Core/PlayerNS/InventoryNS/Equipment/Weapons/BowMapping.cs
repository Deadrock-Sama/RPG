using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class BowMapping : SubclassMap<Bow>
    {
        public BowMapping()
        {
            Table("Bows");
            KeyColumn("Id");

        }
    }
}
