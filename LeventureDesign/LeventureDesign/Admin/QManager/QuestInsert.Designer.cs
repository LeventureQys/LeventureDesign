
namespace LeventureDesign
{
    partial class QuestInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Path1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comb_Answer = new System.Windows.Forms.ComboBox();
            this.btn_Search2 = new System.Windows.Forms.Button();
            this.txt_Path2 = new System.Windows.Forms.TextBox();
            this.btn_QAccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "试题图片";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(71, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(51, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "浏览...";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Path1
            // 
            this.txt_Path1.Location = new System.Drawing.Point(128, 20);
            this.txt_Path1.Name = "txt_Path1";
            this.txt_Path1.ReadOnly = true;
            this.txt_Path1.Size = new System.Drawing.Size(197, 21);
            this.txt_Path1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "试题章节";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "必修1",
            "必修2",
            "必修3",
            "必修4",
            "必修5",
            "选修-圆锥曲线",
            "选修-导数",
            "选修-参数方程",
            "选修-不等式选讲"});
            this.comboBox2.Location = new System.Drawing.Point(128, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(66, 20);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "必修1";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "试题类型";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1-9 选择题容易题",
            "10-12 选择题较难题",
            "13-14 填空题容易题",
            "15-16 选择题较难题",
            "17 三角函数\\平面几何",
            "18 立体几何",
            "19 统计大题",
            "20 圆锥曲线",
            "21 导数大题",
            "22 坐标系与参数方程",
            "23 不等式选讲"});
            this.comboBox3.Location = new System.Drawing.Point(128, 97);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(102, 20);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Text = "1-9 选择题容易题";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "试题答案:";
            // 
            // comb_Answer
            // 
            this.comb_Answer.FormattingEnabled = true;
            this.comb_Answer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comb_Answer.Location = new System.Drawing.Point(128, 134);
            this.comb_Answer.Name = "comb_Answer";
            this.comb_Answer.Size = new System.Drawing.Size(66, 20);
            this.comb_Answer.TabIndex = 10;
            this.comb_Answer.Text = "A";
            // 
            // btn_Search2
            // 
            this.btn_Search2.Enabled = false;
            this.btn_Search2.Location = new System.Drawing.Point(71, 160);
            this.btn_Search2.Name = "btn_Search2";
            this.btn_Search2.Size = new System.Drawing.Size(51, 23);
            this.btn_Search2.TabIndex = 11;
            this.btn_Search2.Text = "浏览...";
            this.btn_Search2.UseVisualStyleBackColor = true;
            this.btn_Search2.Click += new System.EventHandler(this.btn_Search2_Click);
            // 
            // txt_Path2
            // 
            this.txt_Path2.Enabled = false;
            this.txt_Path2.Location = new System.Drawing.Point(128, 160);
            this.txt_Path2.Name = "txt_Path2";
            this.txt_Path2.ReadOnly = true;
            this.txt_Path2.Size = new System.Drawing.Size(197, 21);
            this.txt_Path2.TabIndex = 12;
            // 
            // btn_QAccess
            // 
            this.btn_QAccess.Location = new System.Drawing.Point(39, 205);
            this.btn_QAccess.Name = "btn_QAccess";
            this.btn_QAccess.Size = new System.Drawing.Size(191, 23);
            this.btn_QAccess.TabIndex = 13;
            this.btn_QAccess.Text = "提交";
            this.btn_QAccess.UseVisualStyleBackColor = true;
            this.btn_QAccess.Click += new System.EventHandler(this.btn_QAccess_Click);
            // 
            // QuestInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 269);
            this.Controls.Add(this.btn_QAccess);
            this.Controls.Add(this.txt_Path2);
            this.Controls.Add(this.btn_Search2);
            this.Controls.Add(this.comb_Answer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Path1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.Name = "QuestInsert";
            this.Text = "试题插入";
            this.Load += new System.EventHandler(this.QuestInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Path1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comb_Answer;
        private System.Windows.Forms.Button btn_Search2;
        private System.Windows.Forms.TextBox txt_Path2;
        private System.Windows.Forms.Button btn_QAccess;
    }
}