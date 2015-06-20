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
    public partial class frmOrderDetailsReport : Form
    {
        public frmOrderDetailsReport(DSOrderDetails.StavkaNarudzbesDataTable dtOrderDetails1)
        {
            InitializeComponent();
            DSOrderDetailsBindingSource.DataSource = dtOrderDetails1;
        }

        private void frmOrderDetailsReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DSOrderDetails", DSOrderDetailsBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
