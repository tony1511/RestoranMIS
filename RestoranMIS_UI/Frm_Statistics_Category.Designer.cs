﻿namespace RestoranMIS_UI
{
    partial class Frm_Statistics_Category
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_cat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_filtriraj = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cat)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_cat
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_cat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_cat.Legends.Add(legend1);
            this.chart_cat.Location = new System.Drawing.Point(43, 140);
            this.chart_cat.Name = "chart_cat";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Kategorije";
            this.chart_cat.Series.Add(series1);
            this.chart_cat.Size = new System.Drawing.Size(654, 328);
            this.chart_cat.TabIndex = 0;
            this.chart_cat.Text = "Chart Diagram";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(67, 72);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 1;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(307, 71);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filtrirajte po datumu:";
            // 
            // btn_filtriraj
            // 
            this.btn_filtriraj.Location = new System.Drawing.Point(523, 69);
            this.btn_filtriraj.Name = "btn_filtriraj";
            this.btn_filtriraj.Size = new System.Drawing.Size(75, 23);
            this.btn_filtriraj.TabIndex = 6;
            this.btn_filtriraj.Text = "Filtriraj";
            this.btn_filtriraj.UseVisualStyleBackColor = true;
            this.btn_filtriraj.Click += new System.EventHandler(this.btn_filtriraj_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(622, 69);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 7;
            this.btn_Print.Text = "Printaj";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // Frm_Statistics_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 480);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_filtriraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.chart_cat);
            this.Name = "Frm_Statistics_Category";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika Kategorija";
            this.Load += new System.EventHandler(this.Frm_Statistics_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cat;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_filtriraj;
        private System.Windows.Forms.Button btn_Print;
    }
}