using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
           
            if(txt_Account.Text == "")
            {
                PublicClass.showMessage("请输入账号", "登陆提示");
                return;
            }
            else if(txt_Password.Text == "")
            {
                PublicClass.showMessage("请输入密码", "登陆提示");
                return;
            }

            if(inituser.Login(PublicClass.getText(txt_Account), PublicClass.getText(txt_Password)))
            {
                inituser.initUser(); //初始化这个类
                PublicClass.PresentUserID = inituser.UserID;
                if (inituser.UserIsAvaliable == 1)
                {


                    if (PublicClass.PresentAuthority == 1)//如果是学生
                    {

                        PublicClass.isStu = true;
                        StudentPage stu = new StudentPage();
                        stu.Show();
                        //进入学生页面
                    }
                    else if (PublicClass.PresentAuthority == 2)//如果是教师
                    {
                        PublicClass.isTeacher = true;
                        PublicClass.isStu = false;
                        TeacherPage test = new TeacherPage();
                        test.Show();
                        //进入教师页面
                    }
                    else if (PublicClass.PresentAuthority == 3)//如果是管理员
                    {
                        PublicClass.isAdmin = true;
                        PublicClass.isStu = false;
                        AdminPage admin = new AdminPage();
                        admin.Show();

                    }
                }
                else
                {
                    PublicClass.showMessage("登陆提示", "当前用户未激活，请联系管理员");
                    return;
                }

                this.Visible = false; //登陆成功后此条隐身
            }

 

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
        public void debug(String strMessage)
        {
            Debug.WriteLine(strMessage);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //AdminPage admin = new AdminPage();
            //admin.Show();
            //this.Close();

            //QManager newQ = new QManager();
            //newQ.Show();

            //打开试题界面
            //QMain Qm = new QMain();
            //Qm.Show();
            //UserManagerMent test = new UserManagerMent();
            //PublicClass.showMessage(test.GetLevel(21), "test");

            //打开查看试卷界面
            //PaperCore Ptest = new PaperCore();
            //PLittleTran test = new PLittleTran(Ptest,0);
            //test.Show();

            //QManagerment test = new QManagerment();
            //debug(test.GetFile(151));

            //申请试卷
            //PAsk test = new PAsk();
            //test.Show();

            //学生界面
            //PublicClass.isStu = true;
            //PaperManager stu = new PaperManager();
            //stu.Show();

            //插入试题
            //QuestInsert test = new QuestInsert();
            //test.Show();

            //打开教师界面
            //TeacherPage test = new TeacherPage();
            //test.Show();

            //AnswerCore Ainit = new AnswerCore();
            //int[] temp = Ainit.SCToCid(35);
            //foreach(int i in temp)
            //{
            //    debug(i.ToString());
            //}
            //PaperCore pinit = new PaperCore();

            //DataSet temp = pinit.PaperDatasetRecent_ByClassid(24);
            //for(int i = 0; i < pinit.PaperidsRecent_ByClassid(temp).Length; i++)
            //{
            //    debug(pinit.PaperidsRecent_ByClassid(temp)[i].ToString());
            //}
            //debug("test?");
            PublicClass.isTeacher = true;
            PublicClass.PresentUserID = 22;
            ChooseClass test = new ChooseClass(1);
            
            test.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnswerCore test = new AnswerCore();
            test.commentPaperSelection(19, 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(label2.Left < 350)
            {
                label2.Left+=5;
            }
            else
            {
                label2.Left = -300;
            }
        }
    }
}
