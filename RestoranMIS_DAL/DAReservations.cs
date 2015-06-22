using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranMIS_DAL
{
    public class DAReservations
    {
        public static void GetReservations(DSReservations.RezervacijasDataTable dtReservations, DateTime? pickDate)
        {
            dtReservations.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_ReservartionByMonth", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (pickDate != null)
                {
                    cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = pickDate.Value.Date;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtReservations);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
