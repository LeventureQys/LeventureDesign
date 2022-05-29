
namespace LeventureDesign
{
    partial class PAsk
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
            this.com_pType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_classid = new System.Windows.Forms.TextBox();
            this.btn_Request = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "试卷类型";
            // 
            // com_pType
            // 
            this.com_pType.FormattingEnabled = true;
            this.com_pType.Items.AddRange(new object[] {
            "小题训练",
            "大题训练",
            "综合试卷"});
            this.com_pType.Location = new System.Drawing.Point(96, 31);
            this.com_pType.Name = "com_pType";
            this.com_pType.Size = new System.Drawing.Size(121, 20);
            this.com_pType.TabIndex = 1;
            this.com_pType.Text = "小题训练";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "申请班级班号 ";
            // 
            // txt_classid
            // 
            this.txt_classid.Location = new System.Drawing.Point(97, 76);
            this.txt_classid.Name = "txt_classid";
            this.txt_classid.Size = new System.Drawing.Size(120, 21);
            this.txt_classid.TabIndex = 5;
            this.txt_classid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_Request
            // 
            this.btn_Request.Location = new System.Drawing.Point(40, 134);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(120, 23);
            this.btn_Request.TabIndex = 7;
            this.btn_Request.Text = "生成试卷";
            this.btn_Request.UseVisualStyleBackColor = true;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // PAsk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 180);
            this.Controls.Add(this.btn_Request);
            this.Controls.Add(this.txt_classid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.com_pType);
            this.Controls.Add(this.label1);
            this.Name = "PAsk";
            this.Text = "试卷申请";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_pType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_classid;
        private System.Windows.Forms.Button btn_Request;
    }
}