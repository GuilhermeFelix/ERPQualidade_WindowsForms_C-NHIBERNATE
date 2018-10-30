using NHibernate_PostGreSQLDAL;
using NHibernate_PostGreSQLDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Qualidade
{
    class ConfiguracaoCaracteristicaChaveCapabilidadeBO
    {
        public ConfiguracaoCaracteristicaChaveCapabilidadeBO()
        {
            CarregarDadosemDAO();
        }
        public ConfiguracaoCaracteristicaChaveCapabilidadeBO(string _caracteristica)
        {
            this.Caracteristica = _caracteristica;
            PersistirDadosemDAO();
        }

        public ConfiguracaoCaracteristicaChaveCapabilidadeBO(string _caracteristica, bool remover)
        {
            this.Caracteristica = _caracteristica;
            RemoverDadosemDAO();
        }

        public ConfiguracaoCaracteristicaChaveCapabilidadeBO(string _caracteristicanova , string _caracteristica)
        {
            this.Caracteristica = _caracteristica;
            this.Novacaracteristica = _caracteristicanova;
            AlterarDadosemDAO();
        }

        private string caracteristica;
        private string novacaracteristica;
        public IList<Capabilidade_caracteristicachave> capabilidade_Caracteristicachaves = new List<Capabilidade_caracteristicachave>();

        public string Caracteristica { get => caracteristica; set => caracteristica = value; }
        public string Novacaracteristica { get => novacaracteristica; set => novacaracteristica = value; }

        private void CarregarDadosemDAO()
        {
            
            RepositoryCapabilidade_caracteristicachave dao = new RepositoryCapabilidade_caracteristicachave();
            capabilidade_Caracteristicachaves = dao.Consultar().ToList();       

        }

        private void PersistirDadosemDAO()
        {
            Capabilidade_caracteristicachave novacaracteristica = new Capabilidade_caracteristicachave();
            RepositoryCapabilidade_caracteristicachave dao = new RepositoryCapabilidade_caracteristicachave();

            novacaracteristica.caracteristica = Caracteristica;
            dao.Inserir(novacaracteristica);
            
        }

        private void AlterarDadosemDAO()
        {
            Capabilidade_caracteristicachave alterarcaracteristica = new Capabilidade_caracteristicachave();
            RepositoryCapabilidade_caracteristicachave dao = new RepositoryCapabilidade_caracteristicachave();

            foreach (var item in dao.Consultar())
            {
                if (item.caracteristica  == Caracteristica)
                {
                    alterarcaracteristica.id = item.id;
                    alterarcaracteristica.caracteristica = Novacaracteristica;
                    dao.Alterar(alterarcaracteristica);
                }
            }
            

        }

        private void RemoverDadosemDAO()
        {
            RepositoryCapabilidade_caracteristicachave dao = new RepositoryCapabilidade_caracteristicachave();
            Capabilidade_caracteristicachave alterarcaracteristica = new Capabilidade_caracteristicachave();

            foreach (var item in dao.Consultar())
            {
                if (item.caracteristica == Caracteristica)
                {
                    alterarcaracteristica.id = item.id;
                    alterarcaracteristica.caracteristica = item.caracteristica;
                }
                dao.Excluir(alterarcaracteristica);
            }
        }

        public IList<Capabilidade_caracteristicachave> CarregarNomesCaracteristicas()
        {
            RepositoryCapabilidade_caracteristicachave dao = new RepositoryCapabilidade_caracteristicachave();
            var nomedascaracteristicas = dao.Consultar().OrderBy(x => x.id).ToList();
            return nomedascaracteristicas;
        }

    }          
}
