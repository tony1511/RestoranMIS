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
    public partial class Frm_ProductsMostSold : Form
    {
        private DSProducts.ProizvodsDataTable dtProducts = new DSProducts.ProizvodsDataTable();

        public Frm_ProductsMostSold()
        {
            InitializeComponent();
        }

        private void Frm_ProductsMostSold_Load(object sender, EventArgs e)
        {

            BindProductsGrid();
            // po defaultu aktivniran button sa datumom
            rbDatum.Checked = true;
        }

        private void BindProductsGrid()
        {
            //Poziva Klasu DAOrders, samo bez parametara, da se izlistaju svi podaci
            DAProducts.GetProductsMostSold(dtProducts, null);

            //Uklanja automatsko popunjavanje kolona, buduci da su kolone rucno dodane
            dgvProizvodi.AutoGenerateColumns = false;
            //Puni tabelu podacima
            dgvProizvodi.DataSource = dtProducts;
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            DateTime? selectedDate = dpDate.Value;
            if (rbBezDatuma.Checked)
                selectedDate = null;
            DAProducts.GetProductsMostSold(dtProducts, selectedDate, txtSifraProizvoda.Text);

            //Uklanja automatsko popunjavanje kolona, buduci da su kolone rucno dodane
            dgvProizvodi.AutoGenerateColumns = false;
            //Puni tabelu podacima
            dgvProizvodi.DataSource = dtProducts;
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            BindProductsGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmProductsMostSoldReport mostSoldReport = new frmProductsMostSoldReport(dtProducts);
            mostSoldReport.Show();
        }
    }
}
