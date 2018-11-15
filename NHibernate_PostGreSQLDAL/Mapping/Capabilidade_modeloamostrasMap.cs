using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;

namespace Qualidade_NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_modeloamostrasMap : ClassMap<Capabilidade_modeloamostras>
    {
        public Capabilidade_modeloamostrasMap()
        {
            Id(f => f.id);
            Map(f => f.idmodelo);
            Map(f => f.inicio);
            Map(f => f.fim);
            Map(f => f.caracteristicachave);
            Map(f => f.maquinafabricacao);
            Map(f => f.especificacaonominal);
            Map(f => f.praticadolicx);
            Map(f => f.lie);
            Map(f => f.praticadolscx);
            Map(f => f.lse);
            Map(f => f.praticadolscr);
            Map(f => f.ferramentacaracteristica1);
            Map(f => f.ferramentacaracteristica2);
            Map(f => f.ferramentacaracteristica3);
            Map(f => f.ferramentacaracteristica4);
            Map(f => f.ferramentacaracteristica5);
            Table("capabilidade_modeloamostras");
        }
    }
}
