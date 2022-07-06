using Castle.MicroKernel.Registration;
using Castle.Windsor;
using RPG.Components.Containers;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Containers
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
