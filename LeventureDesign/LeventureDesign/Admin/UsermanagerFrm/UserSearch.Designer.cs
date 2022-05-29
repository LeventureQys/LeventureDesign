
namespace LeventureDesign.Admin.UsermanagerFrm
{
    partial class UserSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_index = new System.Windows.Forms.TextBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.rabt_UserID = new System.Windows.Forms.RadioButton();
            this.rabt_Account = new System.Windows.Forms.RadioButton();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.rad_Classid = new System.Windows.Forms.RadioButton();
            this.rad_UserAuthority = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(837, 170);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "请选择查询方法：";
            // 
            // txt_index
            // 
            this.txt_index.Location = new System.Drawing.Point(151, 51);
            this.txt_index.Name = "txt_index";
            this.txt_index.Size = new System.Drawing.Size(172, 21);
            this.txt_index.TabIndex = 4;
            this.txt_index.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_index_KeyPress);
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(459, 10);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Check.TabIndex = 5;
            this.btn_Check.Text = "查询用户";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // rabt_UserID
            // 
            this.rabt_UserID.AutoSize = true;
            this.rabt_UserID.Checked = true;
            this.rabt_UserID.Location = new System.Drawing.Point(138, 13);
            this.rabt_UserID.Name = "rabt_UserID";
            this.rabt_UserID.Size = new System.Drawing.Size(59, 16);
            this.rabt_UserID.TabIndex = 6;
            this.rabt_UserID.TabStop = true;
            this.rabt_UserID.Text = "用户ID";
            this.rabt_UserID.UseVisualStyleBackColor = true;
            this.rabt_UserID.CheckedChanged += new System.EventHandler(this.tabt_UserID_CheckedChanged);
            // 
            // rabt_Account
            // 
            this.rabt_Account.AutoSize = true;
            this.rabt_Account.Location = new System.Drawing.Point(203, 13);
            this.rabt_Account.Name = "rabt_Account";
            this.rabt_Account.Size = new System.Drawing.Size(71, 16);
            this.rabt_Account.TabIndex = 7;
            this.rabt_Account.Text = "用户账号";
            this.rabt_Account.UseVisualStyleBackColor = true;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(540, 10);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 8;
            this.btn_Change.Text = "修改用户";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(621, 10);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "删除用户";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // rad_Classid
            // 
            this.rad_Classid.AutoSize = true;
            this.rad_Classid.Location = new System.Drawing.Point(280, 13);
            this.rad_Classid.Name = "rad_Classid";
            this.rad_Classid.Size = new System.Drawing.Size(59, 16);
            this.rad_Classid.TabIndex = 10;
            this.rad_Classid.TabStop = true;
            this.rad_Classid.Text = "班级ID";
            this.rad_Classid.UseVisualStyleBackColor = true;
            // 
            // rad_UserAuthority
            // 
            this.rad_UserAuthority.AutoSize = true;
            this.rad_UserAuthority.Location = new System.Drawing.Point(345, 13);
            this.rad_UserAuthority.Name = "rad_UserAuthority";
            this.rad_UserAuthority.Size = new System.Drawing.Size(71, 16);
            this.rad_UserAuthority.TabIndex = 11;
            this.rad_UserAuthority.TabStop = true;
            this.rad_UserAuthority.Text = "用户类型";
            this.rad_UserAuthority.UseVisualStyleBackColor = true;
            this.rad_UserAuthority.CheckedChanged += new System.EventHandler(this.rad_UserAuthority_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "学生",
            "教师",
            "管理员"});
            this.comboBox1.Location = new System.Drawing.Point(151, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "学生";
            this.comboBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "请输入查询对象：";
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rad_UserAuthority);
            this.Controls.Add(this.rad_Classid);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.rabt_Account);
            this.Controls.Add(this.rabt_UserID);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.txt_index);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserSearch";
            this.Text = "搜索用户";
            this.Load += new System.EventHandler(this.UserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_index;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.RadioButton rabt_UserID;
        private System.Windows.Forms.RadioButton rabt_Account;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.RadioButton rad_Classid;
        private System.Windows.Forms.RadioButton rad_UserAuthority;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}