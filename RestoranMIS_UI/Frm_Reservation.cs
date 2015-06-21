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
using RestoranMIS_UI.Reports;

namespace RestoranMIS_UI
{
    public partial class Frm_Reservation : Form
    {
        public Frm_Reservation()
        {
            InitializeComponent();
        }

        private void Frm_Reservation_Load(object sender, EventArgs e)
        {
            BindReservationGrid();
        }

        private void BindReservationGrid()
        {
            DSReservations.RezervacijasDataTable dtReservations = new DSReservations.RezervacijasDataTable();

            DAReservations.GetReservations(dtReservations, null);

            reservationGridView.AutoGenerateColumns = false;
            reservationGridView.DataSource = dtReservations;
        }

        private void filtrirajButton_Click(object sender, EventArgs e)
        {
            DSReservations.RezervacijasDataTable dtReservations = new DSReservations.RezervacijasDataTable();

            DAReservations.GetReservations(dtReservations, dateDatePicker.Value);

            reservationGridView.AutoGenerateColumns = false;
            reservationGridView.DataSource = dtReservations;
        }

        private void prikaziSveButton_Click(object sender, EventArgs e)
        {
            BindReservationGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReservationReport reservationReport = new frmReservationReport();
            reservationReport.Show();
        }
    }
}
