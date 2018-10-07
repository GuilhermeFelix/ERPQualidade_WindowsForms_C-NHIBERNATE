using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Qualidade
{
    public partial class GerenciarAmostragem : Form
    {
        public GerenciarAmostragem()
        {
            InitializeComponent();
        }

        private void GerenciarAmostragem_Load(object sender, EventArgs e)
        {
            ModelodeAmostragemBO carregarnomes = new ModelodeAmostragemBO();

            foreach (var item in carregarnomes.CarregarNomesModelo())
            {
                cmb_IdModelo.Items.Add(item.idmodelo.ToString());
                
            }
                     
        }
        private void cmb_IdModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelodeAmostragemBO carregarmodeloamostra = new ModelodeAmostragemBO(cmb_IdModelo.SelectedItem.ToString());
            lbl_IdModelo.Text = carregarmodeloamostra.Idmodelo.ToString();
            lbl_Inicio.Text = carregarmodeloamostra.Inicio.ToString();
            lbl_Fim.Text = carregarmodeloamostra.Fim.ToString();
            lbl_CaracteristicaChave.Text = carregarmodeloamostra.Caracteristicachave.ToString();
            lbl_MaquinadeFabricacao.Text = carregarmodeloamostra.Maquinafabricacao.ToString();
            lbl_EspecificacaoNominal.Text = carregarmodeloamostra.Especificacaonominal.ToString();
            lbl_PraticadoLicx.Text = carregarmodeloamostra.Praticadolicx.ToString();
            lbl_PraticadoLscx.Text = carregarmodeloamostra.Praticadolscx.ToString();
            lbl_PraticadoLscr.Text = carregarmodeloamostra.Praticadolscr.ToString();
            lbl_Lie.Text = carregarmodeloamostra.Lie.ToString();
            lbl_Lse.Text = carregarmodeloamostra.Lse.ToString();
            lbl_Ferramenta1.Text = carregarmodeloamostra.Ferramentacaracteristica1.ToString();
            lbl_Ferramenta2.Text = carregarmodeloamostra.Ferramentacaracteristica2.ToString();
            lbl_Ferramenta3.Text = carregarmodeloamostra.Ferramentacaracteristica3.ToString();
            lbl_Ferramenta4.Text = carregarmodeloamostra.Ferramentacaracteristica4.ToString();
            lbl_Ferramenta5.Text = carregarmodeloamostra.Ferramentacaracteristica5.ToString();

            GerenciarAmostragemBO carregarnogridview = new GerenciarAmostragemBO(cmb_IdModelo.SelectedItem.ToString());
            dtg_Amostras.DataSource = carregarnogridview.todasamostras;

        }
        
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            GerenciarAmostragemBO salvar = new GerenciarAmostragemBO(cmb_IdModelo.SelectedItem.ToString(),
                                                                     cmb_IdAmostra.SelectedItem.ToString(), lbl_Ferramenta1.Text.ToString(),
                                                                     txt_Caracteristica1.Text.ToString(), lbl_Ferramenta2.Text.ToString(),
                                                                     txt_Caracteristica2.Text.ToString(), lbl_Ferramenta3.Text.ToString(),
                                                                     txt_Caracteristica3.Text.ToString(), lbl_Ferramenta4.Text.ToString(),
                                                                     txt_Caracteristica4.Text.ToString(),lbl_Ferramenta5.Text.ToString(),
                                                                     txt_Caracteristica5.Text.ToString());
        }
    }
}
