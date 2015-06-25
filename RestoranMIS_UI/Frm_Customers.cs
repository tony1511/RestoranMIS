using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace RestoranMIS_UI
{
    public partial class Frm_Customers : Form
    {
        DSCustomers.CustomersDataTable dtCustomers = new DSCustomers.CustomersDataTable();
        ContextMenu m = new ContextMenu();
        public Frm_Customers()
        {
            InitializeComponent();
        }

        private void Frm_Customers_Load(object sender, EventArgs e)
        {
            btnSearch_Click(null,null);
            m.MenuItems.Add(new MenuItem("View Orders", viewOrders));
            m.MenuItems.Add(new MenuItem("View Reservations", viewReservations));
            m.MenuItems.Add(new MenuItem("View Spending Totals"));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DACustomers.GetCustomers(dtCustomers, txtIme, txtPrezime, txtUsername);
            dgCustomers.AutoGenerateColumns = false;
            dgCustomers.DataSource = dtCustomers;

        }

        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                m.Show(dgv, new Point(e.RowIndex, e.ColumnIndex));
            }
        }

        private void viewOrders(object sender, EventArgs e)
        {
            Frm_Orders orders = new Frm_Orders();
            orders.customerId = Convert.ToInt32(dgCustomers.SelectedRows[0].Cells[0].Value);
            orders.MdiParent = MainForm.ActiveForm;
            orders.Show();

        }
        private void viewReservations(object sender, EventArgs e)
        {
            Frm_Reservation reservations = new Frm_Reservation();
            reservations.customerId = Convert.ToInt32(dgCustomers.SelectedRows[0].Cells[0].Value);
            reservations.MdiParent = MainForm.ActiveForm;
            reservations.Show();

        }
    }
}
