using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qualidade_NHibernate_PostGreSQLDAL;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;


namespace Qualidade.ReportViewr
{
    class GetDadosRelatorios7
    {
        public GetDadosRelatorios7(string _idmodelo)
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
                    dadosRelatorio.LimiteMediaLscx = item.limitemedialscx;
                    dadosRelatorio.LimiteMediax = item.limitemediax;
                    dadosRelatorio.LimiteMediaLicx = item.limitemedialicx;
                    dadosRelatorio.LimiteLscr = item.limitelscr;
                    dadosRelatorio.LimiteAmplitude = item.limiteamplitude;
                    dadosRelatorio.DatadeGeracao = item.datadegeracao;
                    listadeindicadores.Add(dadosRelatorio); 
                    
                }
            }  
        }
    }
}
