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
    public partial class RelatorioCapabilidade7 : Form
    {
        public RelatorioCapabilidade7(string _idmodelo)
        {
            this.idmodelo = _idmodelo;
            InitializeComponent();
        }
        public string idmodelo;
        private void RelatorioCapabilidade7_Load(object sender, EventArgs e)
        {
            GetDadosRelatorios7 getdados = new GetDadosRelatorios7(idmodelo);

            var datasource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", getdados.listadeindicadores);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();

        }
    }
}
