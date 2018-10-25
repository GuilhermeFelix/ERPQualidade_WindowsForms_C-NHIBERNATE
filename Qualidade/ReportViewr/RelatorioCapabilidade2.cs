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
    public partial class RelatorioCapabilidade2 : Form
    {
        public RelatorioCapabilidade2(string _idmodelo)
        {
            this.idmodelo = _idmodelo;
            InitializeComponent();
        }
        public string idmodelo;
        private void RelatorioCapabilidade2_Load(object sender, EventArgs e)
        {
            GetDadosRelatorios2 getdados = new GetDadosRelatorios2(idmodelo);
            
            var datasource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetRelatorioCapabilidade2", getdados.listadeamostras);
            this.reportViewer1.LocalReport.DataSources.Clear();                
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
