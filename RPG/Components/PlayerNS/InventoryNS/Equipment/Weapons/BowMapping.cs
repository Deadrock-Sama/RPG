using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons
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
