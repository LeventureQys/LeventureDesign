
namespace LeventureDesign
{
    partial class ClassManagePage
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
            this.btn_ClassInsert = new System.Windows.Forms.Button();
            this.btn_ClassDelete = new System.Windows.Forms.Button();
            this.btn_ClassChange = new System.Windows.Forms.Button();
            this.btn_fresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(584, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_ClassInsert
            // 
            this.btn_ClassInsert.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ClassInsert.Location = new System.Drawing.Point(12, 90);
            this.btn_ClassInsert.Name = "btn_ClassInsert";
            this.btn_ClassInsert.Size = new System.Drawing.Size(118, 58);
            this.btn_ClassInsert.TabIndex = 6;
            this.btn_ClassInsert.Text = "添加班级";
            this.btn_ClassInsert.UseVisualStyleBackColor = true;
            this.btn_ClassInsert.Click += new System.EventHandler(this.btn_ClassInsert_Click);
            // 
            // btn_ClassDelete
            // 
            this.btn_ClassDelete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ClassDelete.Location = new System.Drawing.Point(12, 164);
            this.btn_ClassDelete.Name = "btn_ClassDelete";
            this.btn_ClassDelete.Size = new System.Drawing.Size(118, 58);
            this.btn_ClassDelete.TabIndex = 7;
            this.btn_ClassDelete.Text = "删除班级";
            this.btn_ClassDelete.UseVisualStyleBackColor = true;
            this.btn_ClassDelete.Click += new System.EventHandler(this.btn_ClassDelete_Click);
            // 
            // btn_ClassChange
            // 
            this.btn_ClassChange.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ClassChange.Location = new System.Drawing.Point(12, 243);
            this.btn_ClassChange.Name = "btn_ClassChange";
            this.btn_ClassChange.Size = new System.Drawing.Size(118, 58);
            this.btn_ClassChange.TabIndex = 8;
            this.btn_ClassChange.Text = "修改班级";
            this.btn_ClassChange.UseVisualStyleBackColor = true;
            this.btn_ClassChange.Click += new System.EventHandler(this.btn_ClassChange_Click);
            // 
            // btn_fresh
            // 
            this.btn_fresh.Location = new System.Drawing.Point(147, 12);
            this.btn_fresh.Name = "btn_fresh";
            this.btn_fresh.Size = new System.Drawing.Size(76, 39);
            this.btn_fresh.TabIndex = 9;
            this.btn_fresh.Text = "刷新";
            this.btn_fresh.UseVisualStyleBackColor = true;
            this.btn_fresh.Click += new System.EventHandler(this.btn_fresh_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClassManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 329);
            this.Controls.Add(this.btn_fresh);
            this.Controls.Add(this.btn_ClassChange);
            this.Controls.Add(this.btn_ClassDelete);
            this.Controls.Add(this.btn_ClassInsert);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClassManagePage";
            this.Text = "班级管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClassManagePage_FormClosed);
            this.Load += new System.EventHandler(this.ClassManagePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ClassInsert;
        private System.Windows.Forms.Button btn_ClassDelete;
        private System.Windows.Forms.Button btn_ClassChange;
        private System.Windows.Forms.Button btn_fresh;
        private System.Windows.Forms.Timer timer1;
    }
}