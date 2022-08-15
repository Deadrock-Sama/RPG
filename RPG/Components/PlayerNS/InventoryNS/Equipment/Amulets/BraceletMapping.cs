using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets
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
