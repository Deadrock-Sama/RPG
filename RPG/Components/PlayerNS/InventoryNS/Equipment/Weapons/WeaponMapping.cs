using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class WeaponMapping : SubclassMap<Weapon>
    {
        public WeaponMapping()
        {
            KeyColumn("Id");
            Map(e => e.Name);
            Map(e => e.Description);
            References(e => e.Stats).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
            Map(e => e.EffectsMethod);

            //UseUnionSubclassForInheritanceMapping();
        }
    }
}
