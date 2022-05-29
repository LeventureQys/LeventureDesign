
namespace LeventureDesign 
{
    partial class PLittleTran
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Index = new System.Windows.Forms.Label();
            this.panel_Answer = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lab_Pic = new System.Windows.Forms.Label();
            this.panel_Selection = new System.Windows.Forms.Panel();
            this.rad_D = new System.Windows.Forms.RadioButton();
            this.rad_C = new System.Windows.Forms.RadioButton();
            this.rad_B = new System.Windows.Forms.RadioButton();
            this.rad_A = new System.Windows.Forms.RadioButton();
            this.lab_Chose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lab_QType = new System.Windows.Forms.Label();
            this.lab_WelCome = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_Answer.SuspendLayout();
            this.panel_Selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Index);
            this.panel1.Controls.Add(this.panel_Answer);
            this.panel1.Controls.Add(this.panel_Selection);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 493);
            this.panel1.TabIndex = 0;
            // 
            // txt_Index
            // 
            this.txt_Index.AutoSize = true;
            this.txt_Index.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Index.Location = new System.Drawing.Point(7, 14);
            this.txt_Index.Name = "txt_Index";
            this.txt_Index.Size = new System.Drawing.Size(56, 16);
            this.txt_Index.TabIndex = 6;
            this.txt_Index.Text = "label1";
            // 
            // panel_Answer
            // 
            this.panel_Answer.Controls.Add(this.richTextBox1);
            this.panel_Answer.Controls.Add(this.lab_Pic);
            this.panel_Answer.Location = new System.Drawing.Point(3, 42);
            this.panel_Answer.Name = "panel_Answer";
            this.panel_Answer.Size = new System.Drawing.Size(408, 434);
            this.panel_Answer.TabIndex = 7;
            this.panel_Answer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Answer_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(402, 391);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // lab_Pic
            // 
            this.lab_Pic.AutoSize = true;
            this.lab_Pic.Location = new System.Drawing.Point(1, 11);
            this.lab_Pic.Name = "lab_Pic";
            this.lab_Pic.Size = new System.Drawing.Size(149, 12);
            this.lab_Pic.TabIndex = 5;
            this.lab_Pic.Text = "选择题、填空题请输入文字";
            // 
            // panel_Selection
            // 
            this.panel_Selection.Controls.Add(this.rad_D);
            this.panel_Selection.Controls.Add(this.rad_C);
            this.panel_Selection.Controls.Add(this.rad_B);
            this.panel_Selection.Controls.Add(this.rad_A);
            this.panel_Selection.Controls.Add(this.lab_Chose);
            this.panel_Selection.Location = new System.Drawing.Point(7, 70);
            this.panel_Selection.Name = "panel_Selection";
            this.panel_Selection.Size = new System.Drawing.Size(153, 170);
            this.panel_Selection.TabIndex = 2;
            this.panel_Selection.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Selection_Paint);
            // 
            // rad_D
            // 
            this.rad_D.AutoSize = true;
            this.rad_D.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rad_D.Location = new System.Drawing.Point(13, 112);
            this.rad_D.Name = "rad_D";
            this.rad_D.Size = new System.Drawing.Size(37, 23);
            this.rad_D.TabIndex = 3;
            this.rad_D.Text = "D";
            this.rad_D.UseVisualStyleBackColor = true;
            // 
            // rad_C
            // 
            this.rad_C.AutoSize = true;
            this.rad_C.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rad_C.Location = new System.Drawing.Point(13, 83);
            this.rad_C.Name = "rad_C";
            this.rad_C.Size = new System.Drawing.Size(37, 23);
            this.rad_C.TabIndex = 2;
            this.rad_C.Text = "C";
            this.rad_C.UseVisualStyleBackColor = true;
            // 
            // rad_B
            // 
            this.rad_B.AutoSize = true;
            this.rad_B.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rad_B.Location = new System.Drawing.Point(13, 54);
            this.rad_B.Name = "rad_B";
            this.rad_B.Size = new System.Drawing.Size(37, 23);
            this.rad_B.TabIndex = 1;
            this.rad_B.Text = "B";
            this.rad_B.UseVisualStyleBackColor = true;
            // 
            // rad_A
            // 
            this.rad_A.AutoSize = true;
            this.rad_A.Checked = true;
            this.rad_A.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rad_A.Location = new System.Drawing.Point(13, 25);
            this.rad_A.Name = "rad_A";
            this.rad_A.Size = new System.Drawing.Size(37, 23);
            this.rad_A.TabIndex = 0;
            this.rad_A.TabStop = true;
            this.rad_A.Text = "A";
            this.rad_A.UseVisualStyleBackColor = true;
            // 
            // lab_Chose
            // 
            this.lab_Chose.AutoSize = true;
            this.lab_Chose.Location = new System.Drawing.Point(11, 10);
            this.lab_Chose.Name = "lab_Chose";
            this.lab_Chose.Size = new System.Drawing.Size(65, 12);
            this.lab_Chose.TabIndex = 3;
            this.lab_Chose.Text = "选择题选项";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(414, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(829, 470);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lab_QType
            // 
            this.lab_QType.AutoSize = true;
            this.lab_QType.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_QType.Location = new System.Drawing.Point(724, 40);
            this.lab_QType.Name = "lab_QType";
            this.lab_QType.Size = new System.Drawing.Size(69, 19);
            this.lab_QType.TabIndex = 4;
            this.lab_QType.Text = "label1";
            // 
            // lab_WelCome
            // 
            this.lab_WelCome.AutoSize = true;
            this.lab_WelCome.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_WelCome.Location = new System.Drawing.Point(236, 40);
            this.lab_WelCome.Name = "lab_WelCome";
            this.lab_WelCome.Size = new System.Drawing.Size(69, 19);
            this.lab_WelCome.TabIndex = 1;
            this.lab_WelCome.Text = "label1";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1258, 40);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 524);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll_1);
            // 
            // btn_pre
            // 
            this.btn_pre.Location = new System.Drawing.Point(32, 556);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(75, 23);
            this.btn_pre.TabIndex = 3;
            this.btn_pre.Text = "前一题";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(113, 556);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "后一题";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(949, 556);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 5;
            this.btn_Confirm.Text = "提交答卷";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // PLittleTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 589);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lab_QType);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lab_WelCome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PLittleTran";
            this.Text = "考试界面";
            this.Load += new System.EventHandler(this.PLittleTran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Answer.ResumeLayout(false);
            this.panel_Answer.PerformLayout();
            this.panel_Selection.ResumeLayout(false);
            this.panel_Selection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label lab_WelCome;
        private System.Windows.Forms.Panel panel_Selection;
        private System.Windows.Forms.RadioButton rad_D;
        private System.Windows.Forms.RadioButton rad_C;
        private System.Windows.Forms.RadioButton rad_B;
        private System.Windows.Forms.RadioButton rad_A;
        private System.Windows.Forms.Label lab_QType;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lab_Chose;
        private System.Windows.Forms.Label lab_Pic;
        private System.Windows.Forms.Panel panel_Answer;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label txt_Index;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}