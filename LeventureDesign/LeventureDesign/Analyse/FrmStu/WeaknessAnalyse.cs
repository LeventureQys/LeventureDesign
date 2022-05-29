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
    public partial class WeaknessAnalyse : Form
    {
        AnalyseCore AnaInit = new AnalyseCore();
        int MostWeakness = 0;//最虚弱的值
        String MostWeaknessName = "";//最弱的章节名称
        UserManagerMent userinit = new UserManagerMent();
        int Type = 0; //1为学生弱点分析，2为教师弱点分析
        int currentUser;
        
        public WeaknessAnalyse(int user,int t) //需要注入一个user来表明分析对象
        {
            InitializeComponent();
            AnaInit.InitAnalyse(user); //解析并初始化Analysecore对象
            userinit.initUser(user);
            Type = t;
            currentUser = user;
        }

        private void WeaknessAnalyse_Load(object sender, EventArgs e)
        {
            if(Type == 1)
            {
                for (int i = 0; i < 9; i++)
                {
                    String Serieses = String.Format("s{0}", i + 1);
                    chart1.Series[Serieses].Points.AddXY(0, AnaInit.TargetWeakness[i]);
                }
                bool isEmpty = false;
                isEmpty = PublicClass.isEmpty(AnaInit.TargetWeakness);

                if (!isEmpty)
                {
                    MostWeakness = PublicClass.GetMax(AnaInit.TargetWeakness);
                    label1.Text = String.Format("你好{0}，看来你对{1}的理解最不理想，还请多多努力~", userinit.UserName, AnalyseWeakness(MostWeakness));
                }
                else
                {
                    label1.Text = "考试数据太少,无法进行分析";
                }
                

            }else if(Type == 2) //进入模式二则不需要具体的某个人的信息，只需要这个班级的classid即可
            {


                int[] Stus = userinit.StudentID_Includedby_Classid(PublicClass.ChosenThing); //在进入该页面的时候给定了一个选定的班级
                //int[] StusMostWeakness = new int[Stus.Length]; //一个包含每个学生的最弱弱点的数组
                double[] TargetWeakness = new double[9]; //目标虚弱点数组
                for (int i = 0; i < Stus.Length; i++) //遍历每一位学生
                {
                    AnaInit.InitAnalyse(Stus[i]);
                    for(int j = 0; j < 9; j++)//将每位学生的TargetWeakness累加
                    {
                        TargetWeakness[j] += AnaInit.TargetWeakness[j]/Stus.Length ;
                    }

                }

                for (int i = 0; i < 9; i++)
                {
                    String Serieses = String.Format("s{0}", i + 1);
                    chart1.Series[Serieses].Points.AddXY(0, TargetWeakness[i]/1.5);
                    //chart1.Series[Serieses].Points[0].Label = (TargetWeakness[i] / 10).ToString();
                }

                bool isEmpty = false;
                isEmpty = PublicClass.isEmpty(TargetWeakness);

                if (!isEmpty)
                {
                    MostWeakness = PublicClass.GetMax(TargetWeakness);
                    label1.Text = String.Format("你好，看来{0}班对{1}的理解最不理想，还请多多努力~", userinit.returnName_ByClassid(PublicClass.ChosenThing), AnalyseWeakness(MostWeakness));
                }
                else
                {
                    label1.Text = "考试数据太少,无法进行分析";
                }

                //MostWeakness = PublicClass.GetMax(TargetWeakness);
                //label1.Text = String.Format("你好，看来{0}班对{1}的理解最不理想，还请多多努力~",userinit.returnName_ByClassid(PublicClass.ChosenThing), AnalyseWeakness(MostWeakness));

            }
            //chart1.Series["s1"].Points.AddXY(0, AnaInit.TargetWeakness[0]);

        }
        private String AnalyseWeakness(int MostWeakness)
        {
            if (MostWeakness == 0)
            {
                MostWeaknessName = "必修1";
            }
            else if (MostWeakness == 1)
            {
                MostWeaknessName = "必修2";
            }
            else if (MostWeakness == 2)
            {
                MostWeaknessName = "必修3";
            }
            else if (MostWeakness == 3)
            {
                MostWeaknessName = "必修4";
            }
            else if (MostWeakness == 4)
            {
                MostWeaknessName = "必修5";
            }
            else if (MostWeakness == 5)
            {
                MostWeaknessName = "圆锥曲线";
            }
            else if (MostWeakness == 6)
            {
                MostWeaknessName = "导数";
            }
            else if (MostWeakness == 7)
            {
                MostWeaknessName = "坐标系与参数方程";
            }
            else if (MostWeakness == 8)
            {
                MostWeaknessName = "不等式选讲";
            }

            return MostWeaknessName;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }

}
