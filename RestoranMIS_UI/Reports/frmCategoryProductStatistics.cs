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
    public partial class frmCategoryProductStatistics : Form
    {
        public frmCategoryProductStatistics(DSStatisticOrdersByCategory.usp_OrderStatisticByCategoryDataTable dtStatisticByCategoryDataTable)
        {
            InitializeComponent();
            dsCategoryProductStatisticsBindingSource.DataSource = dtStatisticByCategoryDataTable;
        }

        private void frmCategoryProductStatistics_Load(object sender, EventArgs e)
        {
            reportViewer.LocalReport.ReportEmbeddedResource = "RestoranMIS_UI.Reports.rptCategoryProductStatistics.rdlc";

            ReportDataSource rds = new ReportDataSource("DSCategoryProductsStatistics", dsCategoryProductStatisticsBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
             this.reportViewer.RefreshReport();
        }
    }
}
