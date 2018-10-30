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
    class Capabilidade_maquinafabricacao_SessionFactory
    {
        //private static readonly string ConnectionString = "Server = localhost; Port = 5432; User Id = postgres; Password = 12345678; Database=erpqualidade";
       
       //Usar para armazenamento no Servidor do UolHost a linha abaixo
        private static readonly string ConnectionString = "Server = erpqualidade.postgres.uhserver.com; Port = 5432; User Id = etecbentao2018; Password = Etecbentao2018@; Database=erpqualidade";
       
        private static ISessionFactory session;

        public static ISessionFactory CriarSession()
        {
            if (session != null)
                return session;

                IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnectionString);
                var configMap = Fluently.Configure().Database(configDB).Mappings(f => f.FluentMappings.AddFromAssemblyOf<Mapping.Capabilidade_maquinafabricacaoMap>());
                session = configMap.BuildSessionFactory();    
                return session;
        }

        public static ISession AbrirSession()
        {
            return CriarSession().OpenSession();

        }


    }
}
