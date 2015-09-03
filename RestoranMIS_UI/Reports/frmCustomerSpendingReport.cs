using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestoranMIS_DAL;
using Microsoft.Reporting.WinForms;

namespace RestoranMIS_UI.Reports
{
    public partial class frmCustomerSpendingReport : Form
    {
        public frmCustomerSpendingReport(DSSpendings.CustomerSpendingsDataTable dtSpendings)
        {
            InitializeComponent();
            DSSpendingsBindingSource.DataSource = dtSpendings;
        }

        private void frmCustomerSpendingReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("SpendingsDS", DSSpendingsBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
