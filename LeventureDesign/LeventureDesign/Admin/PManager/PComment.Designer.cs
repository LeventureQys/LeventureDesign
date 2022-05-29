
namespace LeventureDesign
{
    partial class PComment
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_Sc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Pre = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Confrim = new System.Windows.Forms.Button();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_index = new System.Windows.Forms.Label();
            this.lab_PName = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(832, 470);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 93);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(493, 469);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txt_Sc
            // 
            this.txt_Sc.Location = new System.Drawing.Point(146, 37);
            this.txt_Sc.Name = "txt_Sc";
            this.txt_Sc.Size = new System.Drawing.Size(100, 21);
            this.txt_Sc.TabIndex = 3;
            this.txt_Sc.TextChanged += new System.EventHandler(this.txt_Sc_TextChanged);
            this.txt_Sc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "请对本题评分：";
            // 
            // btn_Pre
            // 
            this.btn_Pre.Location = new System.Drawing.Point(252, 35);
            this.btn_Pre.Name = "btn_Pre";
            this.btn_Pre.Size = new System.Drawing.Size(75, 23);
            this.btn_Pre.TabIndex = 5;
            this.btn_Pre.Text = "上一题";
            this.btn_Pre.UseVisualStyleBackColor = true;
            this.btn_Pre.Click += new System.EventHandler(this.btn_Pre_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(333, 35);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "下一题";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Confrim
            // 
            this.btn_Confrim.Location = new System.Drawing.Point(1285, 594);
            this.btn_Confrim.Name = "btn_Confrim";
            this.btn_Confrim.Size = new System.Drawing.Size(75, 23);
            this.btn_Confrim.TabIndex = 7;
            this.btn_Confrim.Text = "提交";
            this.btn_Confrim.UseVisualStyleBackColor = true;
            this.btn_Confrim.Click += new System.EventHandler(this.btn_Confrim_Click);
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_type.Location = new System.Drawing.Point(525, 39);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(104, 16);
            this.lab_type.TabIndex = 9;
            this.lab_type.Text = "当前试题类型";
            // 
            // lab_index
            // 
            this.lab_index.AutoSize = true;
            this.lab_index.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_index.Location = new System.Drawing.Point(249, 9);
            this.lab_index.Name = "lab_index";
            this.lab_index.Size = new System.Drawing.Size(96, 16);
            this.lab_index.TabIndex = 10;
            this.lab_index.Text = "当前是第x题";
            // 
            // lab_PName
            // 
            this.lab_PName.AutoSize = true;
            this.lab_PName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_PName.Location = new System.Drawing.Point(525, 9);
            this.lab_PName.Name = "lab_PName";
            this.lab_PName.Size = new System.Drawing.Size(72, 16);
            this.lab_PName.TabIndex = 10;
            this.lab_PName.Text = "试卷名称";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1363, 67);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 524);
            this.vScrollBar1.TabIndex = 11;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "学生答案";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(525, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "标准答案";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(523, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 469);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1120, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "完成所有答案批改后提交";
            // 
            // PComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 629);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Sc);
            this.Controls.Add(this.btn_Confrim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.lab_index);
            this.Controls.Add(this.btn_Pre);
            this.Controls.Add(this.lab_PName);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.richTextBox1);
            this.Name = "PComment";
            this.Text = "批改试卷";
            this.Load += new System.EventHandler(this.PComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_Sc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Pre;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Confrim;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_index;
        private System.Windows.Forms.Label lab_PName;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}