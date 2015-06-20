namespace RestoranMIS_UI
{
    partial class Frm_OnlineOrders
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgOrderDetails = new System.Windows.Forms.DataGridView();
            this.SifraProizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarudzbee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtrirajButton = new System.Windows.Forms.Button();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateStartPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(603, 471);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 23);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Printaj racun";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Detalji narudzbe :";
            // 
            // dgOrderDetails
            // 
            this.dgOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SifraProizvoda,
            this.Naziv,
            this.Cijena,
            this.Kolicina,
            this.UkupnaCijena,
            this.DatumNarudzbee});
            this.dgOrderDetails.Location = new System.Drawing.Point(38, 285);
            this.dgOrderDetails.Name = "dgOrderDetails";
            this.dgOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderDetails.Size = new System.Drawing.Size(648, 173);
            this.dgOrderDetails.TabIndex = 15;
            // 
            // SifraProizvoda
            // 
            this.SifraProizvoda.DataPropertyName = "SifraProizvoda";
            this.SifraProizvoda.HeaderText = "SifraProizvoda";
            this.SifraProizvoda.Name = "SifraProizvoda";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Ukupno";
            this.UkupnaCijena.Name = "UkupnaCijena";
            // 
            // DatumNarudzbee
            // 
            this.DatumNarudzbee.DataPropertyName = "DatumNarudzbe";
            this.DatumNarudzbee.HeaderText = "Datum narudzbe";
            this.DatumNarudzbee.Name = "DatumNarudzbee";
            // 
            // filtrirajButton
            // 
            this.filtrirajButton.Location = new System.Drawing.Point(544, 26);
            this.filtrirajButton.Name = "filtrirajButton";
            this.filtrirajButton.Size = new System.Drawing.Size(101, 23);
            this.filtrirajButton.TabIndex = 14;
            this.filtrirajButton.Text = "Filtriraj";
            this.filtrirajButton.UseVisualStyleBackColor = true;
            this.filtrirajButton.Click += new System.EventHandler(this.filtrirajButton_Click);
            // 
            // ordersGridView
            // 
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DatumNarudzbe,
            this.VrijemeNarudzbe,
            this.Ukupno});
            this.ordersGridView.Location = new System.Drawing.Point(37, 77);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersGridView.Size = new System.Drawing.Size(649, 150);
            this.ordersGridView.TabIndex = 13;
            this.ordersGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersGridView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // DatumNarudzbe
            // 
            this.DatumNarudzbe.DataPropertyName = "DatumNarudzbe";
            this.DatumNarudzbe.HeaderText = "Datum narudzbe";
            this.DatumNarudzbe.Name = "DatumNarudzbe";
            this.DatumNarudzbe.Width = 180;
            // 
            // VrijemeNarudzbe
            // 
            this.VrijemeNarudzbe.DataPropertyName = "VrijemeNarudzbe";
            this.VrijemeNarudzbe.HeaderText = "Vrijeme narudzbe";
            this.VrijemeNarudzbe.Name = "VrijemeNarudzbe";
            this.VrijemeNarudzbe.Width = 180;
            // 
            // Ukupno
            // 
            this.Ukupno.DataPropertyName = "Ukupno";
            this.Ukupno.HeaderText = "Ukupno";
            this.Ukupno.Name = "Ukupno";
            // 
            // dateEndPicker
            // 
            this.dateEndPicker.Location = new System.Drawing.Point(372, 26);
            this.dateEndPicker.Name = "dateEndPicker";
            this.dateEndPicker.Size = new System.Drawing.Size(143, 20);
            this.dateEndPicker.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "do :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter po datumu od :";
            // 
            // dateStartPicker
            // 
            this.dateStartPicker.Location = new System.Drawing.Point(179, 26);
            this.dateStartPicker.Name = "dateStartPicker";
            this.dateStartPicker.Size = new System.Drawing.Size(144, 20);
            this.dateStartPicker.TabIndex = 9;
            // 
            // Frm_OnlineOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 525);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgOrderDetails);
            this.Controls.Add(this.filtrirajButton);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.dateEndPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateStartPicker);
            this.Name = "Frm_OnlineOrders";
            this.Text = "Online narudžbe";
            this.Load += new System.EventHandler(this.Frm_OnlineOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn SifraProizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarudzbee;
        private System.Windows.Forms.Button filtrirajButton;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupno;
        private System.Windows.Forms.DateTimePicker dateEndPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStartPicker;
    }
}