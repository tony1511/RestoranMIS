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
    public partial class frmReservationReport : Form
    {
        public frmReservationReport(DSReservations.RezervacijasDataTable dtReservations)
        {
            InitializeComponent();
            DSReservationsBindingSource.DataSource = dtReservations;
        }

        private void frmReservationReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("ReservationsDS", DSReservationsBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
