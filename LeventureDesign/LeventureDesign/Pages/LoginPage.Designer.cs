
namespace LeventureDesign
{
    partial class LoginPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.link_Regedit = new System.Windows.Forms.LinkLabel();
            this.link_Forget = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(51, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // txt_Account
            // 
            this.txt_Account.Location = new System.Drawing.Point(115, 75);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(127, 21);
            this.txt_Account.TabIndex = 1;
            this.txt_Account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Account_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(51, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "密码";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(115, 119);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(127, 21);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(66, 171);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(188, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "登陆";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // link_Regedit
            // 
            this.link_Regedit.AutoSize = true;
            this.link_Regedit.Location = new System.Drawing.Point(251, 84);
            this.link_Regedit.Name = "link_Regedit";
            this.link_Regedit.Size = new System.Drawing.Size(53, 12);
            this.link_Regedit.TabIndex = 5;
            this.link_Regedit.TabStop = true;
            this.link_Regedit.Text = "注册账户";
            this.link_Regedit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Regedit_LinkClicked);
            // 
            // link_Forget
            // 
            this.link_Forget.AutoSize = true;
            this.link_Forget.Location = new System.Drawing.Point(253, 127);
            this.link_Forget.Name = "link_Forget";
            this.link_Forget.Size = new System.Drawing.Size(65, 12);
            this.link_Forget.TabIndex = 6;
            this.link_Forget.TabStop = true;
            this.link_Forget.Text = "忘了密码？";
            this.link_Forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Forget_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "欢迎来到育才中学考试分析评价系统";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 237);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.link_Forget);
            this.Controls.Add(this.link_Regedit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginPage";
            this.Text = "登陆";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserLogin_FormClosed);
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel link_Regedit;
        private System.Windows.Forms.LinkLabel link_Forget;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

