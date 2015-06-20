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
    public partial class Frm_OnlineOrders : Form
    {
        private DSOrderDetails.StavkaNarudzbesDataTable dtOrderDetails = new DSOrderDetails.StavkaNarudzbesDataTable();

        public Frm_OnlineOrders()
        {
            InitializeComponent();
        }

        private void filtrirajButton_Click(object sender, EventArgs e)
        {
            DSOrders.NarudzbasDataTable dtOrders = new DSOrders.NarudzbasDataTable();

            DAOrders.GetOnlineOrders(dtOrders, dateStartPicker.Value, dateEndPicker.Value);

            ordersGridView.AutoGenerateColumns = false;
            ordersGridView.DataSource = dtOrders;
        }

        private void Frm_OnlineOrders_Load(object sender, EventArgs e)
        {
            DSOrders.NarudzbasDataTable dtOrders = new DSOrders.NarudzbasDataTable();

            DAOrders.GetOnlineOrders(dtOrders, null, null);

            ordersGridView.AutoGenerateColumns = false;
            ordersGridView.DataSource = dtOrders;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmOrderDetailsReport orderDetailsReport = new frmOrderDetailsReport(dtOrderDetails);
            orderDetailsReport.Show();
        }

        private void ordersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value);

            DAOrderDetails.GetOrderDetailsByOrderID(dtOrderDetails, orderId);

            dgOrderDetails.AutoGenerateColumns = false;
            dgOrderDetails.DataSource = dtOrderDetails;
        }
    }
}
