using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate_PostGreSQLDAL.Entities;

namespace NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_limitesecapacidadesMap : ClassMap<Capabilidade_limitesecapacidades>
    {
        public Capabilidade_limitesecapacidadesMap()
        {
            Id(f => f.id);
            Map(f => f.idmodelo);
            Map(f => f.limitemediax);
            Map(f => f.limitemedialscx);
            Map(f => f.limitemedialicx);
            Map(f => f.limitelscr);
            Map(f => f.limiteamplitude);
            Map(f => f.cp);
            Map(f => f.cpu);
            Map(f => f.cpl);
            Map(f => f.cpk);
            Table("capabilidade_limitesecapacidades");
        }
    }
}
