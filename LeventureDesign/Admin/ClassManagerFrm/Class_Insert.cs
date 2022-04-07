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
    public partial class Class_Insert : Form
    {
        ClassManagePage classAbove = null;
        public Class_Insert(ClassManagePage F1)
        {

            classAbove = F1;
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            UserManagerMent classinit = new UserManagerMent();//初始化一个班级类


            if (Cob_Level == null)
            {
                MessageBox.Show("输入年级不能为空！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Num == null)
            {
                MessageBox.Show("输入班号不能为空！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_TeacherID == null)
            {
                MessageBox.Show("输入教师工号不能为空！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!classinit.user_isExist(PublicClass.getInt(txt_TeacherID))) //如果查询不到一个这样的教师
            {
                MessageBox.Show("输入教师工号错误！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Level = Cob_Level.Text.Trim().ToString(); //年级
                int num = int.Parse(txt_Num.Text.Trim().ToString());  //班次
                int teacherID = int.Parse(txt_TeacherID.Text.Trim().ToString()); //老师ID

                classinit.Class_insert(Level, num, teacherID);
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; //年级栏不让输入字符
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IntOnly(e); //班号仅能为数字
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IntOnly(e); //年级老师号仅能为数字
        }

        private void Class_Insert_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ClassManagePage classinit = new ClassManagePage();
            //classinit.Show();
            //不能通过创建新窗口的方式来展开原有窗口，有点傻逼，不要问为什么，就是很傻逼，你要是问了那你也很傻逼
            classAbove.ClassRefreshment();
        }

        private void Class_Insert_Load(object sender, EventArgs e)
        {

        }
    }
}
