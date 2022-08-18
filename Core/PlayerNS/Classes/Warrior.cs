using FluentNHibernate.Mapping;

namespace Core.PlayerNS.Classes
{
    public class Warrior : PlayerClass
    {
        public override string ToString()
        {
            return "Warrior";
        }
    }

    public class WarriorMapping : SubclassMap<Warrior>
    {
        public WarriorMapping()
        {

            KeyColumn("Id");

        }
    }


}
