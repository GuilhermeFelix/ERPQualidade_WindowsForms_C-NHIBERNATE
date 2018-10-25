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
    public partial class ConfiguracaoDiretorioEstudoCapabilidade : Form
    {
        public ConfiguracaoDiretorioEstudoCapabilidade()
        {
            InitializeComponent();
        }

        private void ConfiguracaoDiretorioEstudoCapabilidade_Load(object sender, EventArgs e)
        {
            ConfiguracaoDiretorioEstudoCapabilidadeBO carregarcaminho = new ConfiguracaoDiretorioEstudoCapabilidadeBO();
            txt_Caminho.Text = carregarcaminho.Caminho;
        }

        private void txt_Caminho_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            ConfiguracaoDiretorioEstudoCapabilidadeBO salvarnovocaminho = new ConfiguracaoDiretorioEstudoCapabilidadeBO(txt_Caminho.Text);

        }
    }
}
