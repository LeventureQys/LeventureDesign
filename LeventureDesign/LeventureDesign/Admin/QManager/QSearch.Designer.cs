
namespace LeventureDesign
{
    partial class QSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btn_Search = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comb_Chapter = new System.Windows.Forms.ComboBox();
            this.comb_Belong = new System.Windows.Forms.ComboBox();
            this.txt_Qno = new System.Windows.Forms.TextBox();
            this.btn_Access = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(655, 229);
            this.dataGridView1.TabIndex = 1;
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(218, 31);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(201, 21);
            this.txt_Path.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入查询内容:";
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(56, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "题号";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "请选择查询方式";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(109, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "题目类型";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(186, 6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 16);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "所属章节";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(152, 30);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(51, 23);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "浏览...";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // radioButton4
            // 
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 6);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 16);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "图片";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(152, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 25);
            this.panel1.TabIndex = 10;
            // 
            // comb_Chapter
            // 
            this.comb_Chapter.FormattingEnabled = true;
            this.comb_Chapter.Items.AddRange(new object[] {
            "必修1",
            "必修2",
            "必修3",
            "必修4",
            "必修5",
            "选修-圆锥曲线",
            "选修-导数",
            "选修-参数方程",
            "选修-不等式选讲"});
            this.comb_Chapter.Location = new System.Drawing.Point(152, 31);
            this.comb_Chapter.Name = "comb_Chapter";
            this.comb_Chapter.Size = new System.Drawing.Size(121, 20);
            this.comb_Chapter.TabIndex = 11;
            this.comb_Chapter.Text = "必修1";
            this.comb_Chapter.Visible = false;
            this.comb_Chapter.SelectedIndexChanged += new System.EventHandler(this.comb_Chapter_SelectedIndexChanged);
            // 
            // comb_Belong
            // 
            this.comb_Belong.FormattingEnabled = true;
            this.comb_Belong.Items.AddRange(new object[] {
            "选择题",
            "填空题",
            "问答题",
            "选做题"});
            this.comb_Belong.Location = new System.Drawing.Point(152, 31);
            this.comb_Belong.Name = "comb_Belong";
            this.comb_Belong.Size = new System.Drawing.Size(121, 20);
            this.comb_Belong.TabIndex = 12;
            this.comb_Belong.Text = "选择题";
            this.comb_Belong.Visible = false;
            // 
            // txt_Qno
            // 
            this.txt_Qno.Location = new System.Drawing.Point(152, 31);
            this.txt_Qno.Name = "txt_Qno";
            this.txt_Qno.Size = new System.Drawing.Size(100, 21);
            this.txt_Qno.TabIndex = 13;
            this.txt_Qno.TextChanged += new System.EventHandler(this.txt_Qno_TextChanged);
            this.txt_Qno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qno_KeyPress);
            // 
            // btn_Access
            // 
            this.btn_Access.Location = new System.Drawing.Point(425, 30);
            this.btn_Access.Name = "btn_Access";
            this.btn_Access.Size = new System.Drawing.Size(75, 23);
            this.btn_Access.TabIndex = 14;
            this.btn_Access.Text = "查询";
            this.btn_Access.UseVisualStyleBackColor = true;
            this.btn_Access.Click += new System.EventHandler(this.btn_Access_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Access);
            this.Controls.Add(this.txt_Qno);
            this.Controls.Add(this.comb_Belong);
            this.Controls.Add(this.comb_Chapter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QSearch";
            this.Text = "查找试题";
            this.Load += new System.EventHandler(this.QSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comb_Chapter;
        private System.Windows.Forms.ComboBox comb_Belong;
        private System.Windows.Forms.TextBox txt_Qno;
        private System.Windows.Forms.Button btn_Access;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}