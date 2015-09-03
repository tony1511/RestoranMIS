namespace RestoranMIS_UI.Reports
{
    partial class frmCustomerSpendingReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSSpendingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DSSpendingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SpendingsDS";
            reportDataSource1.Value = this.DSSpendingsBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "RestoranMIS_UI.Reports.rptCustomerSpending.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(803, 495);
            this.reportViewer.TabIndex = 0;
            // 
            // DSSpendingsBindingSource
            // 
            this.DSSpendingsBindingSource.DataMember = "CustomerSpendings";
            this.DSSpendingsBindingSource.DataSource = typeof(RestoranMIS_DAL.DSSpendings);
            // 
            // frmCustomerSpendingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 495);
            this.Controls.Add(this.reportViewer);
            this.Name = "frmCustomerSpendingReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer spending report";
            this.Load += new System.EventHandler(this.frmCustomerSpendingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSSpendingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource DSSpendingsBindingSource;
    }
}