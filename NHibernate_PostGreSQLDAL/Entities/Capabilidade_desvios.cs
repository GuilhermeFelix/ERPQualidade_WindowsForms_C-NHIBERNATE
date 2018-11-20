using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade_NHibernate_PostGreSQLDAL.Entities
{
    public class Capabilidade_desvios
    {
        public virtual int id { get; set; }
        public virtual string idmodelo { get; set; }
        public virtual string varianciax { get; set; }
        public virtual string varianciar { get; set; }
        public virtual string desviopadraox { get; set; }
        public virtual string desviopadraor { get; set; }
        public virtual string desvioamostragemrbd2 { get; set; }
        public virtual string desvioamostragema2rb { get; set; }
        public virtual string desvioamostragemvariacao { get; set; }
        public virtual string datadegeracao { get; set; }
                
    }
}
