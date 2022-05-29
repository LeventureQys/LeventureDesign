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
    public partial class StuSCAnalyse : Form
    {
        int currentUser = 0;
        AnalyseCore Ainit = new AnalyseCore();
        UserManagerMent userinit = new UserManagerMent(); //初始化一个userManagerMent类
        public StuSCAnalyse(int user)
        {
            InitializeComponent();
            currentUser = user;
            userinit.initUser(currentUser); //初始化

        }

        private void StuSCAnalyse_Load(object sender, EventArgs e)
        {
            Ainit.InitAnalyse(currentUser); // 解析该学生的近十场考试情况
            lab_user.Text = String.Format("欢迎您，{0}", userinit.UserName);
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
            int index = 1;
            foreach (int i in Ainit.RecentSC_1)
            {
                if (i != -1)
                {
                    chart1.Series["type_1"].Points.AddXY(index, i);
                    chart1.Series["type_1"].Points[index - 1].Label = i.ToString();
                    index++;
                }
                
            }

            index = 1;
            foreach (int i in Ainit.RecentSC_2)
            {

                if (i != -1)
                {
                    chart1.Series["type_2"].Points.AddXY(index, i);
                    chart1.Series["type_2"].Points[index - 1].Label = i.ToString();
                    index++;
                }

            }
            index = 1;
            foreach (int i in Ainit.RecentSC_3)
            {

                if (i != -1)
                {
                    chart1.Series["type_3"].Points.AddXY(index, i);
                    chart1.Series["type_3"].Points[index - 1].Label = i.ToString();
                    index++;
                }

            }
            //String text;
            //if(Ainit.Linear_1)
            //根据数据，分为 登峰造极，稳中向好，平稳前进，平稳下滑，稳中向差，飞流直下
            String Comment_1 = "";
            String Comment_2 = "";
            String Comment_3 = "";
            String VComment_1 = "";
            String VComment_2 = "";
            String VComment_3 = "";

            if (double.IsNaN(Ainit.Var_1) || Ainit.Var_1 < 0)
            {
                VComment_1 = "波动性数据不足，还请多多考试";
            }
            else
            {
                if (Ainit.Var_1 < 15)
                {
                    VComment_1 = "考试情况较为平稳";
                }
                else if (Ainit.Var_1 >= 15)
                {
                    VComment_1 = "考试情况波动较大";
                }
            }

            if (double.IsNaN(Ainit.Var_2) || Ainit.Var_2 < 0)
            {
                VComment_2 = "波动性数据不足，还请多多考试";
            }
            else if (Ainit.Var_2 < 15)
            {
                VComment_2 = "考试情况较为平稳";
            }
            else if (Ainit.Var_2 >= 15)
            {
                VComment_2 = "考试情况波动较大";
            }

            if (double.IsNaN(Ainit.Var_3) || Ainit.Var_3 < 0)
            {
                VComment_3 = "波动性数据不足，还请多多考试";
            }
            else if (Ainit.Var_3 < 50)
            {
                VComment_2 = "考试情况较为平稳";
            }
            else if (Ainit.Var_3 >= 50)
            {
                VComment_3 = "考试情况波动较大";
            }

            if (double.IsNaN(Ainit.Linear_1))
            {
                Comment_1 = "成长性数据不足，还请多多考试！";
            }
            else if (Ainit.Linear_1 > 0)
            {
                if (Ainit.Linear_1 < 1)
                //Comment_1 = Ainit.Linear_1.ToString();
                { Comment_1 = String.Format("{0},小幅前进，成长指数为{1},方差为：{2}", VComment_1, Ainit.Linear_1.ToString(),Ainit.Var_1); }
                else if (Ainit.Linear_1 > 1 && Ainit.Linear_1 < 3)
                {
                    Comment_1 = String.Format("{0},大步流星，成长指数为{1},方差为：{2}", VComment_1, Ainit.Linear_1.ToString(),Ainit.Var_1);
                }
                else if (Ainit.Linear_1 > 3)
                {
                    Comment_1 = String.Format("{0},正在登峰造极，成长指数为{1},方差为：{2}", VComment_1, Ainit.Linear_1.ToString(),Ainit.Var_1);
                }

            }
            else if (Ainit.Linear_1 < 0)
            {
                if (Ainit.Linear_1 > -1)
                //Comment_1 = Ainit.Linear_1.ToString();
                { Comment_1 = String.Format("{0},小幅下滑，成长指数为{1},方差为：{2}", VComment_1, Ainit.Linear_1.ToString(),Ainit.Var_1); }
                else if (Ainit.Linear_1 < -1 && Ainit.Linear_1 > -3)
                {
                    Comment_1 = String.Format("{0},大步后退，成长指数为{1},方差为：{2}", VComment_1, Ainit.Linear_1.ToString(),Ainit.Var_1);
                }
                else if (Ainit.Linear_1 < -3)
                {
                    Comment_1 = String.Format("{0},飞流直下，成长指数为{1},方差为：{2}", VComment_1, Ainit.Linear_1.ToString(),Ainit.Var_1);
                }
            }

            if (double.IsNaN(Ainit.Linear_2))
            {
                Comment_2 = "成长性数据不足，还请多多考试！";
            }
            else
            {
                if (Ainit.Linear_2 > 0)
                {
                    if (Ainit.Linear_2 < 1)
                    //Comment_1 = Ainit.Linear_1.ToString();
                    { Comment_2 = String.Format("{0},小幅前进，成长指数为{1},方差为：{2}", VComment_2, Ainit.Linear_2.ToString(),Ainit.Var_2); }
                    else if (Ainit.Linear_2 > 1 && Ainit.Linear_2 < 3)
                    {
                        Comment_2 = String.Format("{0},大步流星，成长指数为{1},方差为：{2}", VComment_2, Ainit.Linear_2.ToString(),Ainit.Var_2);
                    }
                    else if (Ainit.Linear_2 > 3)
                    {
                        Comment_2 = String.Format("{0},正在登峰造极，成长指数为{1},方差为：{2}", VComment_2, Ainit.Linear_2.ToString(),Ainit.Var_2);
                    }
                }
                else if (Ainit.Linear_2 < 0)
                {
                    if (Ainit.Linear_2 > -1)
                    //Comment_1 = Ainit.Linear_1.ToString();
                    { Comment_2 = String.Format("{0},小幅下滑，成长参数为{1},方差为：{2}", VComment_2, Ainit.Linear_2.ToString(),Ainit.Var_2); }
                    else if (Ainit.Linear_2 < -1 && Ainit.Linear_2 > -3)
                    {
                        Comment_2 = String.Format("{0},大步后退，成长指数为{1},方差为：{2}", VComment_2, Ainit.Linear_2.ToString(),Ainit.Var_2);
                    }
                    else if (Ainit.Linear_2 < -3)
                    {
                        Comment_2 = String.Format("{0},飞流直下，成长指数为{1},方差为：{2}", VComment_2, Ainit.Linear_2.ToString(), Ainit.Var_2);
                    }
                }


          
                }
            if (double.IsNaN(Ainit.Linear_3))
            {
                Comment_3 = "成长性数据不足，还请多多考试！";
            }
            else
            {
                if (Ainit.Linear_3 > 0)
                {
                    if (Ainit.Linear_3 < 1)
                    //Comment_1 = Ainit.Linear_1.ToString();
                    { Comment_3 = String.Format("{0}小幅前进，成长指数为{1},方差为：{2}", VComment_3, Ainit.Linear_3.ToString(),Ainit.Var_3); }
                    else if (Ainit.Linear_3 > 1 && Ainit.Linear_3 < 3)
                    {
                        Comment_3 = String.Format("{0}大步流星，成长指数为{1},方差为：{2}", VComment_3, Ainit.Linear_3.ToString(),Ainit.Var_3);
                    }
                    else if (Ainit.Linear_3 > 3)
                    {
                        Comment_3 = String.Format("{0}正在登峰造极，成长指数为{1},方差为：{2}", VComment_3, Ainit.Linear_3.ToString(),Ainit.Var_3);
                    }
                }
                else if (Ainit.Linear_3 < 0)
                {
                    if (Ainit.Linear_3 > -1)
                    //Comment_1 = Ainit.Linear_1.ToString();
                    { Comment_3 = String.Format("{0}小幅下滑，成长指数为{1},方差为：{2}", VComment_3, Ainit.Linear_3.ToString(),Ainit.Var_3); }
                    else if (Ainit.Linear_3 < -1 && Ainit.Linear_3 > -3)
                    {
                        Comment_3 = String.Format("{0}大步后退，成长指数为{1},方差为：{2}", VComment_3, Ainit.Linear_3.ToString(), Ainit.Var_3);
                    }
                    else if (Ainit.Linear_3 < -3)
                    {
                        Comment_3 = String.Format("{0}飞流直下，成长指数为{1},方差为：{2}", VComment_3, Ainit.Linear_3.ToString(), Ainit.Var_3);
                    }
                }
            }

                    lab_linear1.Text = String.Format("小题测试的变化趋势为:{0}", Comment_1);
                    lab_linear2.Text = String.Format("大题测试的变化趋势为:{0}", Comment_2);
                    lab_linear3.Text = String.Format("综合测试的变化趋势为:{0}", Comment_3);

                }
            
        
        private void btn_Weakness_Click(object sender, EventArgs e)
        {
            WeaknessAnalyse weakness = new WeaknessAnalyse(currentUser,1);
            weakness.Show();
        }

        private void lab_user_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rank_Click(object sender, EventArgs e)
        {
            PaperSelect ps = new PaperSelect();
            ps.Show();
        }
    }
}
