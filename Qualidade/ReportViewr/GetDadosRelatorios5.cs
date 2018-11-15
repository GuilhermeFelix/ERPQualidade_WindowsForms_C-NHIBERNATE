using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qualidade_NHibernate_PostGreSQLDAL;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;


namespace Qualidade.ReportViewr
{
    class GetDadosRelatorios5
    {
        public GetDadosRelatorios5(string _idmodelo)
        {
            this.Idmodelo = _idmodelo;
            BuscarDados();

        }
        private string idmodelo;
        public IList<Capabilidade_desvios> todosindicadores = new List<Capabilidade_desvios>();
        public IList<DadosRelatorioCapabilidade5> listadeindicadores = new List<DadosRelatorioCapabilidade5>();
        public string Idmodelo { get => idmodelo; set => idmodelo = value; }

        private void BuscarDados()
        {
            //Buscar indicadores do respectivo modelo
            RepositoryCapabilidade_desvios dao = new RepositoryCapabilidade_desvios();

            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())
            {
                if (Idmodelo == item.idmodelo)
                {

                    DadosRelatorioCapabilidade5 dadosRelatorio = new DadosRelatorioCapabilidade5();
                    dadosRelatorio.Modelo = item.idmodelo;
                    dadosRelatorio.Varianciax = item.varianciax;
                    dadosRelatorio.Varianciar = item.varianciar;
                    dadosRelatorio.DesvioPadraox = item.desviopadraox;
                    dadosRelatorio.DesvioPadraor = item.desviopadraor;
                    dadosRelatorio.DesvioAmostragemRbd2 = item.desvioamostragemrbd2;
                    dadosRelatorio.DesvioAmostragemA2rb = item.desvioamostragema2rb;
                    dadosRelatorio.DesvioAmostragemVariacao6Sigma = item.desvioamostragemvariacao;
                    listadeindicadores.Add(dadosRelatorio); 
                    
                }
            
            }  
        }
    }
}
