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
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void modelosDeAmostragemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeloAmostragem modeloAmostragem = new ModeloAmostragem();
            modeloAmostragem.Show();

        }

        private void adicionarAmostragemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarAmostragem gerenciarAmostragem = new GerenciarAmostragem();
            gerenciarAmostragem.Show();
        }

        private void gerarEstudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoEstudo gerarnovoestudo = new NovoEstudo();
            gerarnovoestudo.Show();
        }

        private void capabilidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfiguracaoDiretorioEstudoCapabilidade configdircapabilidade = new ConfiguracaoDiretorioEstudoCapabilidade();
            configdircapabilidade.Show();
        }

        private void diretóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void relatorio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarRelatorios gerarRelatorios = new GerarRelatorios();
            gerarRelatorios.Show();
        }
    }
}
