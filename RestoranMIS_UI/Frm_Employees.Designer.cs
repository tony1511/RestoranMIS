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
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmployees
            // 
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Location = new System.Drawing.Point(12, 12);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.Size = new System.Drawing.Size(1105, 415);
            this.dgEmployees.TabIndex = 0;
            // 
            // Frm_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 439);
            this.Controls.Add(this.dgEmployees);
            this.Name = "Frm_Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Frm_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployees;
    }
}

