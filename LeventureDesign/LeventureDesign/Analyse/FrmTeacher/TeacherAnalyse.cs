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
    public partial class TeacherAnalyse : Form
    {
        int currentClass = 0;
        AnalyseCore Ainit = new AnalyseCore();
        UserManagerMent userinit = new UserManagerMent(); //初始化一个userManagerMent类
        PaperCore pinit = new PaperCore();
        AnswerCore Ansinnt = new AnswerCore();
        double[] SCs_1;
        double[] SCs_2;
        double[] SCs_3;

        int[] RecentPapers_1;
        int[] RecentPapers_2;
        int[] RecentPapers_3;

        double K_1 = 0.0;
        double K_2 = 0.0;
        double K_3 = 0.0;

        double Var_1 = 0.0;
        double Var_2 = 0.0;
        double Var_3 = 0.0;
        public TeacherAnalyse(int classid) //针对老师的某个班级进行分析
        {
            InitializeComponent();
            currentClass = classid;
            RecentPapers_1 = pinit.PaperidsRecent_ByClassid_1(currentClass);
            RecentPapers_2 = pinit.PaperidsRecent_ByClassid_2(currentClass);
            RecentPapers_3 = pinit.PaperidsRecent_ByClassid_3(currentClass);
            SCs_1 = new double[RecentPapers_1.Length]; //新建一个这么长的sc数组
            SCs_2 = new double[RecentPapers_2.Length];
            SCs_3 = new double[RecentPapers_3.Length];
        }

        private void StuSCAnalyse_Load(object sender, EventArgs e)
        {
            //再本方法中是对教师教学情况的解析
            for(int i = 0; i < RecentPapers_1.Length; i++)
            {
                SCs_1[i] = Ansinnt.ClassAverage(RecentPapers_1[i], currentClass);//分析将近十次的考试成绩注入的SCs数组中
            }

            for (int i = 0; i < RecentPapers_2.Length; i++)
            {
                SCs_2[i] = Ansinnt.ClassAverage(RecentPapers_2[i], currentClass);//分析将近十次的考试成绩注入的SCs数组中
            }


            for (int i = 0; i < RecentPapers_3.Length; i++)
            {
                SCs_3[i] = Ansinnt.ClassAverage(RecentPapers_3[i], currentClass);//分析将近十次的考试成绩注入的SCs数组中
            }

            //lab_user.Text = String.Format("欢迎您，{0}", userinit.UserName);
            FreshMent();

        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void initChart()
        {

        }
        private void FreshMent()
        {
            //chart1.Series["s1"].Points.AddXY(1,);


            for(int i = 0;i< RecentPapers_1.Length; i++)
            {
                if (SCs_1[i] != -1)
                {
                    chart1.Series["s1"].Points.AddXY(i + 1, SCs_1[i]);
                    chart1.Series["s1"].Points[i].Label = SCs_1[i].ToString();
                }
                
            }

            for (int i = 0; i < RecentPapers_2.Length; i++)
            {
                if (SCs_2[i] != -1)
                {
                    chart1.Series["s2"].Points.AddXY(i + 1, SCs_2[i]);
                    chart1.Series["s2"].Points[i].Label = SCs_2[i].ToString();
                }
            }

            for (int i = 0; i < RecentPapers_3.Length; i++)
            {
                if (SCs_3[i] != -1)
                {
                    chart1.Series["s3"].Points.AddXY(i + 1, SCs_3[i]);
                    chart1.Series["s3"].Points[i].Label = SCs_3[i].ToString();
                }
              ;
            }

            K_1 = Ainit.ReturnLinear(SCs_1);
           K_2 = Ainit.ReturnLinear(SCs_2);
            K_3 = Ainit.ReturnLinear(SCs_3);//得到三个曲线的斜率

            Var_1 = Ainit.Variance(SCs_1);
            Var_2 = Ainit.Variance(SCs_2);
            Var_3 = Ainit.Variance(SCs_3);



            String Comment_1 = "";
            String Comment_2 = "";
            String Comment_3 = "";
            String VComment_1 = "";
            String VComment_2 = "";
            String VComment_3 = "";

            if (double.IsNaN(Var_1) || Var_1 < 0)
            {
                VComment_1 = "波动性数据不足，还请多多考试";
            }
            else
            {
                if (Var_1 < 15)
                {
                    VComment_1 = "考试情况较为平稳";
                }
                else if (Var_1 >= 15)
                {
                    VComment_1 = "考试情况波动较大";
                }
            }

            if (double.IsNaN(Var_2) || Var_2 < 0)
            {
                VComment_2 = "波动性数据不足，还请多多考试";
            }
            else if (Var_2 < 15)
            {
                VComment_2 = "考试情况较为平稳";
            }
            else if (Var_2 >= 15)
            {
                VComment_2 = "考试情况波动较大";
            }

            if (double.IsNaN(Var_3) || Var_3 < 0)
            {
                VComment_3 = "波动性数据不足，还请多多考试";
            }
            else if (Var_3 < 50)
            {
                VComment_2 = "考试情况较为平稳";
            }
            else if (Var_3 >= 50)
            {
                VComment_3 = "考试情况波动较大";
            }

            if (double.IsNaN(K_1))
            {
                Comment_1 = "成长性数据不足，还请多多考试！";
            }
            else if (K_1 > 0)
            {
                if (K_1 < 1)
                //Comment_1 = K_1.ToString();
                { Comment_1 = String.Format("{0},小幅前进，成长指数为{1},方差为：{2}", VComment_1, K_1.ToString(),Var_1); }
                else if (K_1 > 1 && K_1 < 3)
                {
                    Comment_1 = String.Format("{0},大步流星，成长指数为{1},方差为：{2}", VComment_1, K_1.ToString(),Var_2);
                }
                else if (K_1 > 3)
                {
                    Comment_1 = String.Format("{0},正在登峰造极，成长指数为{1},方差为：{2}", VComment_1, K_1.ToString(),Var_1);
                }

            }
            else if (K_1 < 0)
            {
                if (K_1 > -1)
                //Comment_1 = K_1.ToString();
                { Comment_1 = String.Format("{0},小幅下滑，成长指数为{1},方差为：{2}", VComment_1, K_1.ToString(),Var_1); }
                else if (K_1 < -1 && K_1 > -3)
                {
                    Comment_1 = String.Format("{0},大步后退，成长指数为{1},方差为：{2}", VComment_1, K_1.ToString(),Var_1);
                }
                else if (K_1 < -3)
                {
                    Comment_1 = String.Format("{0},飞流直下，成长指数为{1},方差为：{2}", VComment_1, K_1.ToString(),Var_1);
                }
            }

            if (double.IsNaN(K_2))
            {
                Comment_2 = "成长性数据不足，还请多多考试！";
            }
            else
            {
                if (K_2 > 0)
                {
                    if (K_2 < 1)
                    //Comment_1 = K_1.ToString();
                    { Comment_2 = String.Format("{0},小幅前进，成长指数为{1},方差为：{2}", VComment_2, K_2.ToString(),Var_2); }
                    else if (K_2 > 1 && K_2 < 3)
                    {
                        Comment_2 = String.Format("{0},大步流星，成长指数为{1},方差为：{2}", VComment_2, K_2.ToString(),Var_2);
                    }
                    else if (K_2 > 3)
                    {
                        Comment_2 = String.Format("{0},正在登峰造极，成长指数为{1},方差为：{2}", VComment_2, K_2.ToString(),Var_2);
                    }
                }
                else if (K_2 < 0)
                {
                    if (K_2 > -1)
                    //Comment_1 = K_1.ToString();
                    { Comment_2 = String.Format("{0},小幅下滑，成长指数为{1},方差为：{2}", VComment_2, K_2.ToString(),Var_2); }
                    else if (K_2 < -1 && K_2 > -3)
                    {
                        Comment_2 = String.Format("{0},大步后退，成长指数为{1},方差为：{2}", VComment_2, K_2.ToString(),Var_2);
                    }
                    else if (K_2 < -3)
                    {
                        Comment_2 = String.Format("{0},飞流直下，成长指数为{1},方差为：{2}", VComment_2, K_2.ToString(),Var_2);
                    }
                }



            }
            if (double.IsNaN(K_3))
            {
                Comment_3 = "成长性数据不足，还请多多考试！";
            }
            else
            {
                if (K_3 > 0)
                {
                    if (K_3 < 1)
                    //Comment_1 = K_1.ToString();
                    { Comment_3 = String.Format("{0}小幅前进，成长指数为{1},方差为：{2}", VComment_3, K_3.ToString(),Var_3); }
                    else if (K_3 > 1 && K_3 < 3)
                    {
                        Comment_3 = String.Format("{0}大步流星，成长指数为{1},方差为：{2}", VComment_3, K_3.ToString(),Var_3);
                    }
                    else if (K_3 > 3)
                    {
                        Comment_3 = String.Format("{0}正在登峰造极，成长指数为{1},方差为：{2}", VComment_3, K_3.ToString(),Var_3);
                    }
                }
                else if (K_3 < 0)
                {
                    if (K_3 > -1)
                    //Comment_1 = K_1.ToString();
                    { Comment_3 = String.Format("{0}小幅下滑，成长指数为{1},方差为：{2}", VComment_3, K_3.ToString(),Var_3); }
                    else if (K_3 < -1 && K_3 > -3)
                    {
                        Comment_3 = String.Format("{0}大步后退，成长指数为{1},方差为：{2}", VComment_3, K_3.ToString(),Var_3);
                    }
                    else if (K_3 < -3)
                    {
                        Comment_3 = String.Format("{0}飞流直下，成长指数为{1},方差为：{2}", VComment_3, K_3.ToString(),Var_3);
                    }
                }
            }



            lab_1.Text = String.Format("小题训练成长曲线情况:{0}", Comment_1);
            lab_2.Text = String.Format("大题训练成长曲线情况:{0}", Comment_2);
            lab_3.Text = String.Format("综合训练成长曲线情况:{0}", Comment_3);


        }

        private void btn_Weakness_Click(object sender, EventArgs e)
        {
            //WeaknessAnalyse weakness = new WeaknessAnalyse(publi);
            //weakness.Show();
            PublicClass.ChosenThing = currentClass;
            WeaknessAnalyse weak = new WeaknessAnalyse(PublicClass.PresentUserID, 2);
            weak.Show();
        }

        private void btn_Rank_Click(object sender, EventArgs e)
        {
            //WeaknessAnalyse weak = new WeaknessAnalyse()
            PaperSelect ps = new PaperSelect();
            ps.Show();
        }
    }
}
