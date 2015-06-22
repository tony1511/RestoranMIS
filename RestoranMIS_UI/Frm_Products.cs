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
    public partial class Frm_Products : Form
    {
        private DSProducts.ProizvodsDataTable dtProducts = new DSProducts.ProizvodsDataTable();
        private DSCategories.KategorijasDataTable dtCategories = new DSCategories.KategorijasDataTable();
        public Frm_Products()
        {
            InitializeComponent();
        }

        private void Frm_Products_Load(object sender, EventArgs e)
        {
            //Popunjava combobox kategorije
            BindKategorije();


            BindProductsGrid();
        }

        private void BindProductsGrid()
        {
            //Poziva Klasu DAOrders, samo bez parametara, da se izlistaju svi podaci
            DAProducts.GetProducts(dtProducts, null);

            //Uklanja automatsko popunjavanje kolona, buduci da su kolone rucno dodane
            dgvProizvodi.AutoGenerateColumns = false;
            //Puni tabelu podacima
            dgvProizvodi.DataSource = dtProducts;
            cmbKategorije.SelectedValue = 0;
        }

        private void BindKategorije()
        {
            DACategories.GetCategories(dtCategories);

            DSCategories.KategorijasRow kategorija = dtCategories.NewKategorijasRow();
            kategorija.Id = 0;
            kategorija.NazivKategorije = "Odaberite kategoriju";
            
            dtCategories.Rows.InsertAt(kategorija, 0);

            cmbKategorije.DataSource = dtCategories;
            cmbKategorije.DisplayMember = "NazivKategorije";
            cmbKategorije.ValueMember = "Id";
        }

        private void cmbKategorije_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int? kategorijaId = Convert.ToInt32(cmbKategorije.SelectedValue);
            if (kategorijaId == 0)
                kategorijaId = null;
            //Poziva Klasu DAOrders, samo bez parametara, da se izlistaju svi podaci
            DAProducts.GetProducts(dtProducts, kategorijaId);

            //Uklanja automatsko popunjavanje kolona, buduci da su kolone rucno dodane
            dgvProizvodi.AutoGenerateColumns = false;
            //Puni tabelu podacima
            dgvProizvodi.DataSource = dtProducts;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmProductsReport report = new frmProductsReport(dtProducts);
            report.Show();

        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            BindProductsGrid();
        }
    }
}
