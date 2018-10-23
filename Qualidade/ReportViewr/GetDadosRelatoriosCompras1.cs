using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate_PostGreSQLDAL;


namespace Qualidade.ReportViewr
{
    class GetDadosRelatoriosCompras1
    {
        public GetDadosRelatoriosCompras1(string _idmodelo)
        {
            this.Idmodelo = _idmodelo;
            BuscarDados();
        }
        private string idmodelo;
        private List<DadosRelatorioCapabilidade1> dadosRelatorioCapabilidade1lista = new List<DadosRelatorioCapabilidade1>();

        public string Idmodelo { get => idmodelo; set => idmodelo = value; }
        public List<DadosRelatorioCapabilidade1> DadosRelatorioCapabilidade1lista { get => dadosRelatorioCapabilidade1lista; set => dadosRelatorioCapabilidade1lista = value; }

        private void BuscarDados()
        {

            RepositoryCapabilidade_modeloamostras dao = new RepositoryCapabilidade_modeloamostras();
            DadosRelatorioCapabilidade1 dadosRelatorio = new DadosRelatorioCapabilidade1();
            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())
            {
                if (Idmodelo == item.idmodelo)
                {
                    
                    dadosRelatorio.Modelo = item.idmodelo;
                    dadosRelatorio.Inicio = item.inicio;
                    dadosRelatorio.Fim = item.fim;
                    dadosRelatorio.CaracteristicaChave = item.caracteristicachave;
                    dadosRelatorio.MaquinaFabricação = item.maquinafabricacao;
                    dadosRelatorio.EspecificaçãoNominal = item.especificacaonominal;
                    dadosRelatorio.PraticadoLicx = item.praticadolicx;
                    dadosRelatorio.PraticadoLscx = item.praticadolscx;
                    dadosRelatorio.PraticadoLscr = item.praticadolscr;
                    dadosRelatorio.Lie = item.lie;
                    dadosRelatorio.Lse = item.lse;

                    DadosRelatorioCapabilidade1lista.Add(dadosRelatorio);
                }
                
            }
        }
    }
}
