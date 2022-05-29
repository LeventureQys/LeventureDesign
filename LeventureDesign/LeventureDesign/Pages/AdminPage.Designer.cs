
namespace LeventureDesign
{
    partial class AdminPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Usermanager = new System.Windows.Forms.Button();
            this.btn_ScAnalyse = new System.Windows.Forms.Button();
            this.btn_QsManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "您好 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "现在时间:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(135, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Usermanager
            // 
            this.btn_Usermanager.Location = new System.Drawing.Point(16, 97);
            this.btn_Usermanager.Name = "btn_Usermanager";
            this.btn_Usermanager.Size = new System.Drawing.Size(68, 41);
            this.btn_Usermanager.TabIndex = 3;
            this.btn_Usermanager.Text = "用户管理";
            this.btn_Usermanager.UseVisualStyleBackColor = true;
            this.btn_Usermanager.Click += new System.EventHandler(this.btn_Usermanager_Click);
            // 
            // btn_ScAnalyse
            // 
            this.btn_ScAnalyse.Location = new System.Drawing.Point(125, 97);
            this.btn_ScAnalyse.Name = "btn_ScAnalyse";
            this.btn_ScAnalyse.Size = new System.Drawing.Size(68, 41);
            this.btn_ScAnalyse.TabIndex = 4;
            this.btn_ScAnalyse.Text = "成绩分析";
            this.btn_ScAnalyse.UseVisualStyleBackColor = true;
            this.btn_ScAnalyse.Click += new System.EventHandler(this.btn_ScAnalyse_Click);
            // 
            // btn_QsManager
            // 
            this.btn_QsManager.Location = new System.Drawing.Point(236, 97);
            this.btn_QsManager.Name = "btn_QsManager";
            this.btn_QsManager.Size = new System.Drawing.Size(68, 41);
            this.btn_QsManager.TabIndex = 5;
            this.btn_QsManager.Text = "试题中心";
            this.btn_QsManager.UseVisualStyleBackColor = true;
            this.btn_QsManager.Click += new System.EventHandler(this.btn_QsManager_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 185);
            this.Controls.Add(this.btn_QsManager);
            this.Controls.Add(this.btn_ScAnalyse);
            this.Controls.Add(this.btn_Usermanager);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminPage";
            this.Text = "管理员界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Usermanager;
        private System.Windows.Forms.Button btn_ScAnalyse;
        private System.Windows.Forms.Button btn_QsManager;
    }
}