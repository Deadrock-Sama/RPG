using Castle.MicroKernel.ModelBuilder.Inspectors;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using System.Linq;

namespace Core.Containers
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

            container.Register(Component.For<IWindsorContainer, WindsorContainer>()
                    .Instance(container));

            return container;
        }

        public IWindsorContainer CreateChild(IWindsorContainer parent)
        {
            var child = Create();
            parent.AddChildContainer(child);
            return child;
        }

    }
}
