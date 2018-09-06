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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovaEditarAmostra novaamostra = new NovaEditarAmostra();
            novaamostra.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NovaEditarAmostra editarAmostra = new NovaEditarAmostra();
            editarAmostra.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
