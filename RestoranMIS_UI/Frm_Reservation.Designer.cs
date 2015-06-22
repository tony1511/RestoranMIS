namespace RestoranMIS_UI
{
    partial class Frm_Reservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.filtrirajButton = new System.Windows.Forms.Button();
            this.reservationGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojStola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.prikaziSveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservationGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter po datumu od :";
            // 
            // dateDatePicker
            // 
            this.dateDatePicker.Location = new System.Drawing.Point(126, 40);
            this.dateDatePicker.Name = "dateDatePicker";
            this.dateDatePicker.Size = new System.Drawing.Size(144, 20);
            this.dateDatePicker.TabIndex = 2;
            // 
            // filtrirajButton
            // 
            this.filtrirajButton.Location = new System.Drawing.Point(306, 26);
            this.filtrirajButton.Name = "filtrirajButton";
            this.filtrirajButton.Size = new System.Drawing.Size(104, 45);
            this.filtrirajButton.TabIndex = 6;
            this.filtrirajButton.Text = "Filtriraj";
            this.filtrirajButton.UseVisualStyleBackColor = true;
            this.filtrirajButton.Click += new System.EventHandler(this.filtrirajButton_Click);
            // 
            // reservationGridView
            // 
            this.reservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Vrijeme,
            this.Ime,
            this.Prezime,
            this.BrOsoba,
            this.ImeRezervacije,
            this.BrojStola});
            this.reservationGridView.Location = new System.Drawing.Point(12, 128);
            this.reservationGridView.Name = "reservationGridView";
            this.reservationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationGridView.Size = new System.Drawing.Size(870, 333);
            this.reservationGridView.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Vrijeme
            // 
            this.Vrijeme.DataPropertyName = "Vrijeme";
            this.Vrijeme.HeaderText = "Datum rezervacije";
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.Width = 180;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.Width = 180;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // BrOsoba
            // 
            this.BrOsoba.DataPropertyName = "BrOsoba";
            this.BrOsoba.HeaderText = "BrOsoba";
            this.BrOsoba.Name = "BrOsoba";
            // 
            // ImeRezervacije
            // 
            this.ImeRezervacije.DataPropertyName = "ImeRezervacije";
            this.ImeRezervacije.HeaderText = "Ime rezervacije";
            this.ImeRezervacije.Name = "ImeRezervacije";
            // 
            // BrojStola
            // 
            this.BrojStola.DataPropertyName = "BrojStola";
            this.BrojStola.HeaderText = "BrojStola";
            this.BrojStola.Name = "BrojStola";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(106, 26);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 45);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Printaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // prikaziSveButton
            // 
            this.prikaziSveButton.Location = new System.Drawing.Point(441, 26);
            this.prikaziSveButton.Name = "prikaziSveButton";
            this.prikaziSveButton.Size = new System.Drawing.Size(101, 45);
            this.prikaziSveButton.TabIndex = 10;
            this.prikaziSveButton.Text = "Prikazi sve";
            this.prikaziSveButton.UseVisualStyleBackColor = true;
            this.prikaziSveButton.Click += new System.EventHandler(this.prikaziSveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.prikaziSveButton);
            this.groupBox1.Controls.Add(this.dateDatePicker);
            this.groupBox1.Controls.Add(this.filtrirajButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter rezervacija";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Location = new System.Drawing.Point(593, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print";
            // 
            // Frm_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reservationGridView);
            this.Name = "Frm_Reservation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.Frm_Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDatePicker;
        private System.Windows.Forms.Button filtrirajButton;
        private System.Windows.Forms.DataGridView reservationGridView;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojStola;
        private System.Windows.Forms.Button prikaziSveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}