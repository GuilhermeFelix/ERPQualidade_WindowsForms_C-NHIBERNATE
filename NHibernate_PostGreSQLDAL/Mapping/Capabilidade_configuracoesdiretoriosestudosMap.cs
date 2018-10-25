using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate_PostGreSQLDAL.Entities;

namespace NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_configuracoesdiretoriosestudosMap : ClassMap<Capabilidade_configuracoesdiretoriosestudos>
    {
        public Capabilidade_configuracoesdiretoriosestudosMap()
        {
            Id(f => f.id);
            Map(f => f.caminho);
            Table("capabilidade_configuracoesdiretoriosestudos");
        }
    }
}
