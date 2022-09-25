using Castle.MicroKernel.Registration;
using Core.Containers;
using Core.DBInteraction;
using ObjectsCreator.MVVM.Models;
using System.Collections.Generic;

namespace ObjectsCreator
{
    internal class ObjectsCreatorDependencyProvider : IDependencyProvider
    {

        private readonly IRepositoryShell _repository;

        public ObjectsCreatorDependencyProvider(IRepositoryShell repository)
        {
            _repository = repository;
        }

        public IEnumerable<IRegistration> GetRegistrations()
        {

            yield return Component.For<IRepositoryShell, RepositoryShell>()
               .Instance(_repository);

            yield return Component.For<AppNavigator>();

            yield return Component.For<DefaultWindow>();

            yield return Component.For<MainContentViewModel>();

            yield return Component.For<AuthorizationViewModel>();
            
            yield return Component.For<EditingCharacteristicsViewModel>();

            yield return Component.For<ObjectTablesViewModel>();

            yield return Component.For<RegistrationViewModel>();

        }
    }
}
