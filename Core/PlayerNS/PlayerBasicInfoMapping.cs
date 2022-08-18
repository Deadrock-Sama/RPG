using FluentNHibernate.Mapping;

namespace Core.PlayerNS
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
}
