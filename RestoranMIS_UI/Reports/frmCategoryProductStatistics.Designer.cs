﻿namespace RestoranMIS_UI.Reports
{
    partial class frmCategoryProductStatistics
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsCategoryProductStatisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoryProductStatisticsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(776, 581);
            this.reportViewer.TabIndex = 0;
            // 
            // dsCategoryProductStatisticsBindingSource
            // 
            this.dsCategoryProductStatisticsBindingSource.DataSource = typeof(RestoranMIS_DAL.DSStatisticOrdersByCategory);
            this.dsCategoryProductStatisticsBindingSource.Position = 0;
            // 
            // frmCategoryProductStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 581);
            this.Controls.Add(this.reportViewer);
            this.Name = "frmCategoryProductStatistics";
            this.Text = "Izvjestaj";
            this.Load += new System.EventHandler(this.frmCategoryProductStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoryProductStatisticsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource dsCategoryProductStatisticsBindingSource;
    }
}