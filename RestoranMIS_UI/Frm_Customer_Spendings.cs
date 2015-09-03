using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestoranMIS_DAL;
using RestoranMIS_UI.Reports;

namespace RestoranMIS_UI
{
    public partial class Frm_Customer_Spendings : Form
    {
        DSSpendings.CustomerSpendingsDataTable dtSpendings = new DSSpendings.CustomerSpendingsDataTable();
        private DateTime dateFrom = DateTime.Now;
        private DateTime dateTo = DateTime.Now;
        public Frm_Customer_Spendings()
        {
            InitializeComponent();
            pickerFrom.Value = dateFrom;
            pickerTo.Value = dateTo;
        }

        private void Frm_Customer_Spendings_Load(object sender, EventArgs e)
        {
            DASpendings.GetSpendings(dtSpendings, txtIme, txtPrezime, txtUsername, null, null);
            dgSpendings.AutoGenerateColumns = false;
            dgSpendings.DataSource = dtSpendings;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(pickerFrom.Value == dateFrom && pickerTo.Value == dateTo)
                DASpendings.GetSpendings(dtSpendings, txtIme, txtPrezime, txtUsername, null, null);
            else
                DASpendings.GetSpendings(dtSpendings, txtIme, txtPrezime, txtUsername, pickerFrom.Value, pickerTo.Value);
            dgSpendings.AutoGenerateColumns = false;
            dgSpendings.DataSource = dtSpendings;
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            frmCustomerSpendingReport orderDetailsReport = new frmCustomerSpendingReport(dtSpendings);
            orderDetailsReport.Show();
        }
    }
}
