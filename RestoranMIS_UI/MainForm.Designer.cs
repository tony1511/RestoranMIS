namespace RestoranMIS_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMostSoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsSoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerSpendingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.employersToolStripMenuItem,
            this.reservationsToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(720, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderDetailsToolStripMenuItem,
            this.onlineOrdersToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // onlineOrdersToolStripMenuItem
            // 
            this.onlineOrdersToolStripMenuItem.Name = "onlineOrdersToolStripMenuItem";
            this.onlineOrdersToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.onlineOrdersToolStripMenuItem.Text = "Online Orders";
            this.onlineOrdersToolStripMenuItem.Click += new System.EventHandler(this.onlineOrdersToolStripMenuItem_Click);
            // 
            // employersToolStripMenuItem
            // 
            this.employersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employerDetailsToolStripMenuItem});
            this.employersToolStripMenuItem.Name = "employersToolStripMenuItem";
            this.employersToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.employersToolStripMenuItem.Text = "Employers";
            // 
            // employerDetailsToolStripMenuItem
            // 
            this.employerDetailsToolStripMenuItem.Name = "employerDetailsToolStripMenuItem";
            this.employerDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.employerDetailsToolStripMenuItem.Text = "Employer Details";
            this.employerDetailsToolStripMenuItem.Click += new System.EventHandler(this.employerDetailsToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservarionDetailsToolStripMenuItem});
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            // 
            // reservarionDetailsToolStripMenuItem
            // 
            this.reservarionDetailsToolStripMenuItem.Name = "reservarionDetailsToolStripMenuItem";
            this.reservarionDetailsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.reservarionDetailsToolStripMenuItem.Text = "Reservarion Details";
            this.reservarionDetailsToolStripMenuItem.Click += new System.EventHandler(this.reservarionDetailsToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productDetailsToolStripMenuItem,
            this.productsMostSoldToolStripMenuItem,
            this.productsSoldToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // productDetailsToolStripMenuItem
            // 
            this.productDetailsToolStripMenuItem.Name = "productDetailsToolStripMenuItem";
            this.productDetailsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.productDetailsToolStripMenuItem.Text = "Product Details";
            this.productDetailsToolStripMenuItem.Click += new System.EventHandler(this.productDetailsToolStripMenuItem_Click);
            // 
            // productsMostSoldToolStripMenuItem
            // 
            this.productsMostSoldToolStripMenuItem.Name = "productsMostSoldToolStripMenuItem";
            this.productsMostSoldToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.productsMostSoldToolStripMenuItem.Text = "Products Most Sold";
            this.productsMostSoldToolStripMenuItem.Click += new System.EventHandler(this.productsMostSoldToolStripMenuItem_Click);
            // 
            // productsSoldToolStripMenuItem
            // 
            this.productsSoldToolStripMenuItem.Name = "productsSoldToolStripMenuItem";
            this.productsSoldToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.productsSoldToolStripMenuItem.Text = "Products Sold";
            this.productsSoldToolStripMenuItem.Click += new System.EventHandler(this.productsSoldToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerDetailsToolStripMenuItem,
            this.customerSpendingsToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            this.customerDetailsToolStripMenuItem.Click += new System.EventHandler(this.customerDetailsToolStripMenuItem_Click);
            // 
            // customerSpendingsToolStripMenuItem
            // 
            this.customerSpendingsToolStripMenuItem.Name = "customerSpendingsToolStripMenuItem";
            this.customerSpendingsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.customerSpendingsToolStripMenuItem.Text = "Customer Spendings";
            this.customerSpendingsToolStripMenuItem.Click += new System.EventHandler(this.customerSpendingsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 377);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restoran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsMostSoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsSoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerSpendingsToolStripMenuItem;
    }
}