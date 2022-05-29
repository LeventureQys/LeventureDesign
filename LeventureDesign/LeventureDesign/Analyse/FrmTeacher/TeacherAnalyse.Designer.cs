
namespace LeventureDesign
{
    partial class TeacherAnalyse
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Weakness = new System.Windows.Forms.Button();
            this.btn_Rank = new System.Windows.Forms.Button();
            this.lab_points = new System.Windows.Forms.Label();
            this.lab_1 = new System.Windows.Forms.Label();
            this.lab_2 = new System.Windows.Forms.Label();
            this.lab_3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "考试次数";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "平均得分";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 131);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "小题训练";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series1.Name = "s1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "大题训练";
            series2.MarkerBorderColor = System.Drawing.Color.Black;
            series2.MarkerColor = System.Drawing.Color.Black;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series2.Name = "s2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "综合训练";
            series3.MarkerBorderColor = System.Drawing.Color.Black;
            series3.MarkerColor = System.Drawing.Color.Black;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series3.Name = "s3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1401, 320);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // btn_Weakness
            // 
            this.btn_Weakness.Location = new System.Drawing.Point(29, 29);
            this.btn_Weakness.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Weakness.Name = "btn_Weakness";
            this.btn_Weakness.Size = new System.Drawing.Size(100, 29);
            this.btn_Weakness.TabIndex = 6;
            this.btn_Weakness.Text = "弱点分析";
            this.btn_Weakness.UseVisualStyleBackColor = true;
            this.btn_Weakness.Click += new System.EventHandler(this.btn_Weakness_Click);
            // 
            // btn_Rank
            // 
            this.btn_Rank.Location = new System.Drawing.Point(159, 29);
            this.btn_Rank.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Rank.Name = "btn_Rank";
            this.btn_Rank.Size = new System.Drawing.Size(100, 29);
            this.btn_Rank.TabIndex = 7;
            this.btn_Rank.Text = "查看排名";
            this.btn_Rank.UseVisualStyleBackColor = true;
            this.btn_Rank.Click += new System.EventHandler(this.btn_Rank_Click);
            // 
            // lab_points
            // 
            this.lab_points.AutoSize = true;
            this.lab_points.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_points.Location = new System.Drawing.Point(278, 38);
            this.lab_points.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_points.Name = "lab_points";
            this.lab_points.Size = new System.Drawing.Size(229, 20);
            this.lab_points.TabIndex = 8;
            this.lab_points.Text = "该班级目前的成长趋势：";
            // 
            // lab_1
            // 
            this.lab_1.AutoSize = true;
            this.lab_1.Location = new System.Drawing.Point(510, 44);
            this.lab_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_1.Name = "lab_1";
            this.lab_1.Size = new System.Drawing.Size(67, 15);
            this.lab_1.TabIndex = 9;
            this.lab_1.Text = "小题训练";
            // 
            // lab_2
            // 
            this.lab_2.AutoSize = true;
            this.lab_2.Location = new System.Drawing.Point(510, 70);
            this.lab_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_2.Name = "lab_2";
            this.lab_2.Size = new System.Drawing.Size(67, 15);
            this.lab_2.TabIndex = 10;
            this.lab_2.Text = "大题训练";
            // 
            // lab_3
            // 
            this.lab_3.AutoSize = true;
            this.lab_3.Location = new System.Drawing.Point(510, 96);
            this.lab_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_3.Name = "lab_3";
            this.lab_3.Size = new System.Drawing.Size(67, 15);
            this.lab_3.TabIndex = 11;
            this.lab_3.Text = "综合训练";
            // 
            // TeacherAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 470);
            this.Controls.Add(this.lab_3);
            this.Controls.Add(this.lab_2);
            this.Controls.Add(this.lab_1);
            this.Controls.Add(this.lab_points);
            this.Controls.Add(this.btn_Rank);
            this.Controls.Add(this.btn_Weakness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeacherAnalyse";
            this.Text = "成绩分析";
            this.Load += new System.EventHandler(this.StuSCAnalyse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Weakness;
        private System.Windows.Forms.Button btn_Rank;
        private System.Windows.Forms.Label lab_points;
        private System.Windows.Forms.Label lab_1;
        private System.Windows.Forms.Label lab_2;
        private System.Windows.Forms.Label lab_3;
    }
}