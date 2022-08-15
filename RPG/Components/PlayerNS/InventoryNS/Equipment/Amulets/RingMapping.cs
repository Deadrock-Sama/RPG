using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets
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
