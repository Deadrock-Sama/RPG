using Castle.MicroKernel.ModelBuilder.Inspectors;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using System.Linq;

namespace RPG.Components.Containers
{
    public class ContainerBuilder
    {
        public IWindsorContainer Create()
        {
            var container = new WindsorContainer();

            var propertyResolver = container.Kernel.ComponentModelBuilder.Contributors
                .OfType<PropertiesDependenciesModelInspector>()
                .Single();

            container.Kernel.ComponentModelBuilder.RemoveContributor(propertyResolver);
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel, true));

            container.Register(Component.For<IWindsorContainer,WindsorContainer>()
                    .Instance(container));

            return container;
        }

        public IWindsorContainer CreateChild(IWindsorContainer parrent)
        {
            var child = Create();
            parrent.AddChildContainer(child);
            return child;
        }

    }
}
