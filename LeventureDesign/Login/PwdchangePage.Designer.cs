
namespace LeventureDesign.Login
{
    partial class PwdchangePage
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pwdConfirm = new System.Windows.Forms.TextBox();
            this.btn_ChangeConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入修改后的密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码:";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(98, 68);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(141, 21);
            this.txt_pwd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "确认密码:";
            // 
            // txt_pwdConfirm
            // 
            this.txt_pwdConfirm.Location = new System.Drawing.Point(98, 105);
            this.txt_pwdConfirm.Name = "txt_pwdConfirm";
            this.txt_pwdConfirm.PasswordChar = '*';
            this.txt_pwdConfirm.Size = new System.Drawing.Size(141, 21);
            this.txt_pwdConfirm.TabIndex = 4;
            // 
            // btn_ChangeConfirm
            // 
            this.btn_ChangeConfirm.Location = new System.Drawing.Point(85, 158);
            this.btn_ChangeConfirm.Name = "btn_ChangeConfirm";
            this.btn_ChangeConfirm.Size = new System.Drawing.Size(139, 23);
            this.btn_ChangeConfirm.TabIndex = 5;
            this.btn_ChangeConfirm.Text = "确认修改";
            this.btn_ChangeConfirm.UseVisualStyleBackColor = true;
            this.btn_ChangeConfirm.Click += new System.EventHandler(this.btn_ChangeConfirm_Click);
            // 
            // PwdchangePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 193);
            this.Controls.Add(this.btn_ChangeConfirm);
            this.Controls.Add(this.txt_pwdConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PwdchangePage";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.PwdchangePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pwdConfirm;
        private System.Windows.Forms.Button btn_ChangeConfirm;
    }
}