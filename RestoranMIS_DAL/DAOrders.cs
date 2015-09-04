﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranMIS_DAL
{
    public class DAOrders
    {
        public static void GetOrders(DSOrders.NarudzbasDataTable dtOrders, DateTime? startDate, DateTime? endDate, int? customerId)
        {
            //Brise sve elemente iz tabele dtOrders, svakim pozivom ove funkcije tabela se prazni te se dodaju novi podaci
            dtOrders.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Orders_ByDate", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (startDate != null && endDate != null)
                {
                    cmd.Parameters.Add("@DateBegin", SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@DateEnd", SqlDbType.DateTime).Value = endDate;
                }
                
                if(customerId != null)
                    cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtOrders);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetOnlineOrders(DSOrders.NarudzbasDataTable dtOrders, DateTime? startDate, DateTime? endDate)
        {
            //Brise sve elemente iz tabele dtOrders, svakim pozivom ove funkcije tabela se prazni te se dodaju novi podaci
            dtOrders.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_OrdersOnline", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (startDate != null && endDate != null)
                {
                    cmd.Parameters.Add("@DateBegin", SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@DateEnd", SqlDbType.DateTime).Value = endDate;
                }


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtOrders);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetStatisticOrderByCategory(
            DSStatisticOrdersByCategory.usp_OrderStatisticByCategoryDataTable dtStatisticByCategoryDataTable,
            DateTime? startDate, DateTime? endDate)
        {
            //Brise sve elemente iz tabele dtOrders, svakim pozivom ove funkcije tabela se prazni te se dodaju novi podaci
            dtStatisticByCategoryDataTable.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_OrderStatisticByCategory", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (startDate != null && endDate != null)
                {
                    cmd.Parameters.Add("@DateBegin", SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@DateEnd", SqlDbType.DateTime).Value = endDate;
                }


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtStatisticByCategoryDataTable);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
