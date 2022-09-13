using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Core.Containers
{
    public static class ContainerExtensions
    {
        public static IWindsorContainer Register(this IWindsorContainer container, IDependencyProvider provider)
        {
            return container.Register(provider.GetRegistrations().ToArray());
        }
        public static IWindsorContainer Register(this IWindsorContainer container, IEnumerable<IRegistration> registrations)
        {
            return container.Register(registrations.ToArray());
        }
    }
}
