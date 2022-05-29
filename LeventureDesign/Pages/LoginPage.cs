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
    public partial class LoginPage : Form
    {
        UserManagerMent inituser = new UserManagerMent();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void txt_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.isAvaliable(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.isAvaliable(e);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
           

            inituser.Login(PublicClass.getText(txt_Account), PublicClass.getText(txt_Password));

            inituser.initUser(); //初始化这个类


            if (PublicClass.PresentAuthority == 1)//如果是学生
            {
                //进入学生页面
            }
            else if(PublicClass.PresentAuthority == 2)//如果是教师
            {
                //进入教师页面
            }
            else if(PublicClass.PresentAuthority == 3)//如果是管理员
            {
                AdminPage admin = new AdminPage();
                admin.Show();
                
            }

            this.Visible = false ;

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            int a =inituser.user_Authority("12345");
            PublicClass.showMessage(a.ToString(), "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RegeditPage reg = new RegeditPage();
            //reg.Show(this);

            ForgetPage forget = new ForgetPage();
            forget.Show();
        }
        //退出时需要清理缓存
        private void UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            PublicClass.PresentAuthority = -1;
            PublicClass.PresentUser ="";

            Application.ExitThread(); //退出进程，让整个程序彻底关闭而不是留着一些未关闭的窗口在后台运行
            //因为是简单的模型，所以这个窗口打开未关闭的问题暂不进行优化，将来会想想办法的

            //注意一个问题，就是如果当前窗口close的话，就会调用这个方法，会导致线程直接退出，所以打开窗口的时候只能使本窗口visible =false 而不能直接close本窗口
        }

        private void link_Regedit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegeditPage reg = new RegeditPage();
            reg.Show();
            this.Visible = false;
        }

        private void link_Forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPage forget = new ForgetPage();
            forget.Show();

        }

        public UserManagerMent getUser()
        {
            return inituser;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //QManager test = new QManager();
            //test.Show();
            PublicClass.PresentAuthority = 3;
            PublicClass.PresentName = "文轩";
            PublicClass.PresentUser = "123";

            ClassManagePage classes = new ClassManagePage();

            classes.Show();
        }
    }
}
