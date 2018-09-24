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

            if (lst_Modelos.SelectedIndex.Equals(0))
            {
                bool inserirvalor = true;
                ModelodeAmostragemBO objeto1 = new ModelodeAmostragemBO(txt_IdModelo.Text, dtt_Inicio.Value, dtt_Fim.Value,
                                                                            cmb_CaracteristicasChave.Text, cmb_MaquinaFabricacao.Text,
                                                                            txt_EspecificacaoNominal.Text, txt_Licx.Text, txt_Lie.Text,
                                                                            txt_Lscx.Text, txt_Lse.Text, txt_Lscr.Text, txt_FerramentaCaracteristica1.Text,
                                                                            txt_FerramentaCaracteristica2.Text, txt_FerramentaCaracteristica3.Text, txt_FerramentaCaracteristica4.Text,
                                                                            txt_FerramentaCaracteristica5.Text, inserirvalor);
            }
            else
            {
                this.Close();
            }
        }

        private void lst_Modelos_SelectedIndexChanged(object sender, EventArgs e)
        {

                if (lst_Modelos.SelectedIndex.Equals(0))
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
                }
        }
    }
}

