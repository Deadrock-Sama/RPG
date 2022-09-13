using Castle.MicroKernel.Registration;

namespace Core.Containers
{
    public interface IDependencyProvider
    {
        IEnumerable<IRegistration> GetRegistrations();
    }

}
