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
    public partial class TeacherPage : Form
    {
        UserManagerMent user = new UserManagerMent();
        public TeacherPage()
        {
            user.initUser(PublicClass.PresentUser);
            InitializeComponent();
            label1.Text = "您好，欢迎" + user.UserName;
            PublicClass.PresentName = user.UserName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = System.DateTime.Now.ToString();
        }

        private void TeacherPage_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = PShow;
            //dataGridView1.DataMember = "lwx";
        }

        private void btn_CommentPaper_Click(object sender, EventArgs e)
        {
            PublicClass.ViewMode = 1; //进入老师批改试卷，所以是批改者模式
            PSelectToComment pComment = new PSelectToComment(0);
            pComment.Show();
        }

        private void TeacherPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginPage login = new LoginPage(); //转到登陆界面
            login.Show();
        }

        private void btn_TeachAnalyse_Click(object sender, EventArgs e)
        {
            ChooseClass getClass = new ChooseClass(1);
            getClass.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PAsk pask = new PAsk();
            pask.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseClass ccs = new ChooseClass(3);
            ccs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserManagerMent userinit = new UserManagerMent();
            userinit.initUser(PublicClass.PresentUserID);
            
        }
    }
}
