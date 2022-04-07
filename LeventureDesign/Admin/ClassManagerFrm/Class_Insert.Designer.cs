
namespace LeventureDesign
{
    partial class Class_Insert
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.Cob_Level = new System.Windows.Forms.ComboBox();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TeacherID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年级";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 34);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "添加班级";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // Cob_Level
            // 
            this.Cob_Level.FormattingEnabled = true;
            this.Cob_Level.Items.AddRange(new object[] {
            "高一",
            "高二",
            "高三"});
            this.Cob_Level.Location = new System.Drawing.Point(139, 36);
            this.Cob_Level.Name = "Cob_Level";
            this.Cob_Level.Size = new System.Drawing.Size(57, 20);
            this.Cob_Level.TabIndex = 2;
            this.Cob_Level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(237, 35);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(60, 21);
            this.txt_Num.TabIndex = 3;
            this.txt_Num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "班号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "教师工号";
            // 
            // txt_TeacherID
            // 
            this.txt_TeacherID.Location = new System.Drawing.Point(362, 36);
            this.txt_TeacherID.Name = "txt_TeacherID";
            this.txt_TeacherID.Size = new System.Drawing.Size(67, 21);
            this.txt_TeacherID.TabIndex = 6;
            this.txt_TeacherID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Class_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 107);
            this.Controls.Add(this.txt_TeacherID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.Cob_Level);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Class_Insert";
            this.Text = "插入班级";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Class_Insert_FormClosed);
            this.Load += new System.EventHandler(this.Class_Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ComboBox Cob_Level;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TeacherID;
    }
}