using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;

namespace Qualidade_NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_ramplitudedecadaamostraMap : ClassMap<Capabilidade_ramplitudedecadaamostra>
    {
        public Capabilidade_ramplitudedecadaamostraMap()
        {
            Id(f => f.id);
            Map(f => f.idmodelo);
            Map(f => f.r1);
            Map(f => f.r2);
            Map(f => f.r3);
            Map(f => f.r4);
            Map(f => f.r5);
            Map(f => f.r6);
            Map(f => f.r7);
            Map(f => f.r8);
            Map(f => f.r9);
            Map(f => f.r10);
            Map(f => f.r11);
            Map(f => f.r12);
            Map(f => f.r13);
            Map(f => f.r14);
            Map(f => f.r15);
            Map(f => f.r16);
            Map(f => f.r17);
            Map(f => f.r18);
            Map(f => f.r19);
            Map(f => f.r20);
            Map(f => f.r21);
            Map(f => f.r22);
            Map(f => f.r23);
            Map(f => f.r24);
            Map(f => f.r25);
            Map(f => f.datadegeracao);
            Table("capabilidade_ramplitudedecadaamostra");
        }
    }
}
