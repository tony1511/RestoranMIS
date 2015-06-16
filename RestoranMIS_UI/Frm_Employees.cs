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
    public partial class Frm_Employees : Form
    {
        public Frm_Employees()
        {
            InitializeComponent();
        }

        private void Frm_Employees_Load(object sender, EventArgs e)
        {
            DSEmployees.EmployeesDataTable dtEmployee = new DSEmployees.EmployeesDataTable();

            DAEmployees.GetEmployees(dtEmployee);

            dgEmployees.DataSource = dtEmployee;
        }
    }
}
