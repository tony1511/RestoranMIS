using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranMIS_DAL
{
    public class DAOrderDetails
    {
        public static void GetOrderDetailsByOrderID(DSOrderDetails.StavkaNarudzbesDataTable dtOrdersDetails, int orderId)
        {
            dtOrdersDetails.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_OrderDetails_ByOrderID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (orderId != null && orderId > 0)
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = orderId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtOrdersDetails);
            }
            finally
            {

            }
        }
    }
}
