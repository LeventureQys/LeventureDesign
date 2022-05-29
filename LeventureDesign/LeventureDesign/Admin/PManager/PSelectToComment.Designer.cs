
namespace LeventureDesign
{
    partial class PSelectToComment
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
            this.btn_Fresh = new System.Windows.Forms.Button();
            this.lab_currentType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(674, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Location = new System.Drawing.Point(12, 35);
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(93, 23);
            this.btn_Fresh.TabIndex = 1;
            this.btn_Fresh.Text = "回到班级页面";
            this.btn_Fresh.UseVisualStyleBackColor = true;
            this.btn_Fresh.Click += new System.EventHandler(this.btn_Fresh_Click);
            // 
            // lab_currentType
            // 
            this.lab_currentType.AutoSize = true;
            this.lab_currentType.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_currentType.Location = new System.Drawing.Point(126, 35);
            this.lab_currentType.Name = "lab_currentType";
            this.lab_currentType.Size = new System.Drawing.Size(66, 19);
            this.lab_currentType.TabIndex = 2;
            this.lab_currentType.Text = "请选择";
            // 
            // PSelectToComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 480);
            this.Controls.Add(this.lab_currentType);
            this.Controls.Add(this.btn_Fresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PSelectToComment";
            this.Text = "试卷批改";
            this.Load += new System.EventHandler(this.PComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Fresh;
        private System.Windows.Forms.Label lab_currentType;
    }
}