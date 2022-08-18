using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Resources.Materials
{
    public class MaterialMapping : SubclassMap<Material>
    {
        public MaterialMapping()
        {
            KeyColumn("Id");
            Map(e => e.Name);
            Map(e => e.Description);

        }
    }

}
