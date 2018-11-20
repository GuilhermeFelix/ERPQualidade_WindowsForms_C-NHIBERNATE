using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;

namespace Qualidade_NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_amostrasMap : ClassMap<Capabilidade_amostras>
    {
        public Capabilidade_amostrasMap()
        {
            Id(f => f.id);
            Map(f => f.idmodelo);
            Map(f => f.idamostra);
            Map(f => f.ferramentademedicao1);
            Map(f => f.caracteristica1);
            Map(f => f.ferramentademedicao2);
            Map(f => f.caracteristica2);
            Map(f => f.ferramentademedicao3);
            Map(f => f.caracteristica3);
            Map(f => f.ferramentademedicao4);
            Map(f => f.caracteristica4);
            Map(f => f.ferramentademedicao5);
            Map(f => f.caracteristica5);
            Table("capabilidade_amostras");
        }
    }
}
