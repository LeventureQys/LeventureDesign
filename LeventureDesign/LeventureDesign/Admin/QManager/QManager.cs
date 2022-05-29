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
    public partial class QManager : Form
    {
        DataSet Quest = new DataSet();
        QManagerment InitQuest = new QManagerment();

        public QManager()
        {
            InitializeComponent();
        }

        private void QManager_Load(object sender, EventArgs e)
        {
            btn_Fresh_Click(null,null); //初始化的时候直接点击一下刷新按钮即可
        }

        private void brn_Fresh_Click(object sender, EventArgs e)
        {
            //Quest = InitQuest.Q_SearchAll();//获得题库

            ////将dataset的内容输入dataGridView1
            //dataGridView1.DataSource = Quest;
            //dataGridView1.DataMember = "lwx";
            ////timer1.Enabled = true;
            ////btn_access.Visible = false;
        }

        private void btn_Fresh_Click(object sender, EventArgs e)
        {
            Quest = InitQuest.Q_SearchAll();//获得题库

            //将dataset的内容输入dataGridView1
            dataGridView1.DataSource = Quest;
            dataGridView1.DataMember = "lwx";
            InitQuest.Q_TitleInit(dataGridView1);
        }

        private void btn_questAdd_Click(object sender, EventArgs e)
        {
            QuestInsert Qinsert = new QuestInsert();
            Qinsert.Show();
        }

        private void btn_questDel_Click(object sender, EventArgs e)
        {
            QSearch search = new QSearch();
            search.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QSearch search = new QSearch();
            search.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QSearch search = new QSearch();
            search.Show();
        }
    }
}
