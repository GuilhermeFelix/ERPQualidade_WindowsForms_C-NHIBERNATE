using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;

namespace Qualidade_NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_desviosMap : ClassMap<Capabilidade_desvios>
    {
        public Capabilidade_desviosMap()
        {
            Id(f => f.id);
            Map(f => f.idmodelo);
            Map(f => f.varianciax);
            Map(f => f.varianciar);
            Map(f => f.desviopadraox);
            Map(f => f.desviopadraor);
            Map(f => f.desvioamostragemrbd2);
            Map(f => f.desvioamostragema2rb);
            Map(f => f.desvioamostragemvariacao);
            Map(f => f.datadegeracao);
            Table("capabilidade_desvios");
        }
    }
}
