using FluentNHibernate.Mapping;
using RPG.DBInteraction.Mappings;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Materials
{
    public class Material : DbEntity, IInventoryItem
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

    }

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
