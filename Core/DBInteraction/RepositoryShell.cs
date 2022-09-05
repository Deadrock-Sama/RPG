using System.Collections.Generic;
using NHibernate;
using System.Linq;
using NHibernate.Linq;
using Core.DBInteraction.Mappings;

namespace Core.DBInteraction
{
    public class RepositoryShell : IRepositoryShell
    {
        private readonly ISessionFactory _sessionFactory;

        public RepositoryShell()
        {
            var connectionString = "Server=localhost;Database=RPG;User ID=postgres;Password=postgres;";
            var mappings = new MappingConfigurator();
            var mappingRegistar = new MappingsRegistrar();

            mappings = mappingRegistar.AddMappings(mappings);

            var dbConfigurator = new DbConfigurator(connectionString, mappings);

            _sessionFactory = dbConfigurator.CreateSessionFactory();
        }

        public RepositoryShell(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }


        public void AddOrUpdate<T>(T item)
        {
            using var session = _sessionFactory.OpenSession();
            using var transaction = session.BeginTransaction();

            session.SaveOrUpdate(item);

            transaction.Commit();

            session.Close();
        }

        public void Add<T>(T item)
        {
            using var session = _sessionFactory.OpenSession();
            using var transaction = session.BeginTransaction();

            session.Save(item);
            transaction.Commit();

            session.Close();
        }
        public void AddWithId(IIdentity item)
        {
            using var session = _sessionFactory.OpenSession();
            using var transaction = session.BeginTransaction();

            session.Save(item, item.Id);
            transaction.Commit();

            session.Close();
        }

        public T Get<T>()
        {
            using var session = _sessionFactory.OpenSession();

            var res = session.Query<T>()
                .FirstOrDefault();

            session.Close();

            return res;
        }
        public List<T> GetAll<T>()
        {

            using var session = _sessionFactory.OpenSession();


            var res = session.Query<T>()
                .ToList();

            session.Close();

            return res;
        }

        public T GetbyId<T>(int id) where T : IIdentity
        {
            using var session = _sessionFactory.OpenSession();
            var res = session.Query<T>()
                .Where(r => r.Id == id)
                .FirstOrDefault();

            session.Close();

            return res;
        }

        public void Delete<T>(T item)
        {
            using var session = _sessionFactory.OpenSession();
            using var transaction = session.BeginTransaction();

            session.Delete(item);
            session.Flush();
            transaction.Commit();

            session.Close();
        }

        public void DeleteAll<T>()
        {
            using var session = _sessionFactory.OpenSession();
            using var transaction = session.BeginTransaction();

            session.Query<T>().Delete();
            session.Flush();
            transaction.Commit();

            session.Close();
        }

        public void Update<T>(T item)
        {
            using var session = _sessionFactory.OpenSession();
            using var transaction = session.BeginTransaction();

            session.Update(item);
            transaction.Commit();

            session.Close();
        }

        public int Count<T>()
        {
            using var session = _sessionFactory.OpenSession();
            var res = session
                .Query<T>()
                .Count();

            session.Close();

            return res;
        }
    }
}
