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
    public partial class ModeloAmostragem : Form
    {
        public ModeloAmostragem()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //se Novo Modelo for selecionado em lst_Modelos então inserir valor no bd
            try
            {
                if (lst_Modelos.SelectedItem.ToString() == "Novo Modelo")
                {

                    ModelodeAmostragemBO novomodelodeamostra = new ModelodeAmostragemBO(txt_IdModelo.Text, dtt_Inicio.Value, dtt_Fim.Value,
                                                                                cmb_CaracteristicasChave.Text, cmb_MaquinaFabricacao.Text,
                                                                                txt_EspecificacaoNominal.Text, txt_Licx.Text, txt_Lie.Text,
                                                                                txt_Lscx.Text, txt_Lse.Text, txt_Lscr.Text, txt_FerramentaCaracteristica1.Text,
                                                                                txt_FerramentaCaracteristica2.Text, txt_FerramentaCaracteristica3.Text, txt_FerramentaCaracteristica4.Text,
                                                                                txt_FerramentaCaracteristica5.Text, true);
                }

                if (lst_Modelos.SelectedItem.ToString() != "Novo Modelo")
                {
                    //buscar nome da amostra no banco para retornar o id para poder salvar certo


                    //update de dados ja existentes

                    ModelodeAmostragemBO novomodelodeamostra = new ModelodeAmostragemBO(txt_IdModelo.Text, dtt_Inicio.Value, dtt_Fim.Value,
                                                                                cmb_CaracteristicasChave.Text, cmb_MaquinaFabricacao.Text,
                                                                                txt_EspecificacaoNominal.Text, txt_Licx.Text, txt_Lie.Text,
                                                                                txt_Lscx.Text, txt_Lse.Text, txt_Lscr.Text, txt_FerramentaCaracteristica1.Text,
                                                                                txt_FerramentaCaracteristica2.Text, txt_FerramentaCaracteristica3.Text, txt_FerramentaCaracteristica4.Text,
                                                                                txt_FerramentaCaracteristica5.Text);
                }
            }
            catch
            {
                errorProvider_Confirmar.SetError(btn_Confirmar, "Selecione um Novo Modelo ou Modelo já Existente");
            }
            carregarlista();
        }

        private void lst_Modelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*se SelectedIndex não for igual a Novo Modelo então sabemos que deve carregar 
            nos campos o modelo selecionado. */
            

            if (lst_Modelos.SelectedItem.ToString()!= "Novo Modelo")
            {
                ModelodeAmostragemBO carregarmodeloamostra = new ModelodeAmostragemBO(lst_Modelos.SelectedItem.ToString());
                
                txt_IdModelo.Text = carregarmodeloamostra.Idmodelo;
                dtt_Inicio.Value = carregarmodeloamostra.Inicio;
                dtt_Fim.Value = carregarmodeloamostra.Fim;
                cmb_CaracteristicasChave.Text = carregarmodeloamostra.Caracteristicachave;
                cmb_MaquinaFabricacao.Text = carregarmodeloamostra.Maquinafabricacao;
                txt_EspecificacaoNominal.Text = carregarmodeloamostra.Especificacaonominal;
                txt_Licx.Text = carregarmodeloamostra.Praticadolicx;
                txt_Lie.Text = carregarmodeloamostra.Lie;
                txt_Lscx.Text = carregarmodeloamostra.Praticadolscx;
                txt_Lse.Text = carregarmodeloamostra.Lse;
                txt_Lscr.Text = carregarmodeloamostra.Praticadolscr;
                txt_FerramentaCaracteristica1.Text = carregarmodeloamostra.Ferramentacaracteristica1;
                txt_FerramentaCaracteristica2.Text = carregarmodeloamostra.Ferramentacaracteristica2;
                txt_FerramentaCaracteristica3.Text = carregarmodeloamostra.Ferramentacaracteristica3;
                txt_FerramentaCaracteristica4.Text = carregarmodeloamostra.Ferramentacaracteristica4;
                txt_FerramentaCaracteristica5.Text = carregarmodeloamostra.Ferramentacaracteristica5;

            }

            /*se o item selecionado for igual a NOVO MODELO então temos um novo modelo
            e devemos retirar os valores dos campos*/

            if (lst_Modelos.SelectedItem.ToString() == "Novo Modelo")
            {
                txt_IdModelo.Clear();
                cmb_CaracteristicasChave.Text = "";
                cmb_MaquinaFabricacao.Text = "";
                txt_EspecificacaoNominal.Text = "";
                txt_Licx.Text = "";
                txt_Lie.Text = "";
                txt_Lscx.Text = "";
                txt_Lse.Text = "";
                txt_Lscr.Text = "";
                txt_FerramentaCaracteristica1.Text = "";
                txt_FerramentaCaracteristica2.Text = "";
                txt_FerramentaCaracteristica3.Text = "";
                txt_FerramentaCaracteristica4.Text = "";
                txt_FerramentaCaracteristica5.Text = "";

                lst_Modelos.SelectedItem.Equals(0);
            }

        }

        //metodo para Carregar Lista com os nomes dos modelos
        private int i;

        private void carregarcaracteristicachave()
        {
            i = 0;
            ConfiguracaoCaracteristicaChaveCapabilidadeBO carregarcaracteristica = new ConfiguracaoCaracteristicaChaveCapabilidadeBO();
            foreach (var item in carregarcaracteristica.CarregarNomesCaracteristicas())
            {
                if (i == 0)
                {
                    cmb_CaracteristicasChave.Items.Clear();
                }

                cmb_CaracteristicasChave.Items.Add(item.caracteristica);

                i++;
            }



        }
        private void carregarlista()
        {

            //carregar nomes na lista
            i = 0;
            ModelodeAmostragemBO carregarnomes = new ModelodeAmostragemBO();

            foreach (var item in carregarnomes.CarregarNomesModelo())
            {
                if (i == 0)
                {
                    lst_Modelos.Items.Clear();
                    lst_Modelos.Items.Add("Novo Modelo");
                }

                lst_Modelos.SelectedIndex.Equals(item.id);
                lst_Modelos.Items.Add(item.idmodelo);

                i++;
            }        
        }

        //botao para excluir modelo
       
        private void ModeloAmostragem_Load(object sender, EventArgs e)
        {
            carregarlista();
            carregarcaracteristicachave();
            
        }

        private void lnk_ExcluirModelo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lst_Modelos.SelectedItem.ToString() != "Novo Modelo")
            {
                ModelodeAmostragemBO excluirmodelodeamostra = new ModelodeAmostragemBO(0, txt_IdModelo.Text, dtt_Inicio.Value, dtt_Fim.Value,
                                                                             cmb_CaracteristicasChave.Text, cmb_MaquinaFabricacao.Text,
                                                                             txt_EspecificacaoNominal.Text, txt_Licx.Text, txt_Lie.Text,
                                                                             txt_Lscx.Text, txt_Lse.Text, txt_Lscr.Text, txt_FerramentaCaracteristica1.Text,
                                                                             txt_FerramentaCaracteristica2.Text, txt_FerramentaCaracteristica3.Text, txt_FerramentaCaracteristica4.Text,
                                                                             txt_FerramentaCaracteristica5.Text, true);
            }
            
            txt_IdModelo.Clear();
            cmb_CaracteristicasChave.Text = "";
            cmb_MaquinaFabricacao.Text = "";
            txt_EspecificacaoNominal.Text = "";
            txt_Licx.Text = "";
            txt_Lie.Text = "";
            txt_Lscx.Text = "";
            txt_Lse.Text = "";
            txt_Lscr.Text = "";
            txt_FerramentaCaracteristica1.Text = "";
            txt_FerramentaCaracteristica2.Text = "";
            txt_FerramentaCaracteristica3.Text = "";
            txt_FerramentaCaracteristica4.Text = "";
            txt_FerramentaCaracteristica5.Text = "";

            carregarlista();
        }
    }
}

