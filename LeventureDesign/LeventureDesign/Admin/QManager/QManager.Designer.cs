
namespace LeventureDesign
{
    partial class QManager
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
            this.btn_questAdd = new System.Windows.Forms.Button();
            this.btn_questDel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(655, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Location = new System.Drawing.Point(706, 12);
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Fresh.TabIndex = 1;
            this.btn_Fresh.Text = "刷新";
            this.btn_Fresh.UseVisualStyleBackColor = true;
            this.btn_Fresh.Click += new System.EventHandler(this.btn_Fresh_Click);
            // 
            // btn_questAdd
            // 
            this.btn_questAdd.Location = new System.Drawing.Point(12, 71);
            this.btn_questAdd.Name = "btn_questAdd";
            this.btn_questAdd.Size = new System.Drawing.Size(95, 39);
            this.btn_questAdd.TabIndex = 3;
            this.btn_questAdd.Text = "添加试题";
            this.btn_questAdd.UseVisualStyleBackColor = true;
            this.btn_questAdd.Click += new System.EventHandler(this.btn_questAdd_Click);
            // 
            // btn_questDel
            // 
            this.btn_questDel.Location = new System.Drawing.Point(12, 142);
            this.btn_questDel.Name = "btn_questDel";
            this.btn_questDel.Size = new System.Drawing.Size(95, 39);
            this.btn_questDel.TabIndex = 4;
            this.btn_questDel.Text = "删除试题";
            this.btn_questDel.UseVisualStyleBackColor = true;
            this.btn_questDel.Click += new System.EventHandler(this.btn_questDel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "查询试题";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "修改试题";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // QManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 377);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_questDel);
            this.Controls.Add(this.btn_questAdd);
            this.Controls.Add(this.btn_Fresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QManager";
            this.Text = "试题中心";
            this.Load += new System.EventHandler(this.QManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Fresh;
        private System.Windows.Forms.Button btn_questAdd;
        private System.Windows.Forms.Button btn_questDel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}