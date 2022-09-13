using FluentNHibernate.Mapping;

namespace Core.PlayerNS.Classes
{
    public class WarriorMapping : SubclassMap<Warrior>
    {
        public WarriorMapping()
        {

            KeyColumn("Id");

        }
    }


}
