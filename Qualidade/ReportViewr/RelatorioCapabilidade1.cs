using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qualidade.ReportViewr
{
    public partial class RelatorioCapabilidade1 : Form
    {
        public RelatorioCapabilidade1()
        {
            InitializeComponent();
        }

        private void RelatorioCapabilidade1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
