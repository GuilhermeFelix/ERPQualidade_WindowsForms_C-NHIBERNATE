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
    public partial class RelatorioCapabilidade3 : Form
    {
        public RelatorioCapabilidade3(string _idmodelo)
        {
            this.idmodelo = _idmodelo;
            InitializeComponent();
        }
        public string idmodelo;
        private void RelatorioCapabilidade3_Load(object sender, EventArgs e)
        {
            GetDadosRelatorios3 getdados = new GetDadosRelatorios3(idmodelo);

            var datasource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetRelatorioCapabilidade3", getdados.listadeindicadores);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();



        }
    }
}
