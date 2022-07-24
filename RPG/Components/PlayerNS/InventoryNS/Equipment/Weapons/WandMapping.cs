using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class WandMapping : SubclassMap<Wand>
    {
        public WandMapping()
        {
            Table("Wands");
            KeyColumn("WandID");

        }
    }
}
