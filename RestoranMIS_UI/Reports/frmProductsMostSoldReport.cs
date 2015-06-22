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
    public partial class frmProductsMostSoldReport : Form
    {
        public frmProductsMostSoldReport(DSProducts.ProizvodsDataTable dtProduct)
        {
            InitializeComponent();
            DSProductsBindingSource.DataSource = dtProduct;
        }

        private void frmProductsMostSoldReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DSProductsMostSold", DSProductsBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
