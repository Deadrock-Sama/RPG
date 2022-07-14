using RPG.Components.Containers;
using RPG.Components.MainMenuNS;
using RPG.Containers;
using RPG.Navigation;
using NHibernate.Connection;
using System.Configuration;
using FluentNHibernate.Cfg;
using Npgsql;
using System.Collections.Generic;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Mapping;
using System;
using NHibernate;
using System.Linq;
using NHibernate.Linq;
using RPG.Components.PlayerNS;
using RPG.Components.PlayerNS.PlayerPage.PlayerInfo;

namespace RPG
{

    public class DbEntity : IIdentity
    {
        public virtual int Id { get; set; }
    }

    public class TestData : DbEntity
    {
        public virtual string StrField { get; set; }
        public virtual int IntField { get; set; }
    }

    public class TestDataMapping : ClassMap<TestData>
    {
        public TestDataMapping()
        {
            Id(e => e.Id);

            Map(e => e.StrField);
            Map(e => e.IntField);
        }
    }


    public class MappingConfigurator
    {
        public event Action<MappingConfiguration> Mappings;

        public void AddMapping(Action<MappingConfiguration> mapping)
        {
            Mappings += mapping;
        }

        public void Register(MappingConfiguration conf)
        {
            Mappings.Invoke(conf);
        }

    }
    public interface IIdentity
    {
        int Id { get; }
    }
    public interface IRepositoryShell
    {
        T Get<T>();
        T GetbyId<T>(int id) where T : IIdentity;
        List<T> GetAll<T>();
        void Update<T>(T item);
        void Add<T>(T item);
        void AddWithId(IIdentity item);
        void AddOrUpdate<T>(T item);
        void Delete<T>(T item);
        void DeleteAll<T>();
        int Count<T>();
    }
    public class RepositoryShell : IRepositoryShell
    {
        private readonly ISessionFactory _sessionFactory;

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

    public class DbConfigurator
    {
        private readonly string _connectionString;
        private readonly MappingConfigurator _mappingConfigurator;

        public DbConfigurator(string connectionString, MappingConfigurator mappingConfigurator)
        {
            _connectionString = connectionString;
            _mappingConfigurator = mappingConfigurator;
        }

        public ISessionFactory CreateSessionFactory()
        {
            var sf = Fluently.Configure()
                .Mappings(c => _mappingConfigurator.Register(c))
                .ExposeConfiguration(cfg =>
                {
                    cfg.Properties = new Dictionary<string, string>()
                    {
                        { "connection.provider", "NHibernate.Connection.DriverConnectionProvider" },
                        { "connection.connection_string", _connectionString},
                        { "dialect", "NHibernate.Dialect.PostgreSQLDialect" },
                        { "connection.driver_class","NHibernate.Driver.NpgsqlDriver" }
                    };

                    cfg.DataBaseIntegration(x =>
                    {
                        x.LogFormattedSql = true;
                        x.AutoCommentSql = true;
                    });


                    new SchemaUpdate(cfg).Execute(false, true);
                })
                .BuildSessionFactory();

            return sf;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var mappings = new MappingConfigurator();
            mappings.AddMapping(c => c.FluentMappings.Add<PlayerBasicInfoMapping>());
            mappings.AddMapping(c => c.FluentMappings.Add<PlayerMapping>());


            var cs = "Server=localhost;Database=RPG;User ID=postgres;Password=postgres;";

            var dbConfigurator = new DbConfigurator(cs, mappings);
            var sf = dbConfigurator.CreateSessionFactory();
            var repo = new RepositoryShell(sf);


            var container = new ContainerBuilder().Create();
            container.Register(new MainDependencyProvider(repo, sf));

            var playerRepo = container.Resolve<PlayerRepository>();
            playerRepo.CreateNewPlayer("Test Player");


            //Start
            var navigator = container.Resolve<AppNavigator>();
            var mainMenuShower = container.Resolve<MainMenuShower>();
            navigator.Show(mainMenuShower);

            while (true)
            {

            }

        }
    }
}
