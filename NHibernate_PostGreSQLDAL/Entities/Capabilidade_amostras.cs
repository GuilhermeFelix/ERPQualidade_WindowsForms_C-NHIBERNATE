using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate_PostGreSQLDAL.Entities
{
    public class Capabilidade_amostras
    {
        public virtual int id {get;set;}
        public virtual string idmodelo { get; set; }
        public virtual string idamostra { get; set; }
        public virtual string ferramentademedicao { get; set; }
        public virtual string amostra1 { get; set; }
        public virtual string amostra2 { get; set; }
        public virtual string amostra3 { get; set; }
        public virtual string amostra4 { get; set; }
        public virtual string amostra5 { get; set; }
       
    }
}
