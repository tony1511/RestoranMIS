namespace RestoranMIS_UI
{
    partial class Frm_Employees
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
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrRadneKnjizice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrZiroRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZaposlenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmployees
            // 
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Username,
            this.JMBG,
            this.Adresa,
            this.BrTelefona,
            this.BrRadneKnjizice,
            this.Plata,
            this.BrZiroRacuna,
            this.DatumZaposlenja,
            this.EMail});
            this.dgEmployees.Location = new System.Drawing.Point(12, 12);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.Size = new System.Drawing.Size(1115, 415);
            this.dgEmployees.TabIndex = 0;
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
            // JMBG
            // 
            this.JMBG.DataPropertyName = "Jmbg";
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Address";
            this.Adresa.Name = "Adresa";
            // 
            // BrTelefona
            // 
            this.BrTelefona.DataPropertyName = "BrTelefona";
            this.BrTelefona.HeaderText = "Phone Number";
            this.BrTelefona.Name = "BrTelefona";
            // 
            // BrRadneKnjizice
            // 
            this.BrRadneKnjizice.DataPropertyName = "BrRadneKnjizice";
            this.BrRadneKnjizice.HeaderText = "Work ID";
            this.BrRadneKnjizice.Name = "BrRadneKnjizice";
            // 
            // Plata
            // 
            this.Plata.DataPropertyName = "Plata";
            this.Plata.HeaderText = "Pay";
            this.Plata.Name = "Plata";
            // 
            // BrZiroRacuna
            // 
            this.BrZiroRacuna.DataPropertyName = "BrZiroRacuna";
            this.BrZiroRacuna.HeaderText = "Bank account num";
            this.BrZiroRacuna.Name = "BrZiroRacuna";
            // 
            // DatumZaposlenja
            // 
            this.DatumZaposlenja.DataPropertyName = "DatumZaposlenja";
            this.DatumZaposlenja.HeaderText = "Employment date";
            this.DatumZaposlenja.Name = "DatumZaposlenja";
            // 
            // EMail
            // 
            this.EMail.DataPropertyName = "EMail";
            this.EMail.HeaderText = "e-Mail";
            this.EMail.Name = "EMail";
            // 
            // Frm_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 439);
            this.Controls.Add(this.dgEmployees);
            this.Name = "Frm_Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Frm_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrRadneKnjizice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plata;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrZiroRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZaposlenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
    }
}

