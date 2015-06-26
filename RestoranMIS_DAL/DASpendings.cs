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
    public class DASpendings
    {
        public static void GetSpendings(DSSpendings.CustomerSpendingsDataTable dtSpendings,
                                        TextBox txtIme, TextBox txtPrezime, TextBox txtUsername, DateTime? pickerFrom, DateTime? pickerTo)
        {
            dtSpendings.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Customer_Spendings_Select", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                 if (pickerFrom != null && pickerTo != null)
                 {
                     cmd.Parameters.Add("@DateBegin", SqlDbType.DateTime).Value = pickerFrom;
                     cmd.Parameters.Add("@DateEnd", SqlDbType.DateTime).Value = pickerTo;
                 }

                if (txtIme.Text != "")
                    cmd.Parameters.Add("@Ime", SqlDbType.NVarChar).Value = txtIme.Text;

                if (txtPrezime.Text != "")
                    cmd.Parameters.Add("@Prezime", SqlDbType.NVarChar).Value = txtPrezime.Text;

                if (txtUsername.Text != "")
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUsername.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtSpendings);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
