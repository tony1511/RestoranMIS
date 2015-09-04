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
        private string text_param = " ", cat_param = " ";
        public frmProductsReport(DSProducts.ProizvodsDataTable dtProduct, string nazivKategorije)
        {
            InitializeComponent();
            DSProductsBindingSource.DataSource = dtProduct;
            cat_param = nazivKategorije;
            text_param = " ";

        }

        private void frmProductsReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("ProductsDS", DSProductsBindingSource);
            reportViewer1.LocalReport.DataSources.Add(rds);
            if (String.IsNullOrEmpty(cat_param) || cat_param != "Odaberite kategoriju")
                text_param = "Sortirano pokategoriji : ";
            else
                cat_param = " ";
                
            reportViewer1.LocalReport.SetParameters(new ReportParameter("text_param", text_param));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("cat_param", cat_param));
            this.reportViewer1.RefreshReport();
        }
    }
}
