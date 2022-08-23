using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Armor
{
    public class ChestMapping : SubclassMap<Chest>
    {
        public ChestMapping()
        {
            Table("Chests");

            KeyColumn("Id");
        }
    }
}
