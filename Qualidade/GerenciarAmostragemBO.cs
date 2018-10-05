using NHibernate_PostGreSQLDAL;
using NHibernate_PostGreSQLDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade
{
    class GerenciarAmostragemBO
    {
        //criar construtor de classe para buscar se existe amostras preenchidas para o modelo associado
        public GerenciarAmostragemBO(int _id, string _idmodelo, string _idamostra)
        {
            this.Id = _id;
            this.Idmodelo = _idmodelo;
            this.Idamostra = _idamostra;
              
        }

        

        private int id;
        private string idmodelo;
        private string idamostra;
        private string ferramentademedicao;
        private string amostra1;
        private string amostra2;
        private string amostra3;
        private string amostra4;
        private string amostra5;

        public int Id { get => id; set => id = value; }
        public string Idmodelo { get => idmodelo; set => idmodelo = value; }
        public string Idamostra { get => idamostra; set => idamostra = value; }
        public string Ferramentademedicao { get => ferramentademedicao; set => ferramentademedicao = value; }
        public string Amostra1 { get => amostra1; set => amostra1 = value; }
        public string Amostra2 { get => amostra2; set => amostra2 = value; }
        public string Amostra3 { get => amostra3; set => amostra3 = value; }
        public string Amostra4 { get => amostra4; set => amostra4 = value; }
        public string Amostra5 { get => amostra5; set => amostra5 = value; }

        private void InserirDadosemDAO()
        {

            Capabilidade_amostras novomodelo = new Capabilidade_amostras();
            RepositoryCapabilidade_amostras dao = new RepositoryCapabilidade_amostras();

            novomodelo.id = Id;
            novomodelo.idmodelo = Idmodelo;
            novomodelo.idamostra = Idamostra;
            novomodelo.ferramentademedicao = Ferramentademedicao;
            novomodelo.amostra1 = Amostra1;
            novomodelo.amostra2 = Amostra2;
            novomodelo.amostra3 = Amostra3;
            novomodelo.amostra4 = Amostra4;
            novomodelo.amostra5 = Amostra5;

            dao.Inserir(novomodelo);
            
        }

        private void CarregarDadosemDAO()
        {
            
            

        }
    }
}
