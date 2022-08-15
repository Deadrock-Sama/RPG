using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Armor
{
    public class ArmorPartMapping : SubclassMap<ArmorPart>
    {
        public ArmorPartMapping()
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
