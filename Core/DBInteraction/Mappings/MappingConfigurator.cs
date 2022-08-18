using FluentNHibernate.Cfg;
using System;

namespace Core.DBInteraction.Mappings
{
    public class MappingConfigurator
    {
        public event Action<MappingConfiguration> Mappings;

        public void AddMapping(Action<MappingConfiguration> mapping)
        {
            Mappings += mapping;
        }

        public void Register(MappingConfiguration conf)
        {
            Mappings.Invoke(conf);
        }

    }
}
