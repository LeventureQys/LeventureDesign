
namespace LeventureDesign
{
    partial class UserManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Fresh = new System.Windows.Forms.Button();
            this.btn_userInsert = new System.Windows.Forms.Button();
            this.btn_userDelete = new System.Windows.Forms.Button();
            this.btn_userChange = new System.Windows.Forms.Button();
            this.btn_userSearch = new System.Windows.Forms.Button();
            this.btn_ClassManager = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_access = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(149, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(946, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Location = new System.Drawing.Point(621, 29);
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Fresh.TabIndex = 1;
            this.btn_Fresh.Text = "刷新";
            this.btn_Fresh.UseVisualStyleBackColor = true;
            this.btn_Fresh.Click += new System.EventHandler(this.btn_Fresh_Click);
            // 
            // btn_userInsert
            // 
            this.btn_userInsert.Location = new System.Drawing.Point(12, 82);
            this.btn_userInsert.Name = "btn_userInsert";
            this.btn_userInsert.Size = new System.Drawing.Size(95, 39);
            this.btn_userInsert.TabIndex = 2;
            this.btn_userInsert.Text = "增加用户";
            this.btn_userInsert.UseVisualStyleBackColor = true;
            this.btn_userInsert.Click += new System.EventHandler(this.btn_userInsert_Click);
            // 
            // btn_userDelete
            // 
            this.btn_userDelete.Location = new System.Drawing.Point(12, 127);
            this.btn_userDelete.Name = "btn_userDelete";
            this.btn_userDelete.Size = new System.Drawing.Size(95, 39);
            this.btn_userDelete.TabIndex = 3;
            this.btn_userDelete.Text = "删除用户";
            this.btn_userDelete.UseVisualStyleBackColor = true;
            this.btn_userDelete.Click += new System.EventHandler(this.btn_userDelete_Click);
            // 
            // btn_userChange
            // 
            this.btn_userChange.Location = new System.Drawing.Point(12, 172);
            this.btn_userChange.Name = "btn_userChange";
            this.btn_userChange.Size = new System.Drawing.Size(95, 39);
            this.btn_userChange.TabIndex = 4;
            this.btn_userChange.Text = "修改用户";
            this.btn_userChange.UseVisualStyleBackColor = true;
            this.btn_userChange.Click += new System.EventHandler(this.btn_userChange_Click);
            // 
            // btn_userSearch
            // 
            this.btn_userSearch.Location = new System.Drawing.Point(12, 217);
            this.btn_userSearch.Name = "btn_userSearch";
            this.btn_userSearch.Size = new System.Drawing.Size(95, 39);
            this.btn_userSearch.TabIndex = 5;
            this.btn_userSearch.Text = "查询用户";
            this.btn_userSearch.UseVisualStyleBackColor = true;
            this.btn_userSearch.Click += new System.EventHandler(this.btn_userSearch_Click);
            // 
            // btn_ClassManager
            // 
            this.btn_ClassManager.Location = new System.Drawing.Point(12, 373);
            this.btn_ClassManager.Name = "btn_ClassManager";
            this.btn_ClassManager.Size = new System.Drawing.Size(95, 39);
            this.btn_ClassManager.TabIndex = 6;
            this.btn_ClassManager.Text = "班级管理";
            this.btn_ClassManager.UseVisualStyleBackColor = true;
            this.btn_ClassManager.Click += new System.EventHandler(this.btn_ClassManager_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(12, 262);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(95, 39);
            this.btn_Check.TabIndex = 7;
            this.btn_Check.Text = "检查申请";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_access
            // 
            this.btn_access.Location = new System.Drawing.Point(12, 307);
            this.btn_access.Name = "btn_access";
            this.btn_access.Size = new System.Drawing.Size(95, 39);
            this.btn_access.TabIndex = 8;
            this.btn_access.Text = "申请通过";
            this.btn_access.UseVisualStyleBackColor = true;
            this.btn_access.Visible = false;
            this.btn_access.Click += new System.EventHandler(this.btn_access_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.btn_access);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_ClassManager);
            this.Controls.Add(this.btn_userSearch);
            this.Controls.Add(this.btn_userChange);
            this.Controls.Add(this.btn_userDelete);
            this.Controls.Add(this.btn_userInsert);
            this.Controls.Add(this.btn_Fresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserManager";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Fresh;
        private System.Windows.Forms.Button btn_userInsert;
        private System.Windows.Forms.Button btn_userDelete;
        private System.Windows.Forms.Button btn_userChange;
        private System.Windows.Forms.Button btn_userSearch;
        private System.Windows.Forms.Button btn_ClassManager;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_access;
        private System.Windows.Forms.Timer timer1;
    }
}