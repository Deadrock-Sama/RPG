using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class Bow : Weapon
    {

    }

    public class BowMapping : ClassMap<Bow>
    {
        public BowMapping()
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
