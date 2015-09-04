﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestoranMIS_DAL;
using RestoranMIS_UI.Reports;

namespace RestoranMIS_UI
{
    public partial class Frm_Statistics_Category : Form
    {
        private DSStatisticOrdersByCategory.usp_OrderStatisticByCategoryDataTable dtCategory = new  DSStatisticOrdersByCategory.usp_OrderStatisticByCategoryDataTable();

        public Frm_Statistics_Category()
        {
            InitializeComponent();
        }

        private void Frm_Statistics_Category_Load(object sender, EventArgs e)
        {
            BindProductsGrid();

        }

        private void BindProductsGrid()
        {
            //Poziva Klasu DAOrders, samo bez parametara, da se izlistaju svi podaci
            DAOrders.GetStatisticOrderByCategory(dtCategory, null, null);

            //Puni tabelu podacima

            chart_cat.DataSource = dtCategory; 
            
            chart_cat.Series["Kategorije"].XValueMember = "NazivKategorije";
            
            chart_cat.Series["Kategorije"].YValueMembers = "Udio";
            chart_cat.Titles.Add("Udio prodanih proizvoda po kategorijama"); 
            
        }

        private void btn_filtriraj_Click(object sender, EventArgs e)
        {
            chart_cat.Titles.Clear();

             dtCategory = new DSStatisticOrdersByCategory.usp_OrderStatisticByCategoryDataTable();

            //Poziva Klasu DAOrders, gdje mu salje dva parametra, datum pocetka i datum kraja za filtriranje podataka
             DAOrders.GetStatisticOrderByCategory(dtCategory, startDate.Value, endDate.Value);


             chart_cat.DataSource = dtCategory;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart_cat.Series["Kategorije"].XValueMember = "NazivKategorije";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart_cat.Series["Kategorije"].YValueMembers = "Udio";
            chart_cat.Titles.Add("Udio prodanih proizvoda po kategorijama"); 
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            frmCategoryProductStatistics statisticsReport = new frmCategoryProductStatistics(dtCategory);
            statisticsReport.Show();
        }
    }
}
