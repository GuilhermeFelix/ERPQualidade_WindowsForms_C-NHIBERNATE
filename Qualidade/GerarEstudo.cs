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
    public partial class GerarEstudo : Form
    {
        public GerarEstudo()
        {
            InitializeComponent();
        }

        private void GerarEstudo_Load(object sender, EventArgs e)
        {

        }

        private void btn_GerarEstudo_Click(object sender, EventArgs e)
        {
            NovoEstudo novoEstudo = new NovoEstudo();
            novoEstudo.Show();      

        }
    }
}
