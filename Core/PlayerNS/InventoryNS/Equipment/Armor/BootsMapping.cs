using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Armor
{
    public class BootsMapping : SubclassMap<Boots>
    {
        public BootsMapping()
        {
            Table("Boots");

            KeyColumn("Id");

        }
    }
}
