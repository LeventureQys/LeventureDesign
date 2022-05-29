
namespace LeventureDesign
{
    partial class StudentPage
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
            this.btn_SCManager = new System.Windows.Forms.Button();
            this.btn_JoinTest = new System.Windows.Forms.Button();
            this.btn_paperselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(161, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "现在时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 20);
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
            // btn_SCManager
            // 
            this.btn_SCManager.Location = new System.Drawing.Point(31, 112);
            this.btn_SCManager.Name = "btn_SCManager";
            this.btn_SCManager.Size = new System.Drawing.Size(68, 41);
            this.btn_SCManager.TabIndex = 6;
            this.btn_SCManager.Text = "成绩分析";
            this.btn_SCManager.UseVisualStyleBackColor = true;
            this.btn_SCManager.Click += new System.EventHandler(this.btn_SCManager_Click);
            // 
            // btn_JoinTest
            // 
            this.btn_JoinTest.Location = new System.Drawing.Point(142, 112);
            this.btn_JoinTest.Name = "btn_JoinTest";
            this.btn_JoinTest.Size = new System.Drawing.Size(68, 41);
            this.btn_JoinTest.TabIndex = 7;
            this.btn_JoinTest.Text = "参加考试";
            this.btn_JoinTest.UseVisualStyleBackColor = true;
            this.btn_JoinTest.Click += new System.EventHandler(this.btn_JoinTest_Click);
            // 
            // btn_paperselect
            // 
            this.btn_paperselect.Location = new System.Drawing.Point(255, 112);
            this.btn_paperselect.Name = "btn_paperselect";
            this.btn_paperselect.Size = new System.Drawing.Size(68, 41);
            this.btn_paperselect.TabIndex = 8;
            this.btn_paperselect.Text = "答卷查询";
            this.btn_paperselect.UseVisualStyleBackColor = true;
            this.btn_paperselect.Click += new System.EventHandler(this.btn_paperselect_Click);
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 205);
            this.Controls.Add(this.btn_paperselect);
            this.Controls.Add(this.btn_JoinTest);
            this.Controls.Add(this.btn_SCManager);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentPage";
            this.Text = "学生界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentPage_FormClosed);
            this.Load += new System.EventHandler(this.StudentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_SCManager;
        private System.Windows.Forms.Button btn_JoinTest;
        private System.Windows.Forms.Button btn_paperselect;
    }
}