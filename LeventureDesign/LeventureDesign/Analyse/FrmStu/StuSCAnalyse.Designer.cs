
namespace LeventureDesign
{
    partial class StuSCAnalyse
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
            this.lab_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_linear1 = new System.Windows.Forms.Label();
            this.lab_linear2 = new System.Windows.Forms.Label();
            this.lab_linear3 = new System.Windows.Forms.Label();
            this.btn_Weakness = new System.Windows.Forms.Button();
            this.btn_Rank = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "考试次数";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "得分";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 135);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "小题训练";
            series1.Name = "type_1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "大题训练";
            series2.Name = "type_2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "综合训练";
            series3.Name = "type_3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1401, 320);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lab_user
            // 
            this.lab_user.AutoSize = true;
            this.lab_user.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_user.Location = new System.Drawing.Point(16, 30);
            this.lab_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_user.Name = "lab_user";
            this.lab_user.Size = new System.Drawing.Size(99, 20);
            this.lab_user.TabIndex = 1;
            this.lab_user.Text = "您好，xxx";
            this.lab_user.Click += new System.EventHandler(this.lab_user_Click);
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
            // lab_linear1
            // 
            this.lab_linear1.AutoSize = true;
            this.lab_linear1.Location = new System.Drawing.Point(17, 66);
            this.lab_linear1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_linear1.Name = "lab_linear1";
            this.lab_linear1.Size = new System.Drawing.Size(142, 15);
            this.lab_linear1.TabIndex = 3;
            this.lab_linear1.Text = "小题测试的变化趋势";
            // 
            // lab_linear2
            // 
            this.lab_linear2.AutoSize = true;
            this.lab_linear2.Location = new System.Drawing.Point(20, 91);
            this.lab_linear2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_linear2.Name = "lab_linear2";
            this.lab_linear2.Size = new System.Drawing.Size(142, 15);
            this.lab_linear2.TabIndex = 4;
            this.lab_linear2.Text = "大题测试的变化趋势";
            // 
            // lab_linear3
            // 
            this.lab_linear3.AutoSize = true;
            this.lab_linear3.Location = new System.Drawing.Point(20, 116);
            this.lab_linear3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_linear3.Name = "lab_linear3";
            this.lab_linear3.Size = new System.Drawing.Size(142, 15);
            this.lab_linear3.TabIndex = 5;
            this.lab_linear3.Text = "综合测试的变化趋势";
            // 
            // btn_Weakness
            // 
            this.btn_Weakness.Location = new System.Drawing.Point(912, 29);
            this.btn_Weakness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Weakness.Name = "btn_Weakness";
            this.btn_Weakness.Size = new System.Drawing.Size(100, 29);
            this.btn_Weakness.TabIndex = 6;
            this.btn_Weakness.Text = "弱点分析";
            this.btn_Weakness.UseVisualStyleBackColor = true;
            this.btn_Weakness.Click += new System.EventHandler(this.btn_Weakness_Click);
            // 
            // btn_Rank
            // 
            this.btn_Rank.Location = new System.Drawing.Point(1020, 29);
            this.btn_Rank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Rank.Name = "btn_Rank";
            this.btn_Rank.Size = new System.Drawing.Size(100, 29);
            this.btn_Rank.TabIndex = 7;
            this.btn_Rank.Text = "查看排名";
            this.btn_Rank.UseVisualStyleBackColor = true;
            this.btn_Rank.Click += new System.EventHandler(this.btn_Rank_Click);
            // 
            // StuSCAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 470);
            this.Controls.Add(this.btn_Rank);
            this.Controls.Add(this.btn_Weakness);
            this.Controls.Add(this.lab_linear3);
            this.Controls.Add(this.lab_linear2);
            this.Controls.Add(this.lab_linear1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_user);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StuSCAnalyse";
            this.Text = "成绩分析";
            this.Load += new System.EventHandler(this.StuSCAnalyse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lab_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_linear1;
        private System.Windows.Forms.Label lab_linear2;
        private System.Windows.Forms.Label lab_linear3;
        private System.Windows.Forms.Button btn_Weakness;
        private System.Windows.Forms.Button btn_Rank;
    }
}