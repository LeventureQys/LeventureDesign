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
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
            user.initUser(PublicClass.PresentUser);
        }
        UserManagerMent user = new UserManagerMent();
        private void StudentPage_Load(object sender, EventArgs e)
        {
            label1.Text = "您好，欢迎" + user.UserName;
            PublicClass.PresentName = user.UserName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = System.DateTime.Now.ToString();
        }

        private void btn_JoinTest_Click(object sender, EventArgs e)
        {
            PaperManager stu = new PaperManager();
            stu.Show();
        }

        private void StudentPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void btn_SCManager_Click(object sender, EventArgs e)
        {
            StuSCAnalyse analyse = new StuSCAnalyse(PublicClass.PresentUserID);
            analyse.Show();
        }

        private void btn_paperselect_Click(object sender, EventArgs e)
        {
            UserManagerMent userinit = new UserManagerMent();
            userinit.initUser(PublicClass.PresentUserID);
            PublicClass.ViewMode = 0; //因为是查看试卷，所以是观察者模式
            PublicClass.ChosenThing = userinit.UserClassid;
            PSelectToComment psc = new PSelectToComment(0);
            psc.Show();
        }
    }
}
