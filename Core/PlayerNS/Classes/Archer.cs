using FluentNHibernate.Mapping;

namespace Core.PlayerNS.Classes
{
    public class Archer : PlayerClass
    {
        public override string ToString()
        {
            return "Archer";
        }
    }

    public class ArcherMapping : SubclassMap<Archer>
    {
        public ArcherMapping()
        {

            KeyColumn("Id");

        }
    }
}
