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
        public RelatorioCapabilidade1(string _idmodelo)
        {
            this.idmodelo = _idmodelo;
            InitializeComponent();
        }
        public string idmodelo;
        private void RelatorioCapabilidade1_Load(object sender, EventArgs e)
        {
            GetDadosRelatorios1 getdados = new GetDadosRelatorios1(idmodelo);

            var datasource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetRelatoriodeCapabilidade1", getdados.DadosRelatorioCapabilidade1lista);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);

            this.reportViewer1.RefreshReport();
        }
    }
}
