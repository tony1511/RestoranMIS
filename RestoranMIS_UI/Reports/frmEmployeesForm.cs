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
    public partial class frmEmployeesForm : Form
    {
        public frmEmployeesForm(DSEmployees.EmployeesDataTable employeesData)
        {
            InitializeComponent();
            EmployessBindingSource.DataSource = employeesData;
        }

        private void frmEmployeesForm_Load(object sender, EventArgs e)
        {
            reportViewer.LocalReport.ReportEmbeddedResource = "RestoranMIS_UI.Reports.rptEmployers.rdlc";

            ReportDataSource rds = new ReportDataSource("DSEmployers", EmployessBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
