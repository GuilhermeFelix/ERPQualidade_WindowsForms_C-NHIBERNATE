﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade_NHibernate_PostGreSQLDAL.Entities
{
    public class Capabilidade_maquinafabricacao
    {
        public virtual int id {get;set;}
        public virtual string maquinafabricacao { get; set; }
        
    }
}
