
namespace LeventureDesign
{
    partial class TeacherPage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_CommentPaper = new System.Windows.Forms.Button();
            this.btn_TeachAnalyse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(161, 21);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "现在时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "您好 ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_CommentPaper
            // 
            this.btn_CommentPaper.Location = new System.Drawing.Point(12, 92);
            this.btn_CommentPaper.Name = "btn_CommentPaper";
            this.btn_CommentPaper.Size = new System.Drawing.Size(76, 49);
            this.btn_CommentPaper.TabIndex = 9;
            this.btn_CommentPaper.Text = "试卷批改";
            this.btn_CommentPaper.UseVisualStyleBackColor = true;
            this.btn_CommentPaper.Click += new System.EventHandler(this.btn_CommentPaper_Click);
            // 
            // btn_TeachAnalyse
            // 
            this.btn_TeachAnalyse.Location = new System.Drawing.Point(108, 92);
            this.btn_TeachAnalyse.Name = "btn_TeachAnalyse";
            this.btn_TeachAnalyse.Size = new System.Drawing.Size(76, 49);
            this.btn_TeachAnalyse.TabIndex = 10;
            this.btn_TeachAnalyse.Text = "教学分析";
            this.btn_TeachAnalyse.UseVisualStyleBackColor = true;
            this.btn_TeachAnalyse.Click += new System.EventHandler(this.btn_TeachAnalyse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "试卷申请";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 49);
            this.button2.TabIndex = 12;
            this.button2.Text = "排名查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeacherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 187);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_TeachAnalyse);
            this.Controls.Add(this.btn_CommentPaper);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherPage";
            this.Text = "教师界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherPage_FormClosed);
            this.Load += new System.EventHandler(this.TeacherPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_CommentPaper;
        private System.Windows.Forms.Button btn_TeachAnalyse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}