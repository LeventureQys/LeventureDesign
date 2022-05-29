
namespace LeventureDesign
{
    partial class PaperManager
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
            this.btn_Request = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Fresh = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Request
            // 
            this.btn_Request.Location = new System.Drawing.Point(23, 121);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(69, 60);
            this.btn_Request.TabIndex = 0;
            this.btn_Request.Text = "申请试卷";
            this.btn_Request.UseVisualStyleBackColor = true;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(848, 351);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Location = new System.Drawing.Point(23, 33);
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(69, 34);
            this.btn_Fresh.TabIndex = 2;
            this.btn_Fresh.Text = "刷新";
            this.btn_Fresh.UseVisualStyleBackColor = true;
            this.btn_Fresh.Click += new System.EventHandler(this.btn_Fresh_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(23, 246);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(69, 60);
            this.btn_Del.TabIndex = 4;
            this.btn_Del.Text = "删除试卷";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // PaperManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 394);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Fresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Request);
            this.Name = "PaperManager";
            this.Text = "试卷管理";
            this.Load += new System.EventHandler(this.PaperManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Request;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Fresh;
        private System.Windows.Forms.Button btn_Del;
    }
}