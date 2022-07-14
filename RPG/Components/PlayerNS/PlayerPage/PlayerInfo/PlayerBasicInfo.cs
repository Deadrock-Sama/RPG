using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS.PlayerPage.PlayerInfo
{


    public class PlayerBasicInfoMapping : ClassMap<PlayerBasicInfo>
    {

        public PlayerBasicInfoMapping()
        {
            Id(c => c.Id);

            Map(c => c.Name);
            Map(c => c.Description);
        }
    }

    public class PlayerBasicInfo : DbEntity
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

    }
}
