namespace florarie
{
    partial class Grafic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafic));
            this.comenziChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbInchide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.comenziChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInchide)).BeginInit();
            this.SuspendLayout();
            // 
            // comenziChart
            // 
            chartArea2.Name = "ChartArea1";
            this.comenziChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.comenziChart.Legends.Add(legend2);
            this.comenziChart.Location = new System.Drawing.Point(0, 0);
            this.comenziChart.Name = "comenziChart";
            this.comenziChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Comenzi";
            this.comenziChart.Series.Add(series2);
            this.comenziChart.Size = new System.Drawing.Size(1266, 617);
            this.comenziChart.TabIndex = 0;
            this.comenziChart.Text = "chart1";
            this.comenziChart.Click += new System.EventHandler(this.comenziChart_Click);
            // 
            // pbInchide
            // 
            this.pbInchide.BackColor = System.Drawing.Color.White;
            this.pbInchide.Image = ((System.Drawing.Image)(resources.GetObject("pbInchide.Image")));
            this.pbInchide.Location = new System.Drawing.Point(1210, 0);
            this.pbInchide.Name = "pbInchide";
            this.pbInchide.Size = new System.Drawing.Size(56, 37);
            this.pbInchide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInchide.TabIndex = 4;
            this.pbInchide.TabStop = false;
            this.pbInchide.Click += new System.EventHandler(this.pbIesire_Click);
            // 
            // Grafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 617);
            this.Controls.Add(this.pbInchide);
            this.Controls.Add(this.comenziChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grafic";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafic";
            this.Load += new System.EventHandler(this.Grafic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comenziChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInchide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart comenziChart;
        private System.Windows.Forms.PictureBox pbInchide;
    }
}