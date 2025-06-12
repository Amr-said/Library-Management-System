namespace Project
{
    partial class StatisticsForm
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
            piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)piechart).BeginInit();
            SuspendLayout();
            // 
            // piechart
            // 
            chartArea1.Name = "ChartArea1";
            piechart.ChartAreas.Add(chartArea1);
            piechart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            piechart.Legends.Add(legend1);
            piechart.Location = new Point(0, 0);
            piechart.Name = "piechart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            piechart.Series.Add(series1);
            piechart.Size = new Size(800, 450);
            piechart.TabIndex = 0;
            piechart.Text = "piechart";
            piechart.Click += piechart_Click;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(piechart);
            Name = "StatisticsForm";
            Text = "Pie Chart ";
            Load += StatisticsForm_Load;
            ((System.ComponentModel.ISupportInitialize)piechart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
    }
}