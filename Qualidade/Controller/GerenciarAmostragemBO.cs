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
       //excluir amostra
       public GerenciarAmostragemBO(string _idmodelo, string _idamostra, Boolean excluiramostra)
        {
            this.Idmodelo = _idmodelo;
            this.Idamostra = _idamostra;
            ExcluirDadosemDAO();
        }

        //carregar seleção de amostras em um modelo especifico
        public GerenciarAmostragemBO(string _idmodelo, string _idamostra)
        {
            this.Idmodelo = _idmodelo;
            this.Idamostra = _idamostra;
            CarregarDadosamostraespecificaemDAO();
        }
        //carregar amostras no grid conforme idmodelo selecionado
        public GerenciarAmostragemBO(string _idmodelo)
        {
            this.Idmodelo = _idmodelo;         

            CarregarDadosemDAO();

            
        }


        //inserir amostras
        public GerenciarAmostragemBO(string _idmodelo, string _idamostra, string _ferramentamedicao1, string _caracteristica1,
                                     string _ferramentamedicao2, string _caracteristica2, string _ferramentamedicao3,
                                     string _caracteristica3, string _ferramentamedicao4, string _caracteristica4,
                                     string _ferramentamedicao5, string _caracteristica5)
        {
            this.Idmodelo = _idmodelo;
            this.Idamostra = _idamostra;
            this.Ferramentademedicao1 = _ferramentamedicao1;
            this.Caracteristica1 = _caracteristica1;
            this.Ferramentademedicao2 = _ferramentamedicao2;
            this.Caracteristica2 = _caracteristica2;
            this.Ferramentademedicao3 = _ferramentamedicao3;
            this.Caracteristica3 = _caracteristica3;
            this.Ferramentademedicao4 = _ferramentamedicao4;
            this.Caracteristica4 = _caracteristica4;
            this.Ferramentademedicao5 = _ferramentamedicao5;
            this.Caracteristica5 = _caracteristica5;

            PesquisarexistenciaamostraemDAO();



            if (amostraexistenteemDAO == true)
            {
                AlterarDadosemDAO();
            }
            else
            {
                InserirDadosemDAO();
            }
        }
                

        private int id;
        private string idmodelo;
        private string idamostra;
        private string ferramentademedicao1;
        private string caracteristica1;
        private string ferramentademedicao2;
        private string caracteristica2;
        private string ferramentademedicao3;
        private string caracteristica3;
        private string ferramentademedicao4;
        private string caracteristica4;
        private string ferramentademedicao5;
        private string caracteristica5;
        public IList<Capabilidade_amostras> todasamostras = new List<Capabilidade_amostras>();
        public Boolean amostraexistenteemDAO;
        
        public int Id { get => id; set => id = value; }
        public string Idmodelo { get => idmodelo; set => idmodelo = value; }
        public string Idamostra { get => idamostra; set => idamostra = value; }
        public string Ferramentademedicao1 { get => ferramentademedicao1; set => ferramentademedicao1 = value; }
        public string Caracteristica1 { get => caracteristica1; set => caracteristica1 = value; }
        public string Ferramentademedicao2 { get => ferramentademedicao2; set => ferramentademedicao2 = value; }
        public string Caracteristica2 { get => caracteristica2; set => caracteristica2 = value; }
        public string Ferramentademedicao3 { get => ferramentademedicao3; set => ferramentademedicao3 = value; }
        public string Caracteristica3 { get => caracteristica3; set => caracteristica3 = value; }
        public string Ferramentademedicao4 { get => ferramentademedicao4; set => ferramentademedicao4 = value; }
        public string Caracteristica4 { get => caracteristica4; set => caracteristica4 = value; }
        public string Ferramentademedicao5 { get => ferramentademedicao5; set => ferramentademedicao5 = value; }
        public string Caracteristica5 { get => caracteristica5; set => caracteristica5 = value; }

        private void InserirDadosemDAO()
        {

            Capabilidade_amostras novomodelo = new Capabilidade_amostras();
            RepositoryCapabilidade_amostras dao = new RepositoryCapabilidade_amostras();

            novomodelo.idmodelo = Idmodelo;
            novomodelo.idamostra = Idamostra;
            novomodelo.ferramentademedicao1 = Ferramentademedicao1;
            novomodelo.caracteristica1 = Caracteristica1;
            novomodelo.ferramentademedicao2 = Ferramentademedicao2;
            novomodelo.caracteristica2 = Caracteristica2;
            novomodelo.ferramentademedicao3 = Ferramentademedicao3;
            novomodelo.caracteristica3 = Caracteristica3;
            novomodelo.ferramentademedicao4 = Ferramentademedicao4;
            novomodelo.caracteristica4 = Caracteristica4;
            novomodelo.ferramentademedicao5 = Ferramentademedicao5;
            novomodelo.caracteristica5 = caracteristica5;
            
            dao.Inserir(novomodelo);
            
        }
        //carregar todas amostras de um modelo
        private IList<Capabilidade_amostras> CarregarDadosemDAO()
        {
            
            RepositoryCapabilidade_amostras dao = new RepositoryCapabilidade_amostras();
            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())
            {
                if (item.idmodelo == Idmodelo)
                {   
                    todasamostras.Add(item);
                }
            }
            
            return todasamostras;
                      
        }

        //pesquisar se existe a amostra no modelo selecionado antes de alterar ou salvar.
        private void PesquisarexistenciaamostraemDAO()
        {
            RepositoryCapabilidade_amostras dao = new RepositoryCapabilidade_amostras();
            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
            {
                if (item.idmodelo == Idmodelo)
                {
                    todasamostras.Add(item);
                }
            }

            foreach (var item in todasamostras) //filtraamostranomodelo
            {
                if (item.idamostra == Idamostra)
                {
                    amostraexistenteemDAO = true;
                }
            }
        }

        //carregar amostra especifica em um modelo selecionado
        public void CarregarDadosamostraespecificaemDAO()
        {
          RepositoryCapabilidade_amostras dao = new RepositoryCapabilidade_amostras();
          foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
          {
            if (item.idmodelo == Idmodelo)
            {
              todasamostras.Add(item);
            }
          }

          foreach (var item in todasamostras) //filtraamostranomodelo
            {
              if (item.idamostra == Idamostra)
              {
                    Idmodelo = item.idmodelo;
                    Idamostra = item.idamostra;
                    Caracteristica1 = item.caracteristica1;
                    Caracteristica2 = item.caracteristica2;
                    Caracteristica3 = item.caracteristica3;
                    Caracteristica4 = item.caracteristica4;
                    Caracteristica5 = item.caracteristica5;
                    
                }
          }
        }

        private void AlterarDadosemDAO()
        {

            //pesquisar o id referente a amostra selecionada

            Capabilidade_amostras alteraramostra = new Capabilidade_amostras();
            RepositoryCapabilidade_amostras dao = new RepositoryCapabilidade_amostras();

            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
            {
                if (item.idmodelo == Idmodelo)
                {
                    todasamostras.Add(item);
                }
            }

            foreach (var item in todasamostras) //filtraamostranomodelo
            {
                if (item.idamostra == Idamostra)
                {
                    alteraramostra.id = item.id;
                }
            }
            alteraramostra.idmodelo = Idmodelo;
            alteraramostra.idamostra = Idamostra;
            alteraramostra.ferramentademedicao1 = Ferramentademedicao1;
            alteraramostra.caracteristica1 = Caracteristica1;
            alteraramostra.ferramentademedicao2 = Ferramentademedicao2;
            alteraramostra.caracteristica2 = Caracteristica2;
            alteraramostra.ferramentademedicao3 = Ferramentademedicao3;
            alteraramostra.caracteristica3 = Caracteristica3;
            alteraramostra.ferramentademedicao4 = Ferramentademedicao4;
            alteraramostra.caracteristica4 = Caracteristica4;
            alteraramostra.ferramentademedicao5 = Ferramentademedicao5;
            alteraramostra.caracteristica5 = Caracteristica5;
            dao.Alterar(alteraramostra);
        }

        private void ExcluirDadosemDAO()
        {

            Capabilidade_amostras excluiramostra = new Capabilidade_amostras();
            //pesquisar o id referente ao modelo selecionado
            RepositoryCapabilidade_amostras dao = new RepositoryCapabilidade_amostras();

            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
            {
                if (item.idmodelo == Idmodelo)
                {
                    todasamostras.Add(item);
                }
            }

            foreach (var item in todasamostras) //filtraamostranomodelo
            {
                if (item.idamostra == Idamostra)
                {
                    excluiramostra.id = item.id;
                }
            }

            dao.Excluir(excluiramostra);

        }
    }
}
