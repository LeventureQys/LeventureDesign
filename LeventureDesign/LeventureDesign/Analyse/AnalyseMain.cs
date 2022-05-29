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
    public partial class AnalyseMain : Form
    {
        LoginPage userAbove = new LoginPage();

        UserManagerMent user = new UserManagerMent();
        public AnalyseMain()
        {
            InitializeComponent();
        }

        private void AnalyseMain_Load(object sender, EventArgs e)
        {
            label1.Text = "您好，欢迎" + user.UserName + "管理员";
            PublicClass.PresentName = user.UserName;
        }

        private void AnalyseMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //userAbove.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = System.DateTime.Now.ToString();
        }

        private void btn_CheckAnswer_Click(object sender, EventArgs e)
        {
            PublicClass.ViewMode = 0; //因为是查看试卷，所以是观察者模式
            PSelectToComment psc = new PSelectToComment(0);
            psc.Show();
        }

        private void btn_RankCheck_Click(object sender, EventArgs e)
        {
            PaperSelect PS = new PaperSelect();
            PS.Show();
      }

        private void btn_ScStu_Click(object sender, EventArgs e)
        {
            ChooseUser choose = new ChooseUser(1); //进入选择用户环节
            choose.Show();
        }

        private void btn_TeacherSituation_Click(object sender, EventArgs e)
        {
            ChooseUser userchoose = new ChooseUser(2);
            userchoose.Show();
        }
    }
}
