using FluentNHibernate.Cfg;
using System.Collections.Generic;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using Core.DBInteraction.Mappings;

namespace Core.DBInteraction
{
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
}
