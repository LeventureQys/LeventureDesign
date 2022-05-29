using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeventureDesign
{
    public partial class ClassManagePage : Form
    {
        UserManagerMent userinit = new UserManagerMent();
        public ClassManagePage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClassManagePage_Load(object sender, EventArgs e)
        {
            ////设置Timer控件可用
            //this.timer1.Enabled = true;
            ////设置时间间隔（毫秒为单位）
            //this.timer1.Interval = 200;
            //this.Controls.Add(dataGridView1);

            //btn_fresh_Click(null, null);//页面初始化的时候刷新
            btn_fresh_Click(null, null);

        }

        private void ClassManagePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            //AdminPage admininit = new AdminPage();
            //admininit.Show();

        }

        private void btn_ClassInsert_Click(object sender, EventArgs e)
        {
            Class_Insert insert = new Class_Insert(this);
            insert.Show();

        }

        private void btn_ClassDelete_Click(object sender, EventArgs e)
        {
            Class_Delete del = new Class_Delete(this);
            del.Show();

            btn_fresh_Click(null, null);
        }

        private void btn_fresh_Click(object sender, EventArgs e)
        {
            ;
            DataSet classset = new DataSet();

            classset = userinit.classdataset_all();
            dataGridView1.DataSource = classset;
            dataGridView1.DataMember = "lwx";
           
        }
        public void ClassRefreshment()
        {
            DataSet classset = new DataSet();

            classset = userinit.classdataset_all();
            dataGridView1.DataSource = classset;
            dataGridView1.DataMember = "lwx";
            btn_fresh_Click(null, null);
        }
        private void btn_ClassChange_Click(object sender, EventArgs e)
        {
            Class_Change clschange = new Class_Change(this);
            clschange.Show();
            btn_fresh_Click(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //不需要定时刷新，否则会让整个页面非常僵硬
            //btn_fresh_Click(null, null); //定时自动刷新
        }
    }
}
