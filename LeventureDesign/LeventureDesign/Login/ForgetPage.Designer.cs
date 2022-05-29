
namespace LeventureDesign
{
    partial class ForgetPage
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
            
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.rabt_male = new System.Windows.Forms.RadioButton();
            this.rabt_female = new System.Windows.Forms.RadioButton();
            this.btn_changepwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(67, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "修改密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "邮箱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "姓名";
            // 
            // txt_Account
            // 
            this.txt_Account.Location = new System.Drawing.Point(72, 67);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(120, 21);
            this.txt_Account.TabIndex = 6;
            this.txt_Account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Account_KeyPress);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(72, 95);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(120, 21);
            this.txt_Email.TabIndex = 7;
            this.txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Email_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(72, 166);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(120, 21);
            this.txt_name.TabIndex = 9;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // rabt_male
            // 
            this.rabt_male.AutoSize = true;
            this.rabt_male.Checked = true;
            this.rabt_male.Location = new System.Drawing.Point(72, 137);
            this.rabt_male.Name = "rabt_male";
            this.rabt_male.Size = new System.Drawing.Size(35, 16);
            this.rabt_male.TabIndex = 10;
            this.rabt_male.TabStop = true;
            this.rabt_male.Text = "男";
            this.rabt_male.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rabt_male.UseVisualStyleBackColor = true;
            // 
            // rabt_female
            // 
            this.rabt_female.AutoSize = true;
            this.rabt_female.Location = new System.Drawing.Point(137, 137);
            this.rabt_female.Name = "rabt_female";
            this.rabt_female.Size = new System.Drawing.Size(35, 16);
            this.rabt_female.TabIndex = 11;
            this.rabt_female.TabStop = true;
            this.rabt_female.Text = "女";
            this.rabt_female.UseVisualStyleBackColor = true;
            // 
            // btn_changepwd
            // 
            this.btn_changepwd.Location = new System.Drawing.Point(71, 207);
            this.btn_changepwd.Name = "btn_changepwd";
            this.btn_changepwd.Size = new System.Drawing.Size(75, 23);
            this.btn_changepwd.TabIndex = 12;
            this.btn_changepwd.Text = "修改密码";
            this.btn_changepwd.UseVisualStyleBackColor = true;
            this.btn_changepwd.Click += new System.EventHandler(this.btn_changepwd_Click);
            // 
            // ForgetPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 261);
            this.Controls.Add(this.btn_changepwd);
            this.Controls.Add(this.rabt_female);
            this.Controls.Add(this.rabt_male);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ForgetPage";
            this.Text = "忘记密码";
            this.Load += new System.EventHandler(this.ForgetPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RadioButton rabt_male;
        private System.Windows.Forms.RadioButton rabt_female;
        private System.Windows.Forms.Button btn_changepwd;
    }
}