using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Armor
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
