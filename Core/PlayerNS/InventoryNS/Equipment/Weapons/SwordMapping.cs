using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class SwordMapping : SubclassMap<Sword>
    {
        public SwordMapping()
        {
            Table("Swords");
            KeyColumn("Id");

        }
    }
}
