
namespace LeventureDesign
{
    partial class QMain
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
            this.btn_QManager = new System.Windows.Forms.Button();
            this.btn_PaperMaker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择进入的模块:";
            // 
            // btn_QManager
            // 
            this.btn_QManager.Location = new System.Drawing.Point(49, 69);
            this.btn_QManager.Name = "btn_QManager";
            this.btn_QManager.Size = new System.Drawing.Size(70, 51);
            this.btn_QManager.TabIndex = 1;
            this.btn_QManager.Text = "题库管理";
            this.btn_QManager.UseVisualStyleBackColor = true;
            this.btn_QManager.Click += new System.EventHandler(this.btn_QManager_Click);
            // 
            // btn_PaperMaker
            // 
            this.btn_PaperMaker.Location = new System.Drawing.Point(196, 69);
            this.btn_PaperMaker.Name = "btn_PaperMaker";
            this.btn_PaperMaker.Size = new System.Drawing.Size(70, 51);
            this.btn_PaperMaker.TabIndex = 2;
            this.btn_PaperMaker.Text = "试卷管理";
            this.btn_PaperMaker.UseVisualStyleBackColor = true;
            this.btn_PaperMaker.Click += new System.EventHandler(this.btn_PaperMaker_Click);
            // 
            // QMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 196);
            this.Controls.Add(this.btn_PaperMaker);
            this.Controls.Add(this.btn_QManager);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QMain";
            this.Text = "考试中心";
            this.Load += new System.EventHandler(this.QMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_QManager;
        private System.Windows.Forms.Button btn_PaperMaker;
    }
}