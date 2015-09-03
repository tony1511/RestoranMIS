namespace RestoranMIS_UI
{
    partial class Frm_Customer_Spendings
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
            this.dgSpendings = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.pickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.pickerTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSpendings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSpendings
            // 
            this.dgSpendings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSpendings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.Username,
            this.TotalSpent,
            this.EMail});
            this.dgSpendings.Location = new System.Drawing.Point(12, 100);
            this.dgSpendings.Name = "dgSpendings";
            this.dgSpendings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSpendings.Size = new System.Drawing.Size(546, 350);
            this.dgSpendings.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "CustomerId";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "First Name";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Last Name";
            this.Prezime.Name = "Prezime";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // TotalSpent
            // 
            this.TotalSpent.DataPropertyName = "TotalSpent";
            this.TotalSpent.HeaderText = "Total Spent";
            this.TotalSpent.Name = "TotalSpent";
            // 
            // EMail
            // 
            this.EMail.DataPropertyName = "EMail";
            this.EMail.HeaderText = "e-Mail";
            this.EMail.Name = "EMail";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 26);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(60, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "First Name:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(184, 26);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(61, 13);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Last Name:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(357, 26);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(78, 23);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(251, 23);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(418, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(124, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(12, 63);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(59, 13);
            this.lblDateFrom.TabIndex = 7;
            this.lblDateFrom.Text = "Date From:";
            // 
            // pickerFrom
            // 
            this.pickerFrom.Location = new System.Drawing.Point(78, 57);
            this.pickerFrom.Name = "pickerFrom";
            this.pickerFrom.Size = new System.Drawing.Size(129, 20);
            this.pickerFrom.TabIndex = 8;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(213, 63);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(49, 13);
            this.lblDateTo.TabIndex = 9;
            this.lblDateTo.Text = "Date To:";
            // 
            // pickerTo
            // 
            this.pickerTo.Location = new System.Drawing.Point(268, 56);
            this.pickerTo.Name = "pickerTo";
            this.pickerTo.Size = new System.Drawing.Size(144, 20);
            this.pickerTo.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(446, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 39);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(470, 462);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Printaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Frm_Customer_Spendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 497);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pickerTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.pickerFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.dgSpendings);
            this.Name = "Frm_Customer_Spendings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Spendings";
            this.Load += new System.EventHandler(this.Frm_Customer_Spendings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSpendings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSpendings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker pickerFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker pickerTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
    }
}