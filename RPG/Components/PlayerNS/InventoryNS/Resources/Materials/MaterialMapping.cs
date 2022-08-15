using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Materials
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
