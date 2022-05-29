
namespace LeventureDesign
{
    partial class RegeditPage
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_class = new System.Windows.Forms.Label();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.comb_Authortity = new System.Windows.Forms.ComboBox();
            this.txt_classid = new System.Windows.Forms.TextBox();
            this.radb_male = new System.Windows.Forms.RadioButton();
            this.radb_female = new System.Windows.Forms.RadioButton();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(82, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户注册";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(45, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(45, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(45, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(45, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "邮箱";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(45, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "权限";
            // 
            // lab_class
            // 
            this.lab_class.AutoSize = true;
            this.lab_class.Enabled = false;
            this.lab_class.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_class.Location = new System.Drawing.Point(25, 316);
            this.lab_class.Name = "lab_class";
            this.lab_class.Size = new System.Drawing.Size(67, 19);
            this.lab_class.TabIndex = 6;
            this.lab_class.Text = "班级ID";
            // 
            // txt_Account
            // 
            this.txt_Account.Location = new System.Drawing.Point(113, 77);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(121, 21);
            this.txt_Account.TabIndex = 7;
            this.txt_Account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Account_KeyPress);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(113, 110);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(121, 21);
            this.txt_Password.TabIndex = 8;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(113, 216);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(121, 21);
            this.txt_Email.TabIndex = 9;
            this.txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Email_KeyPress);
            // 
            // comb_Authortity
            // 
            this.comb_Authortity.FormattingEnabled = true;
            this.comb_Authortity.Items.AddRange(new object[] {
            "教师",
            "学生",
            "管理员"});
            this.comb_Authortity.Location = new System.Drawing.Point(113, 252);
            this.comb_Authortity.Name = "comb_Authortity";
            this.comb_Authortity.Size = new System.Drawing.Size(121, 20);
            this.comb_Authortity.TabIndex = 10;
            this.comb_Authortity.Text = "教师";
            this.comb_Authortity.SelectedIndexChanged += new System.EventHandler(this.comb_Authortity_SelectedIndexChanged);
            // 
            // txt_classid
            // 
            this.txt_classid.Enabled = false;
            this.txt_classid.Location = new System.Drawing.Point(113, 314);
            this.txt_classid.Name = "txt_classid";
            this.txt_classid.Size = new System.Drawing.Size(121, 21);
            this.txt_classid.TabIndex = 11;
            this.txt_classid.Text = "0";
            this.txt_classid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_classid_KeyPress);
            // 
            // radb_male
            // 
            this.radb_male.AutoSize = true;
            this.radb_male.Checked = true;
            this.radb_male.Location = new System.Drawing.Point(113, 180);
            this.radb_male.Name = "radb_male";
            this.radb_male.Size = new System.Drawing.Size(35, 16);
            this.radb_male.TabIndex = 12;
            this.radb_male.TabStop = true;
            this.radb_male.Text = "男";
            this.radb_male.UseVisualStyleBackColor = true;
            // 
            // radb_female
            // 
            this.radb_female.AutoSize = true;
            this.radb_female.Location = new System.Drawing.Point(199, 180);
            this.radb_female.Name = "radb_female";
            this.radb_female.Size = new System.Drawing.Size(35, 16);
            this.radb_female.TabIndex = 13;
            this.radb_female.TabStop = true;
            this.radb_female.Text = "女";
            this.radb_female.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(61, 356);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(149, 23);
            this.btn_confirm.TabIndex = 14;
            this.btn_confirm.Text = "提交申请";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(45, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "姓名";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(113, 287);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(121, 21);
            this.txt_Name.TabIndex = 16;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(7, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "确认密码";
            // 
            // txt_confirm
            // 
            this.txt_confirm.Location = new System.Drawing.Point(113, 136);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.PasswordChar = '*';
            this.txt_confirm.Size = new System.Drawing.Size(121, 21);
            this.txt_confirm.TabIndex = 18;
            this.txt_confirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_confirm_KeyPress);
            // 
            // RegeditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 408);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.radb_female);
            this.Controls.Add(this.radb_male);
            this.Controls.Add(this.txt_classid);
            this.Controls.Add(this.comb_Authortity);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.lab_class);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegeditPage";
            this.Text = "用户注册";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegeditPage_FormClosed);
            this.Load += new System.EventHandler(this.Regedit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_class;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.ComboBox comb_Authortity;
        private System.Windows.Forms.TextBox txt_classid;
        private System.Windows.Forms.RadioButton radb_male;
        private System.Windows.Forms.RadioButton radb_female;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_confirm;
    }
}