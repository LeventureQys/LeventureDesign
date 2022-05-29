
namespace LeventureDesign
{
    partial class WeaknessAnalyse
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "考试科目";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "失分加权值";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "各章节平均失分率";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 29);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "必修1";
            series1.Name = "s1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "必修2";
            series2.Name = "s2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendText = "必修3";
            series3.Name = "s3";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.LegendText = "必修4";
            series4.Name = "s4";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.LegendText = "必修5";
            series5.Name = "s5";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.LegendText = "圆锥曲线";
            series6.Name = "s6";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.LegendText = "导数";
            series7.Name = "s7";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.LegendText = "坐标系与参数方程";
            series8.Name = "s8";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.LegendText = "不等式选讲";
            series9.Name = "s9";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(1093, 511);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "你好xxx，看来你对xx的理解并不理想，还请多多努力";
            // 
            // WeaknessAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WeaknessAnalyse";
            this.Text = "弱点分析";
            this.Load += new System.EventHandler(this.WeaknessAnalyse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
    }
}