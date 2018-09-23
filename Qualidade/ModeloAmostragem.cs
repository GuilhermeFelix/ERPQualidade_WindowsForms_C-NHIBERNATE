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

        private void ModeloAmostragem_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_EspecificacaoNominal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            ModelodeAmostragemBO objeto1 = new ModelodeAmostragemBO(txt_IdModelo.Text, dtt_Inicio.Value, dtt_Fim.Value, 
                                                                      cmb_CaracteristicasChave.Text, cmb_MaquinaFabricacao.Text,
                                                                      txt_EspecificacaoNominal.Text, txt_Licx.Text, txt_Lie.Text, 
                                                                      txt_Lscx.Text, txt_Lse.Text, txt_Lscr.Text, txt_FerramentaCaracteristica1.Text,
                                                                      txt_FerramentaCaracteristica2.Text, txt_FerramentaCaracteristica3.Text, txt_FerramentaCaracteristica4.Text,
                                                                      txt_FerramentaCaracteristica5.Text);
        }
    }
}
