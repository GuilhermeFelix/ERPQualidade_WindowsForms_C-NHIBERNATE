using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate_PostGreSQLDAL.Entities;

namespace NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_caracteristicachaveMap : ClassMap<Capabilidade_caracteristicachave>
    {
        public Capabilidade_caracteristicachaveMap()
        {
            Id(f => f.id);
            Map(f => f.caracteristica);
            Table("capabilidade_caracteristicachave");
        }
    }
}
