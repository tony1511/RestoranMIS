using Microsoft.Reporting.WinForms;
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

namespace RestoranMIS_UI.Reports
{
    public partial class frmProductsSoldForm : Form
    {
        public frmProductsSoldForm(DSProducts.ProizvodsDataTable dtProduct)
        {
            InitializeComponent();
            DSProductsBindingSource.DataSource = dtProduct;
        }

        private void frmProductsSoldForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("ProductsDS", DSProductsBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
