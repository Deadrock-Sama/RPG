using Castle.MicroKernel.ModelBuilder.Inspectors;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Components.Containers
{
    public class ContainerBuilder
    {
        public WindsorContainer Create()
        {
            var container = new WindsorContainer();

            var propertyResolver = container.Kernel.ComponentModelBuilder.Contributors
                .OfType<PropertiesDependenciesModelInspector>()
                .Single();

            container.Kernel.ComponentModelBuilder.RemoveContributor(propertyResolver);
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel, true));

            container.Register(Component.For<WindsorContainer>()
                    .Instance(container));

            return container;
        }

    }
}
