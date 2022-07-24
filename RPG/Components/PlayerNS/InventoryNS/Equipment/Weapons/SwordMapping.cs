using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class SwordMapping : SubclassMap<Sword>
    {
        public SwordMapping()
        {
            Table("Swords");
            KeyColumn("SwordID");

        }
    }
}
