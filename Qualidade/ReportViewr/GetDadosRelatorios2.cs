using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate_PostGreSQLDAL;
using NHibernate_PostGreSQLDAL.Entities;


namespace Qualidade.ReportViewr
{
    class GetDadosRelatorios2
    {
        public GetDadosRelatorios2(string _idmodelo)
        {
            this.Idmodelo = _idmodelo;
            BuscarDados();

        }
        private string idmodelo;
        public IList<Capabilidade_amostras> todasamostras = new List<Capabilidade_amostras>();
        public IList<DadosRelatorioCapabilidade2> listadeamostras = new List<DadosRelatorioCapabilidade2>();
        public string Idmodelo { get => idmodelo; set => idmodelo = value; }

        private void BuscarDados()
        {
            //Buscar amostras do respectivo modelo
            RepositoryCapabilidade_amostras dao = new RepositoryCapabilidade_amostras();
           
            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())
            {
                if (Idmodelo == item.idmodelo)
                {
                    DadosRelatorioCapabilidade2 dadosRelatorio = new DadosRelatorioCapabilidade2();
                    dadosRelatorio.Modelo = item.idmodelo;
                    dadosRelatorio.Amostra = item.idamostra;
                    dadosRelatorio.Caracteristica1 = item.caracteristica1;
                    dadosRelatorio.Caracteristica2 = item.caracteristica2;
                    dadosRelatorio.Caracteristica3 = item.caracteristica3;
                    dadosRelatorio.Caracteristica4 = item.caracteristica4;
                    dadosRelatorio.Caracteristica5 = item.caracteristica5;

                    listadeamostras.Add(dadosRelatorio);
                }
               
            }  
  
        }
    }
}
