using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade
{
    class ModelodeAmostragemXML
    {
    

        public ModelodeAmostragemXML(string _idmodelo, DateTime _inicio, DateTime _fim,
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

        //MetodoparaSalvarXML
        private void SalvarXML()
        {








        }

    }

    




}
