using Castle.MicroKernel.Registration;
using System.Collections.Generic;

namespace Core.Containers
{
    public interface IDependencyProvider
    {
        IEnumerable<IRegistration> GetRegistrations();
    }

}
