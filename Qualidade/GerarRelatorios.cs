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
                //Relatorio de Especificação Referencial do Modelo
                case "RC1":

                    RelatorioCapabilidade1 abrirrelatorio1 = new RelatorioCapabilidade1(cmb_Modelos.SelectedItem.ToString());
                    abrirrelatorio1.Show();
                break;
               //Relatorio de Amostras por Modelo
                case "RC2":
                    RelatorioCapabilidade2 abrirrelatorio2 = new RelatorioCapabilidade2(cmb_Modelos.SelectedItem.ToString());
                    abrirrelatorio2.Show();
                break;
               
            }




        }
    }
}
