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

            //inserir valor no bd
            if (lst_Modelos.SelectedIndex.Equals(0))
            {
                bool inserirvalor = true;
                ModelodeAmostragemBO novomodelodeamostra = new ModelodeAmostragemBO(txt_IdModelo.Text, dtt_Inicio.Value, dtt_Fim.Value,
                                                                            cmb_CaracteristicasChave.Text, cmb_MaquinaFabricacao.Text,
                                                                            txt_EspecificacaoNominal.Text, txt_Licx.Text, txt_Lie.Text,
                                                                            txt_Lscx.Text, txt_Lse.Text, txt_Lscr.Text, txt_FerramentaCaracteristica1.Text,
                                                                            txt_FerramentaCaracteristica2.Text, txt_FerramentaCaracteristica3.Text, txt_FerramentaCaracteristica4.Text,
                                                                            txt_FerramentaCaracteristica5.Text,inserirvalor);

                
                i = 0;
                carregarlista();
                lst_Modelos.SetSelected(0, false);
            }
            else
            {
                ModelodeAmostragemBO carregarmodelodeamostra = new ModelodeAmostragemBO(lst_Modelos.SelectedIndex);

            }
            var a = lst_Modelos.SelectedIndex.ToString();
            //update de dados ja existentes
            if (!(Convert.ToInt32(a) <= 0))
            {

                ModelodeAmostragemBO novomodelodeamostra = new ModelodeAmostragemBO(Convert.ToInt16(lst_Modelos.SelectedIndex.ToString()), txt_IdModelo.Text, dtt_Inicio.Value, dtt_Fim.Value,
                                                                            cmb_CaracteristicasChave.Text, cmb_MaquinaFabricacao.Text,
                                                                            txt_EspecificacaoNominal.Text, txt_Licx.Text, txt_Lie.Text,
                                                                            txt_Lscx.Text, txt_Lse.Text, txt_Lscr.Text, txt_FerramentaCaracteristica1.Text,
                                                                            txt_FerramentaCaracteristica2.Text, txt_FerramentaCaracteristica3.Text, txt_FerramentaCaracteristica4.Text,
                                                                            txt_FerramentaCaracteristica5.Text);
           
                i = 0;
                carregarlista();
                lst_Modelos.SetSelected(0, false);


            }


        }

     
        private int i;
        private void lst_Modelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = lst_Modelos.SelectedIndex.ToString();
            //se SelectedIndex for diferente de 0 então sabemos que deve carregar modelo selecionado.
            if (!(Convert.ToInt32(a)<=0))
            {
                ModelodeAmostragemBO carregarmodeloamostra = new ModelodeAmostragemBO(lst_Modelos.SelectedIndex);
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


            //se SelectedIndex for igual a 0 então temos um novo modelo
            if ((Convert.ToInt32(a) <= 0))
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
            }
         
        }
        private void carregarlista()
        {
            ModelodeAmostragemBO carregarnomes = new ModelodeAmostragemBO();
            
            i = 0;
            foreach (var item in carregarnomes.CarregarNomesModelo())
            {

                if (i == 0)
                {
                    lst_Modelos.Items.Clear();
                    lst_Modelos.Items.Add("Novo Modelo");
                }

                lst_Modelos.Items.Add(item.id + " " + item.idmodelo);

                i++;
            }
        }

        private void ModeloAmostragem_Load_1(object sender, EventArgs e)
        {
            carregarlista();
        }
    }
}

