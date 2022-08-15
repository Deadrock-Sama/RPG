using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class NecklaceMapping : SubclassMap<Necklace>
    {
        public NecklaceMapping()
        {
            Table("Necklaces");

            KeyColumn("Id");

        }
    }

}
