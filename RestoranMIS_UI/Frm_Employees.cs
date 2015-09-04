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
    public partial class Frm_Employees : Form
    {
        DSEmployees.EmployeesDataTable dtEmployee = new DSEmployees.EmployeesDataTable();

        public Frm_Employees()
        {
            InitializeComponent();
        }

        private void Frm_Employees_Load(object sender, EventArgs e)
        {
            

            DAEmployees.GetEmployees(dtEmployee, null, null, null, null);
            dgEmployees.AutoGenerateColumns = false;
            dgEmployees.DataSource = dtEmployee;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DAEmployees.GetEmployees(dtEmployee, txtIme.Text, txtPrezime.Text, txtUsername.Text, txtJMBG.Text); 
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmEmployeesForm employeesForm = new frmEmployeesForm(dtEmployee);
            employeesForm.Show();
        }

        /*private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            DateTime? selectedDate = dpDate.Value;
            if (rbBezDatuma.Checked)
                selectedDate = null;
            DAProducts.GetProductsMostSold(dtProducts, selectedDate, txtSifraProizvoda.Text);

            //Uklanja automatsko popunjavanje kolona, buduci da su kolone rucno dodane
            dgvProizvodi.AutoGenerateColumns = false;
            //Puni tabelu podacima
            dgvProizvodi.DataSource = dtProducts;
        }*/
    }
}
