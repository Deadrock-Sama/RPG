using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class WandMapping : SubclassMap<Wand>
    {
        public WandMapping()
        {
            Table("Wands");
            KeyColumn("Id");

        }
    }
}
