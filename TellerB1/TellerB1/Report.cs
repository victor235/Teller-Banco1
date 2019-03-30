using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace TellerB1
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            // TODO: This line of code loads data into the 'Caja_AppDataSet1.tblUsuarios' table. You can move, or remove it, as needed.

            Caja_AppDataSet1TableAdapters.tblUsuariosTableAdapter tblUsuariosTableAdapter = 
                new Caja_AppDataSet1TableAdapters.tblUsuariosTableAdapter();

            ReportDataSource rds = new ReportDataSource(
                "DataSet1", tblUsuariosTableAdapter.GetData().Where(x => x.Codigo_Usuario == 10002).ToList());
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
