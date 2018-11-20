using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qualidade_NHibernate_PostGreSQLDAL;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;


namespace Qualidade.ReportViewr
{
    class GetDadosRelatorios3
    {
        public GetDadosRelatorios3(string _idmodelo)
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
                    dadosRelatorio.DesvioPadrao = item.desviopadrao;
                    dadosRelatorio.Variacao6Sigma = item.variacaosixsigma;
                    dadosRelatorio.MediaX = item.mediax;
                    dadosRelatorio.Minimox = item.minimox;
                    dadosRelatorio.Maximox = item.maximox;
                    dadosRelatorio.PP = item.pp;
                    dadosRelatorio.PPU = item.ppu;
                    dadosRelatorio.PPL = item.ppl;
                    dadosRelatorio.PPK = item.ppk;
                    dadosRelatorio.DatadeGeracao = item.datadegeracao;
                    listadeindicadores.Add(dadosRelatorio);
                }
               
            }  
  
        }
    }
}
