
namespace LeventureDesign
{
    partial class AnalyseMain
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
            this.panel_TandA = new System.Windows.Forms.Panel();
            this.btn_CheckAnswer = new System.Windows.Forms.Button();
            this.btn_RankCheck = new System.Windows.Forms.Button();
            this.btn_TeacherSituation = new System.Windows.Forms.Button();
            this.btn_ScStu = new System.Windows.Forms.Button();
            this.panel_TandA.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(135, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "现在时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "您好 ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_TandA
            // 
            this.panel_TandA.Controls.Add(this.btn_CheckAnswer);
            this.panel_TandA.Controls.Add(this.btn_RankCheck);
            this.panel_TandA.Controls.Add(this.btn_TeacherSituation);
            this.panel_TandA.Controls.Add(this.btn_ScStu);
            this.panel_TandA.Location = new System.Drawing.Point(16, 86);
            this.panel_TandA.Name = "panel_TandA";
            this.panel_TandA.Size = new System.Drawing.Size(447, 87);
            this.panel_TandA.TabIndex = 6;
            // 
            // btn_CheckAnswer
            // 
            this.btn_CheckAnswer.Location = new System.Drawing.Point(357, 16);
            this.btn_CheckAnswer.Name = "btn_CheckAnswer";
            this.btn_CheckAnswer.Size = new System.Drawing.Size(61, 44);
            this.btn_CheckAnswer.TabIndex = 4;
            this.btn_CheckAnswer.Text = "答卷查看";
            this.btn_CheckAnswer.UseVisualStyleBackColor = true;
            this.btn_CheckAnswer.Click += new System.EventHandler(this.btn_CheckAnswer_Click);
            // 
            // btn_RankCheck
            // 
            this.btn_RankCheck.Location = new System.Drawing.Point(127, 16);
            this.btn_RankCheck.Name = "btn_RankCheck";
            this.btn_RankCheck.Size = new System.Drawing.Size(61, 44);
            this.btn_RankCheck.TabIndex = 3;
            this.btn_RankCheck.Text = "排名查询";
            this.btn_RankCheck.UseVisualStyleBackColor = true;
            this.btn_RankCheck.Click += new System.EventHandler(this.btn_RankCheck_Click);
            // 
            // btn_TeacherSituation
            // 
            this.btn_TeacherSituation.Location = new System.Drawing.Point(242, 16);
            this.btn_TeacherSituation.Name = "btn_TeacherSituation";
            this.btn_TeacherSituation.Size = new System.Drawing.Size(61, 44);
            this.btn_TeacherSituation.TabIndex = 2;
            this.btn_TeacherSituation.Text = "老师教学";
            this.btn_TeacherSituation.UseVisualStyleBackColor = true;
            this.btn_TeacherSituation.Click += new System.EventHandler(this.btn_TeacherSituation_Click);
            // 
            // btn_ScStu
            // 
            this.btn_ScStu.Location = new System.Drawing.Point(12, 16);
            this.btn_ScStu.Name = "btn_ScStu";
            this.btn_ScStu.Size = new System.Drawing.Size(61, 44);
            this.btn_ScStu.TabIndex = 1;
            this.btn_ScStu.Text = "学生成绩";
            this.btn_ScStu.UseVisualStyleBackColor = true;
            this.btn_ScStu.Click += new System.EventHandler(this.btn_ScStu_Click);
            // 
            // AnalyseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 209);
            this.Controls.Add(this.panel_TandA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnalyseMain";
            this.Text = "成绩管理中心";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalyseMain_FormClosed);
            this.Load += new System.EventHandler(this.AnalyseMain_Load);
            this.panel_TandA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_TandA;
        private System.Windows.Forms.Button btn_ScStu;
        private System.Windows.Forms.Button btn_RankCheck;
        private System.Windows.Forms.Button btn_TeacherSituation;
        private System.Windows.Forms.Button btn_CheckAnswer;
    }
}