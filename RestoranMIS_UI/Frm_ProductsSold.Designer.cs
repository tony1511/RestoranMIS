namespace RestoranMIS_UI
{
    partial class Frm_ProductsSold
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
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifraProizvoda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SifraProizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDatum = new System.Windows.Forms.RadioButton();
            this.rbBezDatuma = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SifraProizvoda,
            this.Naziv,
            this.Kolicina,
            this.Cijena,
            this.Datum,
            this.Vrijeme});
            this.dgvProizvodi.Location = new System.Drawing.Point(12, 204);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(875, 345);
            this.dgvProizvodi.TabIndex = 11;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(440, 16);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(99, 48);
            this.btnFiltriraj.TabIndex = 10;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(237, 44);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(140, 20);
            this.dpDate.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pretraga po datumu :";
            // 
            // txtSifraProizvoda
            // 
            this.txtSifraProizvoda.Location = new System.Drawing.Point(11, 49);
            this.txtSifraProizvoda.Name = "txtSifraProizvoda";
            this.txtSifraProizvoda.Size = new System.Drawing.Size(130, 20);
            this.txtSifraProizvoda.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pretraga po šifri proizvoda :";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ProizvodID";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // SifraProizvoda
            // 
            this.SifraProizvoda.DataPropertyName = "SifraProizvoda";
            this.SifraProizvoda.HeaderText = "Sifra proizvoda";
            this.SifraProizvoda.Name = "SifraProizvoda";
            this.SifraProizvoda.Width = 150;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 250;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Vrijeme
            // 
            this.Vrijeme.DataPropertyName = "Vrijeme";
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.Name = "Vrijeme";
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(440, 76);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(99, 48);
            this.btnPrikaziSve.TabIndex = 12;
            this.btnPrikaziSve.Text = "Prikazi sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBezDatuma);
            this.groupBox1.Controls.Add(this.btnPrikaziSve);
            this.groupBox1.Controls.Add(this.rbDatum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFiltriraj);
            this.groupBox1.Controls.Add(this.txtSifraProizvoda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dpDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 130);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter proizvoda";
            // 
            // rbDatum
            // 
            this.rbDatum.AutoSize = true;
            this.rbDatum.Location = new System.Drawing.Point(64, 95);
            this.rbDatum.Name = "rbDatum";
            this.rbDatum.Size = new System.Drawing.Size(84, 17);
            this.rbDatum.TabIndex = 10;
            this.rbDatum.TabStop = true;
            this.rbDatum.Text = "Sa datumom";
            this.rbDatum.UseVisualStyleBackColor = true;
            // 
            // rbBezDatuma
            // 
            this.rbBezDatuma.AutoSize = true;
            this.rbBezDatuma.Location = new System.Drawing.Point(213, 95);
            this.rbBezDatuma.Name = "rbBezDatuma";
            this.rbBezDatuma.Size = new System.Drawing.Size(81, 17);
            this.rbBezDatuma.TabIndex = 11;
            this.rbBezDatuma.TabStop = true;
            this.rbBezDatuma.Text = "Bez datuma";
            this.rbBezDatuma.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Location = new System.Drawing.Point(581, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 129);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printanje ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(105, 43);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 48);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Printaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Frm_ProductsSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProizvodi);
            this.Name = "Frm_ProductsSold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodani proizvodi";
            this.Load += new System.EventHandler(this.Frm_ProductsSold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SifraProizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifraProizvoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBezDatuma;
        private System.Windows.Forms.RadioButton rbDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
    }
}