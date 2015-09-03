using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranMIS_DAL
{
    public class DAEmployees
    {
        public static void GetEmployees(DSEmployees.EmployeesDataTable dtEmployees,
                                        string ime = "",
                                        string prezime = "",
                                        string username = "",
                                        string jmbg = ""
                                       )
        {
            dtEmployees.Clear();
            SqlConnection cn = Connection.GetConnection();
            if(cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Employees_Select", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (!String.IsNullOrEmpty(ime))
                    cmd.Parameters.Add("@Ime", SqlDbType.NVarChar).Value = ime;
                if (!String.IsNullOrEmpty(prezime))
                    cmd.Parameters.Add("@Prezime", SqlDbType.NVarChar).Value = prezime;
                if (!String.IsNullOrEmpty(username))
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                if (!String.IsNullOrEmpty(jmbg))
                    cmd.Parameters.Add("@JMBG", SqlDbType.Int).Value = jmbg;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtEmployees);
            }
            finally
            {
                
            }

            /*public static void GetProductsMostSold(DSProducts.ProizvodsDataTable dtProducts, DateTime? date, string sifra = "")
        {
            dtProducts.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_ProductsMostBought", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (date != null)
                    cmd.Parameters.Add("@Datum", SqlDbType.Date).Value = date.Value.Date;
                if (!String.IsNullOrEmpty(sifra))
                    cmd.Parameters.Add("@Sifra", SqlDbType.NVarChar).Value = sifra;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtProducts);
            }
            finally
            {
                cn.Close();
            }
        }*/
        }
    }
}
