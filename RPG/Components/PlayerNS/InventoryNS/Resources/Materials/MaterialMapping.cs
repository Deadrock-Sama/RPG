using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Materials
{
    public class MaterialMapping : ClassMap<Material>
    {
        public MaterialMapping()
        {
            Id(e => e.Id);
            Map(e => e.Name);
            Map(e => e.Description);

        }
    }

}
