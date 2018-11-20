using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade_NHibernate_PostGreSQLDAL.Entities
{
    public class Capabilidade_modeloamostras
    {
        public virtual int id {get;set;}
        public virtual string idmodelo { get; set; }
        public virtual DateTime inicio { get; set; }
        public virtual DateTime fim { get; set; }
        public virtual string caracteristicachave { get; set; }
        public virtual string maquinafabricacao { get; set; }
        public virtual string especificacaonominal { get; set; }
        public virtual string praticadolicx { get; set; }
        public virtual string lie { get; set; }
        public virtual string praticadolscx { get; set; }
        public virtual string lse { get; set; }
        public virtual string praticadolscr { get; set; }
        public virtual string ferramentacaracteristica1 { get; set; }
        public virtual string ferramentacaracteristica2 { get; set; }
        public virtual string ferramentacaracteristica3 { get; set; }
        public virtual string ferramentacaracteristica4 { get; set; }
        public virtual string ferramentacaracteristica5 { get; set; }

    }
}
