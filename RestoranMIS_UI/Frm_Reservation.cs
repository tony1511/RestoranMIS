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
        private DSReservations.RezervacijasDataTable dtReservations = new DSReservations.RezervacijasDataTable();
        public int? customerId { get; set; }
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
            if (!customerId.HasValue)
                DAReservations.GetReservations(dtReservations, null,null);
            else
            DAReservations.GetReservations(dtReservations, null, customerId);

            reservationGridView.AutoGenerateColumns = false;
            reservationGridView.DataSource = dtReservations;
        }

        private void filtrirajButton_Click(object sender, EventArgs e)
        {

            DAReservations.GetReservations(dtReservations, dateDatePicker.Value, customerId);

            reservationGridView.AutoGenerateColumns = false;
            reservationGridView.DataSource = dtReservations;
        }

        private void prikaziSveButton_Click(object sender, EventArgs e)
        {
            BindReservationGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReservationReport reservationReport = new frmReservationReport(dtReservations);
            reservationReport.Show();
        }
    }
}
