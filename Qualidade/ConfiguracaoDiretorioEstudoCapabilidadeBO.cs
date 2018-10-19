using NHibernate_PostGreSQLDAL;
using NHibernate_PostGreSQLDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade
{
    class ConfiguracaoDiretorioEstudoCapabilidadeBO
    {
        public ConfiguracaoDiretorioEstudoCapabilidadeBO()
        {
            CarregarDadosemDAO();
        }

        public ConfiguracaoDiretorioEstudoCapabilidadeBO(string _caminho)
        {
            this.Caminho = _caminho;
            AlterarDadosemDAO();
        }

        private string caminho;

        public string Caminho { get => caminho; set => caminho = value; }

        private void CarregarDadosemDAO()
        {
            
            RepositoryCapabilidade_configuracoesdiretoriosestudos dao = new RepositoryCapabilidade_configuracoesdiretoriosestudos();
            var caminhosalvarrelatorio = dao.RetornarPorId(1);     
            caminho = caminhosalvarrelatorio.caminho.ToString();

        }

        private void AlterarDadosemDAO()
        {
           
            Capabilidade_configuracoesdiretoriosestudos alterarcaminho = new Capabilidade_configuracoesdiretoriosestudos();
            RepositoryCapabilidade_configuracoesdiretoriosestudos dao = new RepositoryCapabilidade_configuracoesdiretoriosestudos();

            alterarcaminho.id = 1;
            alterarcaminho.caminho = Caminho;
            dao.Alterar(alterarcaminho);          

        }

    }
          
}
