using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade_NHibernate_PostGreSQLDAL.Entities
{
    public class Capabilidade_limitesecapacidades
    {

        public virtual int id { get; set; }
        public virtual string idmodelo { get; set; }
        public virtual string limitemediax { get; set; }
        public virtual string limitemedialscx { get; set; }
        public virtual string limitemedialicx { get; set; }
        public virtual string limitelscr { get; set; }
        public virtual string limiteamplitude { get; set; }
        public virtual string cp { get; set; }
        public virtual string cpu { get; set; }
        public virtual string cpl { get; set; }
        public virtual string cpk { get; set; }
       
    }
}
