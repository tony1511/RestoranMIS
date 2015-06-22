using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranMIS_DAL
{
    public class DAProducts
    {
        public static void GetProducts(DSProducts.ProizvodsDataTable dtProducts, int? kategorijaId)
        {
            dtProducts.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("esp_ProductsFilterCategories", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (kategorijaId != null)
                    cmd.Parameters.Add("@KategorijaId", SqlDbType.Int).Value = kategorijaId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtProducts);
            }
            finally
            {
                cn.Close();
            }
        }
        public static void GetProductsMostSold(DSProducts.ProizvodsDataTable dtProducts, DateTime? date, string sifra = "")
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
        }
        public static void GetProductsSold(DSProducts.ProizvodsDataTable dtProducts, DateTime? date, string sifra = "")
        {
            dtProducts.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_ProductsSold", cn);
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
        }
    }
}
