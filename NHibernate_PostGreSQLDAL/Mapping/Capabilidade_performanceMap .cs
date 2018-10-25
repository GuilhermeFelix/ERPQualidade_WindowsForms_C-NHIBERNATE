using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate_PostGreSQLDAL.Entities;

namespace NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_performanceMap : ClassMap<Capabilidade_performance>
    {
        public Capabilidade_performanceMap()
        {
            Id(f => f.id);
            Map(f => f.idmodelo);
            Map(f => f.mediax);
            Map(f => f.mediaminima);
            Map(f => f.mediamaxima);
            Map(f => f.mediaxb);
            Map(f => f.mediar);
            Map(f => f.variancia);
            Map(f => f.desviopadrao);
            Map(f => f.variacaosixsigma);
            Map(f => f.minimox);
            Map(f => f.maximox);
            Map(f => f.tolerancia);
            Map(f => f.pp);
            Map(f => f.ppu);
            Map(f => f.ppl);
            Map(f => f.ppk);
            Map(f => f.amplitudemaxima);
            Table("capabilidade_performance");
        }
    }
}
