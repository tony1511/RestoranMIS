using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranMIS_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Orders orders = new Frm_Orders();
            orders.MdiParent = this;
            orders.Show();
        }

        private void employerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Employees employees = new Frm_Employees();
            employees.MdiParent = this;
            employees.Show();
        }

        private void onlineOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OnlineOrders onlineOrders = new Frm_OnlineOrders();
            onlineOrders.MdiParent = this;
            onlineOrders.Show();
        }

        private void reservarionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reservation reservation = new Frm_Reservation();
            reservation.MdiParent = this;
            reservation.Show();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Products products = new Frm_Products();
            products.MdiParent = this;
            products.Show();
        }

        private void productsMostSoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProductsMostSold productsMostSold = new Frm_ProductsMostSold();
            productsMostSold.MdiParent = this;
            productsMostSold.Show();
        }

        private void productsSoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProductsSold productsSold = new Frm_ProductsSold();
            productsSold.MdiParent = this;
            productsSold.Show();
        }
    }
}
