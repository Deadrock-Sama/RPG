using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class RingMapping : SubclassMap<Ring>
    {
        public RingMapping()
        {
            Table("Rings");

            KeyColumn("Id");

        }
    }

}
