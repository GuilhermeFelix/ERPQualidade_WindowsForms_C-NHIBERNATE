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

        private void carregargrid()
        {

            GerenciarAmostragemBO carregarnogridview = new GerenciarAmostragemBO(cmb_IdModelo.SelectedItem.ToString());
            dtg_Amostras.DataSource = carregarnogridview.todasamostras;
            dtg_Amostras.Columns.Remove("id");
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

            carregargrid();

        }
        
        private void btn_Salvar_Click(object sender, EventArgs e)
        {


            //pesquisar se existe dado no banco se existir é alterar, se não é salvar





            GerenciarAmostragemBO salvaramostra = new GerenciarAmostragemBO(cmb_IdModelo.SelectedItem.ToString(),
                                                                     cmb_IdAmostra.SelectedItem.ToString(), lbl_Ferramenta1.Text.ToString(),
                                                                     txt_Caracteristica1.Text.ToString(), lbl_Ferramenta2.Text.ToString(),
                                                                     txt_Caracteristica2.Text.ToString(), lbl_Ferramenta3.Text.ToString(),
                                                                     txt_Caracteristica3.Text.ToString(), lbl_Ferramenta4.Text.ToString(),
                                                                     txt_Caracteristica4.Text.ToString(),lbl_Ferramenta5.Text.ToString(),
                                                                     txt_Caracteristica5.Text.ToString());


            carregargrid();

        }


        private void cmb_IdAmostra_SelectedIndexChanged(object sender, EventArgs e)
        {

            GerenciarAmostragemBO carregarnogridview = new GerenciarAmostragemBO(cmb_IdModelo.SelectedItem.ToString(), cmb_IdAmostra.SelectedItem.ToString());
            
            txt_Caracteristica1.Text = carregarnogridview.Caracteristica1;
            txt_Caracteristica2.Text = carregarnogridview.Caracteristica2;
            txt_Caracteristica3.Text = carregarnogridview.Caracteristica3;
            txt_Caracteristica4.Text = carregarnogridview.Caracteristica4;
            txt_Caracteristica5.Text = carregarnogridview.Caracteristica5;
        
            if (carregarnogridview == null || cmb_IdAmostra.SelectedItem.ToString()=="-")
            {
                txt_Caracteristica1.Clear();
                txt_Caracteristica2.Clear();
                txt_Caracteristica3.Clear();
                txt_Caracteristica4.Clear();
                txt_Caracteristica5.Clear();
            }
        }

        private void lnk_ExcluirModelo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GerenciarAmostragemBO excluiramostra = new GerenciarAmostragemBO(cmb_IdModelo.SelectedItem.ToString(), cmb_IdAmostra.SelectedItem.ToString(),true);
            MessageBox.Show("MODIFICAÇÂO CONCLUIDA", "Item Excluido");
            carregargrid();


        }
    }
}
