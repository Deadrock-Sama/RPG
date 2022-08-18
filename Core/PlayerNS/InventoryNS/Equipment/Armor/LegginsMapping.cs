using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Armor
{
    public class LegginsMapping : SubclassMap<Leggins>
    {
        public LegginsMapping()
        {
            Table("Leggins");

            KeyColumn("Id");
        }
    }
}
