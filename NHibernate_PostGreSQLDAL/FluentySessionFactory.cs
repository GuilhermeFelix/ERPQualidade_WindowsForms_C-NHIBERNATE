using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate_PostGreSQLDAL
{
    class FluentySessionFactory
    {
        private static string ConnectionString = "Server = localhost; port = 5432; User Id=postgres; Password =12345678; Database = erpqualidade";
        private static ISessionFactory session;

        public static ISessionFactory CriarSession()
        {
            if (session != null)
                return session;

                IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnectionString);
                var configMap = Fluently.Configure().Database(configDB).Mappings(f => f.FluentMappings.AddFromAssemblyOf<Mapping.Capabilidade_modeloamostrasMap>());
                session = configMap.BuildSessionFactory();    
                return session;
        }

        public static ISession AbrirSession()
        {
            return CriarSession().OpenSession();

        }


    }
}
