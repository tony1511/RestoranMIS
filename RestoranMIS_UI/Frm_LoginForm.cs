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
    public partial class Frm_LoginForm : Form
    {
        public Frm_LoginForm()
        {
            InitializeComponent();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (DAEmployees.GetUserByLogin(userBox.Text, passBox.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                errLabel.Visible = true;
            }
            /*if (DAEmployees.GetEmployeeByLogin(txt_Username.Text, txt_Pass.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lbl_warning.Visible = true;
                lbl_warning.Text = "Pogresan username ili password!";
            }*/
        }
    }
}
