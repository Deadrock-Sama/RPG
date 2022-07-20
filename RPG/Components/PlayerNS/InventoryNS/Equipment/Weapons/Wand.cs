using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class Wand : Weapon
    {
    }

    public class WandMapping : ClassMap<Wand>
    {
        public WandMapping()
        {
            Id(e => e.Id);
            Map(e => e.Name);
            Map(e => e.Description);
            Map(e => e.XPMultiplier);
            Map(e => e.HPMultiplier);
            Map(e => e.MPMultiplier);
            Map(e => e.XPBonus);
            Map(e => e.HPBonus);
            Map(e => e.MPBonus);

        }
    }
}
