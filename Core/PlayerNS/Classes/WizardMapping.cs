using FluentNHibernate.Mapping;

namespace Core.PlayerNS.Classes
{
    public class WizardMapping : SubclassMap<Wizard>
    {
        public WizardMapping()
        {

            KeyColumn("Id");

        }
    }
}
