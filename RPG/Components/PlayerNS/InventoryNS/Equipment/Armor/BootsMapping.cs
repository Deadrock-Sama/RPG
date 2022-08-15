using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Armor
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
