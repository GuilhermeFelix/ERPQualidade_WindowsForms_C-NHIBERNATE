using NHibernate_PostGreSQLDAL;
using NHibernate_PostGreSQLDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Qualidade
{
    class ConfiguracaoFerramentadeMedicaoCapabilidadeBO
    {
        public ConfiguracaoFerramentadeMedicaoCapabilidadeBO()
        {
            CarregarDadosemDAO();
        }
        public ConfiguracaoFerramentadeMedicaoCapabilidadeBO(string _ferramenta)
        {
            this.Ferramenta = _ferramenta;
            PersistirDadosemDAO();
        }

        public ConfiguracaoFerramentadeMedicaoCapabilidadeBO(string _ferramenta, bool remover)
        {
            this.Ferramenta = _ferramenta;
            RemoverDadosemDAO();
        }

        public ConfiguracaoFerramentadeMedicaoCapabilidadeBO(string _ferramentanova , string _ferramenta)
        {
            this.Ferramenta = _ferramenta;
            this.Novaferramenta = _ferramentanova;
            AlterarDadosemDAO();
        }

        private string ferramenta;
        private string novaferramenta;
        public IList<Capabilidade_ferramentademedicao> capabilidade_ferramentademedicao = new List<Capabilidade_ferramentademedicao>();
        public string Ferramenta { get => ferramenta; set => ferramenta = value; }
        public string Novaferramenta { get => novaferramenta; set => novaferramenta = value; }

        private void CarregarDadosemDAO()
        {
            
            RepositoryCapabilidade_ferramentademedicao dao = new RepositoryCapabilidade_ferramentademedicao();
            capabilidade_ferramentademedicao = dao.Consultar().ToList();       

        }

        private void PersistirDadosemDAO()
        {
            Capabilidade_ferramentademedicao novaferramenta = new Capabilidade_ferramentademedicao();
            RepositoryCapabilidade_ferramentademedicao dao = new RepositoryCapabilidade_ferramentademedicao();

            novaferramenta.ferramentademedicao = Ferramenta;
            dao.Inserir(novaferramenta);
            
        }

        private void AlterarDadosemDAO()
        {
            Capabilidade_ferramentademedicao alterarferramenta = new Capabilidade_ferramentademedicao();
            RepositoryCapabilidade_ferramentademedicao dao = new RepositoryCapabilidade_ferramentademedicao();

            foreach (var item in dao.Consultar())
            {
                if (item.ferramentademedicao  == Ferramenta)
                {
                    alterarferramenta.id = item.id;
                    alterarferramenta.ferramentademedicao = Novaferramenta;
                    dao.Alterar(alterarferramenta);
                }
            }
            

        }

        private void RemoverDadosemDAO()
        {
            RepositoryCapabilidade_ferramentademedicao dao = new RepositoryCapabilidade_ferramentademedicao();
            Capabilidade_ferramentademedicao removerferramenta = new Capabilidade_ferramentademedicao();

            foreach (var item in dao.Consultar())
            {
                if (item.ferramentademedicao == Ferramenta)
                {
                    removerferramenta.id = item.id;
                    removerferramenta.ferramentademedicao = item.ferramentademedicao;
                }
                dao.Excluir(removerferramenta);
            }
        }

        public IList<Capabilidade_ferramentademedicao> CarregarNomesCaracteristicas()
        {
            RepositoryCapabilidade_ferramentademedicao dao = new RepositoryCapabilidade_ferramentademedicao();
            var nomedasferramentas = dao.Consultar().OrderBy(x => x.id).ToList();
            return nomedasferramentas;
        }

    }          
}
