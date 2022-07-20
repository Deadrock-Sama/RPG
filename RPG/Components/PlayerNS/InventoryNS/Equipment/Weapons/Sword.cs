using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class Sword : Weapon
    {
    }

    public class SwordMapping : ClassMap<Sword>
    {
        public SwordMapping()
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
