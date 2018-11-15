using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qualidade_NHibernate_PostGreSQLDAL;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;


namespace Qualidade.ReportViewr
{
    class GetDadosRelatorios4
    {
        public GetDadosRelatorios4(string _idmodelo)
        {
            this.Idmodelo = _idmodelo;
            BuscarDados();

        }
        private string idmodelo;
        public IList<Capabilidade_performance> todosindicadores = new List<Capabilidade_performance>();
        public IList<DadosRelatorioCapabilidade3e4> listadeindicadores = new List<DadosRelatorioCapabilidade3e4>();
        public string Idmodelo { get => idmodelo; set => idmodelo = value; }

        private void BuscarDados()
        {
            //Buscar indicadores do respectivo modelo
            RepositoryCapabilidade_performance dao = new RepositoryCapabilidade_performance();

            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())
            {
                if (Idmodelo == item.idmodelo)
                {
                    DadosRelatorioCapabilidade3e4 dadosRelatorio = new DadosRelatorioCapabilidade3e4();
                    dadosRelatorio.Modelo = item.idmodelo;
                    dadosRelatorio.Variancia = item.variancia;
                    dadosRelatorio.Tolerancia = item.tolerancia;
                    dadosRelatorio.Mediaxb = item.mediaxb;
                    dadosRelatorio.MediaMinima = item.mediaminima;
                    dadosRelatorio.MediaMaxima = item.mediamaxima;
                    dadosRelatorio.Mediar = item.mediar;
                    dadosRelatorio.AmplitudeMaxima = item.amplitudemaxima;
                    listadeindicadores.Add(dadosRelatorio);
                }
               
            }  
  
        }
    }
}
