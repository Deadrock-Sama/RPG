using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Amulets
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
