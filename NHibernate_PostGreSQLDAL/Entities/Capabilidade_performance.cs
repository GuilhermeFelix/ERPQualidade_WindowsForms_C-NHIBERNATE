using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade_NHibernate_PostGreSQLDAL.Entities
{
    public class Capabilidade_performance
    {

        public virtual int id { get; set; }
        public virtual string idmodelo { get; set; }
        public virtual string mediax { get; set; }
        public virtual string mediaminima { get; set; }
        public virtual string mediamaxima { get; set; }
        public virtual string mediaxb { get; set; }
        public virtual string mediar { get; set; }
        public virtual string variancia { get; set; }
        public virtual string desviopadrao { get; set; }
        public virtual string variacaosixsigma { get; set; }
        public virtual string minimox { get; set; }
        public virtual string maximox { get; set; }
        public virtual string tolerancia { get; set; }
        public virtual string pp { get; set; }
        public virtual string ppu { get; set; }
        public virtual string ppl { get; set; }
        public virtual string ppk { get; set; }
        public virtual string amplitudemaxima { get; set; }

    }
}
