﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate_PostGreSQLDAL.Entities
{
    public class Capabilidade_configuracoesdiretoriosestudos
    {
        public virtual int id {get;set;}
        public virtual string caminho { get; set; }
    }
}
