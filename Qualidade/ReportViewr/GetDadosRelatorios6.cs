using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qualidade_NHibernate_PostGreSQLDAL;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;


namespace Qualidade.ReportViewr
{
    class GetDadosRelatorios6
    {
        public GetDadosRelatorios6(string _idmodelo)
        {
            this.Idmodelo = _idmodelo;
            BuscarDados();

        }
        private string idmodelo;
        public IList<Capabilidade_limitesecapacidades> todosindicadores = new List<Capabilidade_limitesecapacidades>();
        public IList<DadosRelatorioCapabilidade6e7> listadeindicadores = new List<DadosRelatorioCapabilidade6e7>();
        public string Idmodelo { get => idmodelo; set => idmodelo = value; }

        private void BuscarDados()
        {
            //Buscar indicadores do respectivo modelo
            RepositoryCapabilidade_limitesecapacidades dao = new RepositoryCapabilidade_limitesecapacidades();

            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())
            {
                if (Idmodelo == item.idmodelo)
                {

                    DadosRelatorioCapabilidade6e7 dadosRelatorio = new DadosRelatorioCapabilidade6e7();
                    dadosRelatorio.Modelo = item.idmodelo;
                    dadosRelatorio.Cp = item.cp;
                    dadosRelatorio.Cpu = item.cpu;
                    dadosRelatorio.Cpl = item.cpl;
                    dadosRelatorio.Cpk = item.cpk;
                    listadeindicadores.Add(dadosRelatorio); 
                    
                }
            }  
        }
    }
}
