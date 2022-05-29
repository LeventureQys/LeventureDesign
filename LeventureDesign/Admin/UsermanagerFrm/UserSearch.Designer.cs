
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
            this.tabt_UserID = new System.Windows.Forms.RadioButton();
            this.rabt_Account = new System.Windows.Forms.RadioButton();
            this.btn_Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(837, 65);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "输入用户ID或账号查询:";
            // 
            // txt_index
            // 
            this.txt_index.Location = new System.Drawing.Point(196, 7);
            this.txt_index.Name = "txt_index";
            this.txt_index.Size = new System.Drawing.Size(172, 21);
            this.txt_index.TabIndex = 4;
            this.txt_index.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_index_KeyPress);
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(374, 5);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Check.TabIndex = 5;
            this.btn_Check.Text = "查询用户";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // tabt_UserID
            // 
            this.tabt_UserID.AutoSize = true;
            this.tabt_UserID.Checked = true;
            this.tabt_UserID.Location = new System.Drawing.Point(196, 43);
            this.tabt_UserID.Name = "tabt_UserID";
            this.tabt_UserID.Size = new System.Drawing.Size(59, 16);
            this.tabt_UserID.TabIndex = 6;
            this.tabt_UserID.TabStop = true;
            this.tabt_UserID.Text = "用户ID";
            this.tabt_UserID.UseVisualStyleBackColor = true;
            this.tabt_UserID.CheckedChanged += new System.EventHandler(this.tabt_UserID_CheckedChanged);
            // 
            // rabt_Account
            // 
            this.rabt_Account.AutoSize = true;
            this.rabt_Account.Location = new System.Drawing.Point(276, 43);
            this.rabt_Account.Name = "rabt_Account";
            this.rabt_Account.Size = new System.Drawing.Size(71, 16);
            this.rabt_Account.TabIndex = 7;
            this.rabt_Account.Text = "用户账号";
            this.rabt_Account.UseVisualStyleBackColor = true;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(455, 5);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 8;
            this.btn_Change.Text = "修改用户";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 155);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.rabt_Account);
            this.Controls.Add(this.tabt_UserID);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.txt_index);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserSearch";
            this.Text = "UserSearch";
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
        private System.Windows.Forms.RadioButton tabt_UserID;
        private System.Windows.Forms.RadioButton rabt_Account;
        private System.Windows.Forms.Button btn_Change;
    }
}