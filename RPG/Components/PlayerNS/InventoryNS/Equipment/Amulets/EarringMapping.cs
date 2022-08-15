using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class EarringMapping : SubclassMap<Earring>
    {
        public EarringMapping()
        {
            Table("Earrings");

            KeyColumn("Id");

        }
    }
}
