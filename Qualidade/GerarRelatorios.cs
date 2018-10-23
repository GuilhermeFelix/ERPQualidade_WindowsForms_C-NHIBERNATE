using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Qualidade.ReportViewr;

namespace Qualidade
{
    public partial class GerarRelatorios : Form
    {
        public GerarRelatorios()
        {
            InitializeComponent();
        }

        private void GerarRelatorios_Load(object sender, EventArgs e)
        {
            ModelodeAmostragemBO carregarnomes = new ModelodeAmostragemBO();

            foreach (var item in carregarnomes.CarregarNomesModelo())
            {
                cmb_Modelos.Items.Add(item.idmodelo.ToString());

            }
        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            switch (txt_Subtransacao.Text)
            {
                case "RC1":

                    RelatorioCapabilidade1 abrirrelatorio = new RelatorioCapabilidade1(cmb_Modelos.SelectedItem.ToString());
                    abrirrelatorio.Show();

                break;
               
            }




        }
    }
}
