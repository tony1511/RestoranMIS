using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranMIS_DAL
{
    public class DACustomers
    {
        public static void GetCustomers(DSCustomers.CustomersDataTable dtCustomers, TextBox txtIme, TextBox txtPrezime, TextBox txtUsername)
        {
            dtCustomers.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Customers_Select", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (txtIme.Text != "")
                    cmd.Parameters.Add("@Ime", SqlDbType.NVarChar).Value = txtIme.Text;

                if (txtPrezime.Text != "")
                    cmd.Parameters.Add("@Prezime", SqlDbType.NVarChar).Value = txtPrezime.Text;

                if (txtUsername.Text != "")
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUsername.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtCustomers);
            }
            finally
            {

            }
        }
    }
}
