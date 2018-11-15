using Qualidade_NHibernate_PostGreSQLDAL;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Qualidade
{
    class ConfiguracaoMaquinaFabricacaoCapabilidadeBO
    {
        public ConfiguracaoMaquinaFabricacaoCapabilidadeBO()
        {
            CarregarDadosemDAO();
        }
        public ConfiguracaoMaquinaFabricacaoCapabilidadeBO(string _maquina)
        {
            this.Maquina = _maquina;
            PersistirDadosemDAO();
        }

        public ConfiguracaoMaquinaFabricacaoCapabilidadeBO(string _maquina, bool remover)
        {
            this.Maquina = _maquina;
            RemoverDadosemDAO();
        }

        public ConfiguracaoMaquinaFabricacaoCapabilidadeBO(string _maquinanova , string _maquina)
        {
            this.Maquina = _maquina;
            this.Novamaquina = _maquinanova;
            AlterarDadosemDAO();
        }

        private string maquina;
        private string novamaquina;
        public IList<Capabilidade_maquinafabricacao> capabilidade_maquinafabricacao = new List<Capabilidade_maquinafabricacao>();

        public string Maquina { get => maquina; set => maquina = value; }
        public string Novamaquina { get => novamaquina; set => novamaquina = value; }

        private void CarregarDadosemDAO()
        {
            
            RepositoryCapabilidade_maquinafabricacao dao = new RepositoryCapabilidade_maquinafabricacao();
            capabilidade_maquinafabricacao = dao.Consultar().ToList();       

        }

        private void PersistirDadosemDAO()
        {
            Capabilidade_maquinafabricacao novamaquina = new Capabilidade_maquinafabricacao();
            RepositoryCapabilidade_maquinafabricacao dao = new RepositoryCapabilidade_maquinafabricacao();

            novamaquina.maquinafabricacao = Maquina;
            dao.Inserir(novamaquina);
            
        }

        private void AlterarDadosemDAO()
        {
            Capabilidade_maquinafabricacao alterarmaquina = new Capabilidade_maquinafabricacao();
            RepositoryCapabilidade_maquinafabricacao dao = new RepositoryCapabilidade_maquinafabricacao();

            foreach (var item in dao.Consultar())
            {
                if (item.maquinafabricacao  == Maquina)
                {
                    alterarmaquina.id = item.id;
                    alterarmaquina.maquinafabricacao = Novamaquina;
                    dao.Alterar(alterarmaquina);
                }
            }
            

        }

        private void RemoverDadosemDAO()
        {
            RepositoryCapabilidade_maquinafabricacao dao = new RepositoryCapabilidade_maquinafabricacao();
            Capabilidade_maquinafabricacao removermaquina = new Capabilidade_maquinafabricacao();

            foreach (var item in dao.Consultar())
            {
                if (item.maquinafabricacao == Maquina)
                {
                    removermaquina.id = item.id;
                    removermaquina.maquinafabricacao = item.maquinafabricacao;
                }
                dao.Excluir(removermaquina);
            }
        }

        public IList<Capabilidade_maquinafabricacao> CarregarNomesCaracteristicas()
        {
            RepositoryCapabilidade_maquinafabricacao dao = new RepositoryCapabilidade_maquinafabricacao();
            var nomedasmaquinas = dao.Consultar().OrderBy(x => x.id).ToList();
            return nomedasmaquinas;
        }

    }          
}
