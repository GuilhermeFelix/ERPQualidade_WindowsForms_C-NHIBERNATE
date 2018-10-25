using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate_PostGreSQLDAL.Entities;

namespace NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_xmediadecadaamostraMap : ClassMap<Capabilidade_xmediadecadaamostra>
    {
        public Capabilidade_xmediadecadaamostraMap()
        {
            Id(f => f.id);
            Map(f => f.idmodelo);
            Map(f => f.x1);
            Map(f => f.x2);
            Map(f => f.x3);
            Map(f => f.x4);
            Map(f => f.x5);
            Map(f => f.x6);
            Map(f => f.x7);
            Map(f => f.x8);
            Map(f => f.x9);
            Map(f => f.x10);
            Map(f => f.x11);
            Map(f => f.x12);
            Map(f => f.x13);
            Map(f => f.x14);
            Map(f => f.x15);
            Map(f => f.x16);
            Map(f => f.x17);
            Map(f => f.x18);
            Map(f => f.x19);
            Map(f => f.x20);
            Map(f => f.x21);
            Map(f => f.x22);
            Map(f => f.x23);
            Map(f => f.x24);
            Map(f => f.x25);
            Table("capabilidade_xmediadecadaamostra");
        }
    }
}
