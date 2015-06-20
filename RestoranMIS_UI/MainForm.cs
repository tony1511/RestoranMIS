﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranMIS_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Orders orders = new Frm_Orders();
            orders.MdiParent = this;
            orders.Show();
        }

        private void employerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Employees employees = new Frm_Employees();
            employees.MdiParent = this;
            employees.Show();
        }

        private void onlineOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OnlineOrders onlineOrders = new Frm_OnlineOrders();
            onlineOrders.MdiParent = this;
            onlineOrders.Show();
        }
    }
}