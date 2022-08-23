using FluentNHibernate.Mapping;

namespace Core.PlayerNS.Classes
{
    public class Wizard : PlayerClass
    {
        public override string ToString()
        {
            return "Wizard";
        }
    }

    public class WizardMapping : SubclassMap<Wizard>
    {
        public WizardMapping()
        {
            //Table("Earrings");

            KeyColumn("Id");

        }
    }
}
