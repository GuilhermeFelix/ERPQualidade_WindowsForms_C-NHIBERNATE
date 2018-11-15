using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qualidade_NHibernate_PostGreSQLDAL.Entities;
using Qualidade_NHibernate_PostGreSQLDAL;

namespace Qualidade
{
    class ModelodeAmostragemBO
    {
                
        //construtor para carregar nomedasamostras do banco
        public ModelodeAmostragemBO()
        {

            this.nomes = CarregarNomesModelo();

        }

        //construtor para excluir dados que são selecionados no listbox no formulario
        public ModelodeAmostragemBO(int _id, string _idmodelo, DateTime _inicio, DateTime _fim,
            string _caracticachave, string _maquinafabricacao, string _especificacaonominal,
            string _praticadolicx, string _lie, string _praticadolscx, string _lse, string _praticadolscr,
            string _ferramentacaracteristica1, string _ferramentacaracteristica2, string _ferramentacaracteristica3,
            string _ferramentacaracteristica4, string _ferramentacaracteristica5, bool _excluirnobd)
        {
            this.Id = _id;
            this.Idmodelo = _idmodelo;
            this.Inicio = _inicio;
            this.Fim = _fim;
            this.Caracteristicachave = _caracticachave;
            this.Maquinafabricacao = _maquinafabricacao;
            this.Especificacaonominal = _especificacaonominal;
            this.Praticadolicx = _praticadolicx;
            this.Lie = _lie;
            this.Praticadolscx = _praticadolscx;
            this.Lse = _lse;
            this.Praticadolscr = _praticadolscr;
            this.Ferramentacaracteristica1 = _ferramentacaracteristica1;
            this.Ferramentacaracteristica2 = _ferramentacaracteristica2;
            this.Ferramentacaracteristica3 = _ferramentacaracteristica3;
            this.Ferramentacaracteristica4 = _ferramentacaracteristica4;
            this.Ferramentacaracteristica5 = _ferramentacaracteristica5;

            //caso selecione Modelo existente no ListBox deve  carregar os dados do BD nos campos.
            if (_excluirnobd == true)
            {
                ExcluirDadosemDAO();
            }

        }

        //construtor para carregar dados que são selecionados no listbox no formulario
        public ModelodeAmostragemBO(string _idmodelo)
        {
            this.Idmodelo = _idmodelo;

            //caso selecione Modelo existente no ListBox deve  carregar os dados do BD nos campos.
            if (Idmodelo != "Novo Modelo")
            {
                CarregarDadosemDAO();
            }

        }

        //construtor para persistir dados no BD.
        public ModelodeAmostragemBO(string _idmodelo, DateTime _inicio, DateTime _fim,
            string _caracticachave, string _maquinafabricacao, string _especificacaonominal,
            string _praticadolicx, string _lie, string _praticadolscx, string _lse, string _praticadolscr,
            string _ferramentacaracteristica1, string _ferramentacaracteristica2, string _ferramentacaracteristica3,
            string _ferramentacaracteristica4, string _ferramentacaracteristica5, bool _inserirnobd)
        {

            this.Idmodelo = _idmodelo;
            this.Inicio = _inicio;
            this.Fim = _fim;
            this.Caracteristicachave = _caracticachave;
            this.Maquinafabricacao = _maquinafabricacao;
            this.Especificacaonominal = _especificacaonominal;
            this.Praticadolicx = _praticadolicx;
            this.Lie = _lie;
            this.Praticadolscx = _praticadolscx;
            this.Lse = _lse;
            this.Praticadolscr = _praticadolscr;
            this.Ferramentacaracteristica1 = _ferramentacaracteristica1;
            this.Ferramentacaracteristica2 = _ferramentacaracteristica2;
            this.Ferramentacaracteristica3 = _ferramentacaracteristica3;
            this.Ferramentacaracteristica4 = _ferramentacaracteristica4;
            this.Ferramentacaracteristica5 = _ferramentacaracteristica5;


            //caso selecione Novo Modelo no ListBox deve inserir dados no BD.
            if (_inserirnobd)
            {
                PersistirDadosemDAO();
            }

        }


        // Update de Dados
        public ModelodeAmostragemBO(string _idmodelo, DateTime _inicio, DateTime _fim,
            string _caracticachave, string _maquinafabricacao, string _especificacaonominal,
            string _praticadolicx, string _lie, string _praticadolscx, string _lse, string _praticadolscr,
            string _ferramentacaracteristica1, string _ferramentacaracteristica2, string _ferramentacaracteristica3,
            string _ferramentacaracteristica4, string _ferramentacaracteristica5)
        {         
            this.Idmodelo = _idmodelo;
            this.Inicio = _inicio;
            this.Fim = _fim;
            this.Caracteristicachave = _caracticachave;
            this.Maquinafabricacao = _maquinafabricacao;
            this.Especificacaonominal = _especificacaonominal;
            this.Praticadolicx = _praticadolicx;
            this.Lie = _lie;
            this.Praticadolscx = _praticadolscx;
            this.Lse = _lse;
            this.Praticadolscr = _praticadolscr;
            this.Ferramentacaracteristica1 = _ferramentacaracteristica1;
            this.Ferramentacaracteristica2 = _ferramentacaracteristica2;
            this.Ferramentacaracteristica3 = _ferramentacaracteristica3;
            this.Ferramentacaracteristica4 = _ferramentacaracteristica4;
            this.Ferramentacaracteristica5 = _ferramentacaracteristica5;


            //caso selecione Modelo Existente no ListBox deve atualizar dados no BD.
            AlterarDadosemDAO();



        }

        private string idmodelo;
        private DateTime inicio;
        private DateTime fim;
        private string caracteristicachave;
        private string maquinafabricacao;
        private string especificacaonominal;
        private string praticadolicx;
        private string lie;
        private string praticadolscx;
        private string lse;
        private string praticadolscr;
        private string ferramentacaracteristica1;
        private string ferramentacaracteristica2;
        private string ferramentacaracteristica3;
        private string ferramentacaracteristica4;
        private string ferramentacaracteristica5;
        private int id;
        public IList<Capabilidade_modeloamostras> nomes;

        public string Idmodelo { get => idmodelo; set => idmodelo = value; }
        public DateTime Inicio { get => inicio; set => inicio = value; }
        public DateTime Fim { get => fim; set => fim = value; }
        public string Caracteristicachave { get => caracteristicachave; set => caracteristicachave = value; }
        public string Maquinafabricacao { get => maquinafabricacao; set => maquinafabricacao = value; }
        public string Especificacaonominal { get => especificacaonominal; set => especificacaonominal = value; }
        public string Praticadolicx { get => praticadolicx; set => praticadolicx = value; }
        public string Lie { get => lie; set => lie = value; }
        public string Praticadolscx { get => praticadolscx; set => praticadolscx = value; }
        public string Lse { get => lse; set => lse = value; }
        public string Praticadolscr { get => praticadolscr; set => praticadolscr = value; }
        public string Ferramentacaracteristica1 { get => ferramentacaracteristica1; set => ferramentacaracteristica1 = value; }
        public string Ferramentacaracteristica2 { get => ferramentacaracteristica2; set => ferramentacaracteristica2 = value; }
        public string Ferramentacaracteristica3 { get => ferramentacaracteristica3; set => ferramentacaracteristica3 = value; }
        public string Ferramentacaracteristica4 { get => ferramentacaracteristica4; set => ferramentacaracteristica4 = value; }
        public string Ferramentacaracteristica5 { get => ferramentacaracteristica5; set => ferramentacaracteristica5 = value; }
        public int Id { get => id; set => id = value; }

        private void PersistirDadosemDAO()
        {
            Capabilidade_modeloamostras novomodelo = new Capabilidade_modeloamostras();
            RepositoryCapabilidade_modeloamostras dao = new RepositoryCapabilidade_modeloamostras();
            
            novomodelo.idmodelo = idmodelo; 
            novomodelo.inicio = inicio;
            novomodelo.fim = fim;
            novomodelo.caracteristicachave = caracteristicachave;
            novomodelo.maquinafabricacao = maquinafabricacao;
            novomodelo.especificacaonominal = especificacaonominal;
            novomodelo.praticadolicx = praticadolicx;
            novomodelo.lie = lie;
            novomodelo.praticadolscx = praticadolscx;
            novomodelo.lse = lse;
            novomodelo.praticadolscr = praticadolscr;
            novomodelo.ferramentacaracteristica1 = ferramentacaracteristica1;
            novomodelo.ferramentacaracteristica2 = ferramentacaracteristica2;
            novomodelo.ferramentacaracteristica3 = ferramentacaracteristica3;
            novomodelo.ferramentacaracteristica4 = ferramentacaracteristica4;
            novomodelo.ferramentacaracteristica5 = ferramentacaracteristica5;
            dao.Inserir(novomodelo);

        }

        private void AlterarDadosemDAO()
        {
            
            //pesquisar o id referente ao modelo selecionado
            RepositoryCapabilidade_modeloamostras dao = new RepositoryCapabilidade_modeloamostras();
            Capabilidade_modeloamostras alterarmodelo = new Capabilidade_modeloamostras();

            var nomedasamostras = dao.Consultar().OrderBy(x => x.id).ToList();
            foreach (var item in nomedasamostras)
            {
                if (item.idmodelo == Idmodelo)
                {
                    alterarmodelo.id = item.id;
                }
            }

            alterarmodelo.idmodelo = Idmodelo;
            alterarmodelo.inicio = Inicio;
            alterarmodelo.fim = Fim;
            alterarmodelo.caracteristicachave = Caracteristicachave;
            alterarmodelo.maquinafabricacao = Maquinafabricacao;
            alterarmodelo.especificacaonominal = Especificacaonominal;
            alterarmodelo.praticadolicx = Praticadolicx;
            alterarmodelo.lie = Lie;
            alterarmodelo.praticadolscx = Praticadolscx;
            alterarmodelo.lse = Lse;
            alterarmodelo.praticadolscr = Praticadolscr;
            alterarmodelo.ferramentacaracteristica1 = Ferramentacaracteristica1;
            alterarmodelo.ferramentacaracteristica2 = Ferramentacaracteristica2;
            alterarmodelo.ferramentacaracteristica3 = Ferramentacaracteristica3;
            alterarmodelo.ferramentacaracteristica4 = Ferramentacaracteristica4;
            alterarmodelo.ferramentacaracteristica5 = Ferramentacaracteristica5;
            dao.Alterar(alterarmodelo);

        }

        private void ExcluirDadosemDAO()
        {

            Capabilidade_modeloamostras excluirmodelo = new Capabilidade_modeloamostras();

            //pesquisar o id referente ao modelo selecionado
            RepositoryCapabilidade_modeloamostras dao = new RepositoryCapabilidade_modeloamostras();

            var nomedasamostras = dao.Consultar().OrderBy(x => x.id).ToList();
            foreach (var item in nomedasamostras)
            {
                if (item.idmodelo == Idmodelo)
                {
                    excluirmodelo.id = item.id;
                }
            }

            excluirmodelo.idmodelo = idmodelo;
            excluirmodelo.inicio = inicio;
            excluirmodelo.fim = fim;
            excluirmodelo.caracteristicachave = caracteristicachave;
            excluirmodelo.maquinafabricacao = maquinafabricacao;
            excluirmodelo.especificacaonominal = especificacaonominal;
            excluirmodelo.praticadolicx = praticadolicx;
            excluirmodelo.lie = lie;
            excluirmodelo.praticadolscx = praticadolscx;
            excluirmodelo.lse = lse;
            excluirmodelo.praticadolscr = praticadolscr;
            excluirmodelo.ferramentacaracteristica1 = ferramentacaracteristica1;
            excluirmodelo.ferramentacaracteristica2 = ferramentacaracteristica2;
            excluirmodelo.ferramentacaracteristica3 = ferramentacaracteristica3;
            excluirmodelo.ferramentacaracteristica4 = ferramentacaracteristica4;
            excluirmodelo.ferramentacaracteristica5 = ferramentacaracteristica5;
            dao.Excluir(excluirmodelo);

        }



        private void CarregarDadosemDAO()
        {

            RepositoryCapabilidade_modeloamostras dao = new RepositoryCapabilidade_modeloamostras();
            var nomedasamostras = dao.Consultar().OrderBy(x => x.id).ToList();
            foreach (var carregarmodelo in nomedasamostras)
            {
                if (carregarmodelo.idmodelo == Idmodelo)
                {
                    Inicio = carregarmodelo.inicio;
                    Fim = carregarmodelo.fim;
                    Caracteristicachave = carregarmodelo.caracteristicachave;
                    Maquinafabricacao = carregarmodelo.maquinafabricacao;
                    Especificacaonominal = carregarmodelo.especificacaonominal;
                    Praticadolicx = carregarmodelo.praticadolicx;
                    Lie = carregarmodelo.lie;
                    Praticadolscx = carregarmodelo.praticadolscx;
                    Lse = carregarmodelo.lse;
                    Praticadolscr = carregarmodelo.praticadolscr;
                    Ferramentacaracteristica1 = carregarmodelo.ferramentacaracteristica1;
                    Ferramentacaracteristica2 = carregarmodelo.ferramentacaracteristica2;
                    Ferramentacaracteristica3 = carregarmodelo.ferramentacaracteristica3;
                    Ferramentacaracteristica4 = carregarmodelo.ferramentacaracteristica4;
                    Ferramentacaracteristica5 = carregarmodelo.ferramentacaracteristica5;
                }
            }
                        
        }

        public IList<Capabilidade_modeloamostras> CarregarNomesModelo()
        {
            RepositoryCapabilidade_modeloamostras dao = new RepositoryCapabilidade_modeloamostras();
            var nomedasamostras = dao.Consultar().OrderBy(x => x.id).ToList();
            return nomedasamostras;
        }

    }
}



        

        



