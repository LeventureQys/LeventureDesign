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
    
    public partial class Class_Change : Form
    {
        int nclassid;
        string nlevel;
        int nnum;
        //string nname;
        int nnumber;
        int nteacherid;
        ClassManagePage classAbove = null;
        public Class_Change(ClassManagePage F1)
        {
            InitializeComponent();
            classAbove = F1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            UserManagerMent classinit = new UserManagerMent();
            DataSet st = new DataSet();//一个用于接受数据的dataset
            if (txt_ClassID.Text.Trim() == "") //假如输入的为空
            {
                MessageBox.Show("请输入用户学号/工号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_ClassID.Text.Trim() != "")//假如不全为空，且是uid不为空
            {
                st = classinit.classtabledataset_search(PublicClass.getInt(txt_ClassID)); //uid找到dataset输入st中
                dataGridView1.DataSource = st;
                dataGridView1.DataMember = "lwx";
            }
           
        }

        //这里有一个很恶心的点，就是数据库的表视图是不能做修改的，也就是说这个修改我只能一点点地扣
        private void btn_Confirm_Click(object sender, EventArgs e) //修改数据库用户
        {
            if (dataGridView1.DataSource == null)   //若当前窗口为空
            {
                MessageBox.Show("请先查询用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nclassid = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString()); //定义classid
                nlevel = dataGridView1.Rows[0].Cells[3].Value.ToString();
                nnum = int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString());
                nteacherid = int.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString().Trim());
                nnumber = int.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString().Trim());

                UserManagerMent classinit = new UserManagerMent();
                classinit.class_change(nclassid, nlevel, nnum, nteacherid, nnumber);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Class_Change_Load(object sender, EventArgs e)
        {

        }

        private void Class_Change_FormClosed(object sender, FormClosedEventArgs e)
        {
            classAbove.ClassRefreshment();
        }
    }
}
