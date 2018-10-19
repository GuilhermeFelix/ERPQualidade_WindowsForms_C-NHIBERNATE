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
    public partial class NovoEstudo : Form
    {
        public NovoEstudo()
        {
            InitializeComponent();
        }

        private void NovoEstudo_Load(object sender, EventArgs e)
        {
            ModelodeAmostragemBO carregarnomes = new ModelodeAmostragemBO();

            foreach (var item in carregarnomes.CarregarNomesModelo())
            {
                cmb_CarregarModelo.Items.Add(item.idmodelo.ToString());
            }

            ConfiguracaoDiretorioEstudoCapabilidadeBO carregarcaminho = new ConfiguracaoDiretorioEstudoCapabilidadeBO();
            lbl_Caminho.Text = carregarcaminho.Caminho;
            
        }

        private void btn_GerarEstudo_Click(object sender, EventArgs e)
        {
            //verificar se existe 25 amostras no modelo.

            GerarEstudoBO verificarsepoderodar = new GerarEstudoBO(cmb_CarregarModelo.SelectedItem.ToString());
            if (verificarsepoderodar.verificarsepode_rodarestudo!=true)
            { 
                MessageBox.Show("Modelo não possui 25 amostras preenchidas, impossivel gerar estudo!", "Erro ao gerar estudo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("ESTUDO GERADO COM SUCESSO!", "CONCLUIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActiveForm.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
