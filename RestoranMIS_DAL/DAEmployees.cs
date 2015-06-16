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
        public static void GetEmployees(DSEmployees.EmployeesDataTable dtEmployees)
        {
            SqlConnection cn = Connection.GetConnection();
            if(cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Employees_Select", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtEmployees);
            }
            finally
            {
                    
            }
        }
    }
}
