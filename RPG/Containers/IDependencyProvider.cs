using Castle.MicroKernel.Registration;
using System.Collections.Generic;

namespace RPG.Components.Containers
{
    public interface IDependencyProvider
    {
        IEnumerable<IRegistration> GetRegistrations();
    }

}
