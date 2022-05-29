
namespace LeventureDesign.Admin.UsermanagerFrm
{
    partial class UserAdd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Namy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电子邮箱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namy,
            this.account,
            this.password,
            this.authority,
            this.sex,
            this.电子邮箱,
            this.classid});
            this.dataGridView1.Location = new System.Drawing.Point(93, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(747, 65);
            this.dataGridView1.TabIndex = 1;
            // 
            // Namy
            // 
            this.Namy.HeaderText = "姓名";
            this.Namy.Name = "Namy";
            // 
            // account
            // 
            this.account.HeaderText = "账号";
            this.account.Name = "account";
            // 
            // password
            // 
            this.password.HeaderText = "密码";
            this.password.Name = "password";
            // 
            // authority
            // 
            this.authority.HeaderText = "权限";
            this.authority.Name = "authority";
            // 
            // sex
            // 
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            // 
            // 电子邮箱
            // 
            this.电子邮箱.HeaderText = "email";
            this.电子邮箱.Name = "电子邮箱";
            // 
            // classid
            // 
            this.classid.HeaderText = "班级ID";
            this.classid.Name = "classid";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(12, 34);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 2;
            this.btn_Confirm.Text = "提交";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 89);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserAdd";
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namy;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn authority;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电子邮箱;
        private System.Windows.Forms.DataGridViewTextBoxColumn classid;
    }
}