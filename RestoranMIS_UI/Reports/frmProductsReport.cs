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
using RestoranMIS_DAL;

namespace RestoranMIS_UI.Reports
{
    public partial class frmProductsReport : Form
    {
        public frmProductsReport(DSProducts.ProizvodsDataTable dtProduct)
        {
            InitializeComponent();
            DSProductsBindingSource.DataSource = dtProduct;

        }

        private void frmProductsReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("ProductsDS", DSProductsBindingSource);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
