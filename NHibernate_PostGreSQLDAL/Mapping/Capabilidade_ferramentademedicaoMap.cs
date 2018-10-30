using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate_PostGreSQLDAL.Entities;

namespace NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_ferramentademedicaoMap : ClassMap<Capabilidade_ferramentademedicao>
    {
        public Capabilidade_ferramentademedicaoMap()
        {
            Id(f => f.id);
            Map(f => f.ferramentademedicao);
            Table("capabilidade_ferramentademedicao");
        }
    }
}
