using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate_PostGreSQLDAL.Entities;

namespace NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_amostrasMap : ClassMap<Capabilidade_amostras>
    {
        public Capabilidade_amostrasMap()
        {
            Id(f => f.id);
            Map(f => f.idmodelo);
            Map(f => f.idamostra);
            Map(f => f.ferramentademedicao);
            Map(f => f.amostra1);
            Map(f => f.amostra2);
            Map(f => f.amostra3);
            Map(f => f.amostra4);
            Map(f => f.amostra5);
            
            Table("capabilidade_amostras");
        }
    }
}
