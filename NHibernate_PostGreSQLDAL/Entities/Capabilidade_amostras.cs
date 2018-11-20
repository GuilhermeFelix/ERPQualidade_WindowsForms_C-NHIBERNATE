using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade_NHibernate_PostGreSQLDAL.Entities
{
    public class Capabilidade_amostras
    {
        public virtual int id {get;set;}
        public virtual string idmodelo { get; set; }
        public virtual string idamostra { get; set; }
        public virtual string ferramentademedicao1 { get; set; }
        public virtual string caracteristica1 { get; set; }
        public virtual string ferramentademedicao2 { get; set; }
        public virtual string caracteristica2 { get; set; }
        public virtual string ferramentademedicao3 { get; set; }
        public virtual string caracteristica3 { get; set; }
        public virtual string ferramentademedicao4 { get; set; }
        public virtual string caracteristica4 { get; set; }
        public virtual string ferramentademedicao5 { get; set; }
        public virtual string caracteristica5 { get; set; }
       
    }
}
