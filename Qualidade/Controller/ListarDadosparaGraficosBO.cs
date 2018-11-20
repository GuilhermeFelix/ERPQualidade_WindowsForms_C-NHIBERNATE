using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qualidade_NHibernate_PostGreSQLDAL;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;

namespace Qualidade.Controller
{
    public class ListarDadosparaGraficosBO
    {
    public ListarDadosparaGraficosBO()
    {
            this.datas = CarregarDatasdeGeracao();
    }
        public IList<Capabilidade_xmediadecadaamostra> datas;

        public IList<Capabilidade_xmediadecadaamostra> CarregarDatasdeGeracao()
        {
            RepositoryCapabilidade_xmediadecadaamostra dao = new RepositoryCapabilidade_xmediadecadaamostra();
            var data = dao.Consultar().OrderBy(x => x.id).ToList();
            return data;
        }


    }
}
