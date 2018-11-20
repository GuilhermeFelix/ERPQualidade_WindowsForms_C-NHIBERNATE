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
    public partial class RelatorioCapabilidade6 : Form
    {
        public RelatorioCapabilidade6(string _idmodelo)
        {
            this.idmodelo = _idmodelo;
            InitializeComponent();
        }
        public string idmodelo;
        private void RelatorioCapabilidade6_Load(object sender, EventArgs e)
        {
            GetDadosRelatorios6 getdados = new GetDadosRelatorios6(idmodelo);

            var datasource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", getdados.listadeindicadores);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();


        }
    }
}
