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
    public partial class PComment : Form
    {
        public int Classid;
        public int paperid;
        public int userid;
        public int ansid;
        PaperCore Pinit = new PaperCore();
        AnswerCore Ainit = new AnswerCore();
        int Pindex = 12; //从第13题开始
        int ViewMode = 0; //设置观察者模式，如果为0则为观察者模式，为1则为改卷模式
        String PicPath = "";

        //int[] Sc = new int[23]; //这个答案数组也是23个长度，为了和之前
        int Ptype = 0; //1为大题训练，2为综合训练

        int[] isFullChecked = new int[23];//建一个23长度数组，判定该数组中是否全部修改到位
        public void debug(String strMessage)
        {
            Debug.WriteLine(strMessage);
        }
        public PComment(int cid,int pid,int uid,int type)
        {

            paperid = pid;
            userid = uid;
            Classid = cid;
            Ptype = Pinit.pType;
            ViewMode = type;

            if(Pinit.pType == 1||Pinit.pType == 3)//小题训练或者综合训练，都是从12开始
            {
                Pindex = 12; //试题从第13题填空题开始
            }
            else if(Pinit.pType == 2) //如果是大题训练，则从第十七题开始
            {
                Pindex = 16;
            }

            //初始化修改检查数组
            for (int i = 0; i < isFullChecked.Length; i++)
            {
                isFullChecked[i] = 1; //默认全查,如果有没查的在提交和下一题的时候单独找出来即可
            }

            for(int i = 12; i < Ainit.SC.Length; i++) //将sc数组中所有变量声明为-1
            {
                Ainit.SC[i] = -1;
            }

                InitializeComponent();
            
        }

        private void FreshMent()
        {

            //将学生的答案放到界面上
            richTextBox1.Text = Ainit.Answer[Pindex];

            //修改PicPath
            PicPath = Pinit.Ans[Pindex];

            //修改pictureBox
            pictureBox1.Image = Image.FromFile(PicPath); //展示当前视图
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            //修改当前得分
            txt_Sc.Text = Ainit.SC[Pindex].ToString();

            //将-1修改为空
            if (txt_Sc.Text == "-1")
            {
                txt_Sc.Text = "";
            }

            //此时的当前页面上的东西已经标记好了
            lab_index.Text = String.Format("当前试题为第{0}/23题", Pindex+1);
            

        }


        private void txt_Sc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Sc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IntOnly(e);
        }

        private void PComment_Load(object sender, EventArgs e)
        {
            if (Pinit.PaperInit(paperid))
            {
                debug("试卷初始化成功");
            }

            if (Ainit.AnswerInit(paperid, userid))
            {
                debug(String.Format("试卷ID-{0},用户ID-{1} 的 答卷初始化成功", paperid, userid));
                if (Ainit.isFullChecked == 1 && PublicClass.ViewMode == 1) //除了检查是否已批改完成，且当仅当是修改模式下生效
                {
                    PublicClass.showMessage("此答卷已批改！", "批改试卷");
                    this.Close();
                    return;
                }
            }
            else
            {
                PublicClass.showMessage("当前用户并未在当前试卷下考试，请检查是否已经完成测试", "批改初始化");
                this.Close();

            }

            if (Pinit.pType == 1 || Pinit.pType == 3)//小题训练或者综合训练，都是从12开始
            {
                Pindex = 12; //试题从第13题填空题开始
            }
            else if (Pinit.pType == 2) //如果是大题训练，则从第十七题开始
            {
                Pindex = 16;
            }

            //初始化修改检查数组
            for (int i = 0; i < isFullChecked.Length; i++)
            {
                isFullChecked[i] = 1; //默认全查,如果有没查的在提交和下一题的时候单独找出来即可
            }

            for (int i = 12; i < Ainit.SC.Length; i++) //将sc数组中所有变量声明为-1
            {
                Ainit.SC[i] = -1;
            }
            FreshMent();//刷新页面

            vScrollBar1.Maximum = pictureBox1.Height - panel1.Height;

            //修改lab_type
            if (Pinit.pType == 1)
            {
                lab_type.Text = "当前试题类型为 ： 小题训练";
            }
            else if (Pinit.pType == 2)
            {
                lab_type.Text = "当前试题类型为 ： 大题训练";
            }
            else if (Pinit.pType == 3)
            {
                lab_type.Text = "当前试题类型为 ： 综合训练";
            }

            //修改lab_pname
            lab_PName.Text = Pinit.Pname;

            if (ViewMode == 0)//如果为观察者模式，则屏蔽打分模块
            {
                txt_Sc.Visible = false;
                label1.Visible = false;
                btn_Confrim.Visible = false;

            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
           if(ViewMode == 1) {
                if (Pindex < 15 && Pindex >= 12) // Pindex 11 - 15 实际 12-16
                {
                    if (PublicClass.getInt(txt_Sc) > 5)
                    {
                        PublicClass.showMessage("填空题满分为5分，您的给分已经大于 5分了！", "填空题");
                        return;
                    }
                    else if (PublicClass.getInt(txt_Sc) < 0)
                    {
                        PublicClass.showMessage("填空题最低分为0，您的给分已经小于0分了！", "填空题");
                    }
                }

                if (Pindex > 15) //Pindex > 16 也就是实际上的十七题以后
                {
                    if (PublicClass.getInt(txt_Sc) > 12)
                    {
                        PublicClass.showMessage("大题满分为12分，您的给分已经大于 12 分了！", "填空题");
                        return;
                    }
                    else if (PublicClass.getInt(txt_Sc) < 0)
                    {
                        PublicClass.showMessage("填空题最低分为0，您的给分已经小于0分了！", "填空题");
                    }
                }
            }

           


            Pindex++;
            if (Pinit.pType == 2 || Pinit.pType == 3)//如果当前试题为大题训练 或者 综合训练
            {
                if (Pindex > 22)//当Pindex=22,也就是第23题时
                {
                    PublicClass.showMessage("当前已是最后一题！", "下一题");
                    Pindex--;
                    return;
                }
            }else if(Pinit.pType == 1) //如果是小题训练，那最后一题只有第十六题
            {
                if(Pindex > 15)//当Pindex = 16，也就是第17题时，则不需要再判了
                {
                    PublicClass.showMessage("当前已是最后一题！", "下一题");
                    Pindex--;
                    return;
                }
            }

            if (PublicClass.getInt(txt_Sc) == -1 || PublicClass.getText(txt_Sc) == "")//假如当前数组为初始值-1
            {
                isFullChecked[Pindex-1] = 0; //即当前试题未打分，给当前试题记为0
            }
            else
            {
                Ainit.SC[Pindex-1] = PublicClass.getInt(txt_Sc);//将给定分数的Sc
                isFullChecked[Pindex-1] = 1;
            }



            

            FreshMent();
        }

        private void btn_Pre_Click(object sender, EventArgs e)
        {
            if(ViewMode == 1)
            {
                if (Pindex < 15 && Pindex >= 12) // Pindex 11 - 15 实际 12-16
                {
                    if (PublicClass.getInt(txt_Sc) > 5)
                    {
                        PublicClass.showMessage("填空题满分为5分，您的给分已经大于 5分了！", "填空题");
                        return;
                    }
                }

                if (Pindex > 15) //Pindex > 16 也就是实际上的十七题以后
                {
                    if (PublicClass.getInt(txt_Sc) > 12)
                    {
                        PublicClass.showMessage("大题满分为12分，您的给分已经大于 5分了！", "填空题");
                        return;
                    }
                }
            }
            
            Pindex--;
            if (Pinit.pType == 1 || Pinit.pType == 3) //如果是小题训练或综合训练
            {
                if (Pindex < 12)//如果当前的Pindex到达了第十三题 pindex == 11的时候就是选择题最后一题
                {
                    PublicClass.showMessage("到达第一题！", "上一题");
                    Pindex++;
                    return;
                }
            }else if(Pinit.pType == 2)//如果是大题训练
            {
                if (Pindex < 16)//如果当前的Pindex到达了第十六题 pindex == 15的时候就是选择题最后一题
                {
                    PublicClass.showMessage("到达第一题！", "上一题");
                    Pindex++;
                    return;
                }
            }

            if (PublicClass.getInt(txt_Sc) == -1)//假如当前不存在长度
            {
                isFullChecked[Pindex+1] = 0; //即当前试题未打分，给当前试题记为0
            }
            else
            {
                Ainit.SC[Pindex+1] = PublicClass.getInt(txt_Sc);//将给定分数的Sc
                isFullChecked[Pindex+1] = 1;
            }

            
            FreshMent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Confrim_Click(object sender, EventArgs e)
        {
            if (Pindex < 15 && Pindex >= 12) // Pindex 11 - 15 实际 12-16
            {
                if (PublicClass.getInt(txt_Sc) > 5)
                {
                    PublicClass.showMessage("填空题满分为5分，您的给分已经大于 5分了！", "填空题");
                    return;
                }
            }

            if (Pindex > 15) //Pindex > 16 也就是实际上的十七题以后
            {
                if (PublicClass.getInt(txt_Sc) > 12)
                {
                    PublicClass.showMessage("大题满分为12分，您的给分已经大于 5分了！", "填空题");
                    return;
                }
            }


            if (!PublicClass.DialogConfirm("是否提交改卷意见？", "批改试卷"))
            {
                return;
            }
            else //意见通过
            {
                //注意，在提交试卷时，如果没有经过对最后一道题进行修改，还需要对最后一题进行确认

                if (PublicClass.getInt(txt_Sc) == -1)//假如当前不存在长度
                {
                    isFullChecked[Pindex] = 0; //即当前试题未打分，给当前试题记为0
                }
                else
                {
                    Ainit.SC[Pindex] = PublicClass.getInt(txt_Sc);//将给定分数的Sc ,因为已经是最后一题了，没动这个，所以可以
                    isFullChecked[Pindex] = 1;
                }

                if (!isFullCheck())//如果当前有试题未批改
                {
                    if (!PublicClass.DialogConfirm("当前仍有试卷未批改，是否提交分数？", "批改试卷"))
                    {
                        return;
                    }
                }

                for(int i = 0; i < Ainit.SC.Length; i++)
                {
                    if(Ainit.SC[i] == -1) //记得将所有sc表中被记为-1的值 转换成0
                    {
                        Ainit.SC[i] = 0;
                    }
                }

                Ainit.isFullChecked = 1; //修改当前试卷是否以被完全批改完毕
                if(Ainit.UpdateSelectionSc())
               {
                    PublicClass.showMessage("试卷批改成功,即将关闭窗口", "批改成功");
                    this.Close();
                }else
                {
                    PublicClass.showMessage("分数上传失败，请手动记录当前得分并联系管理员", "批改失败");
                }


            }
        }

        private bool isFullCheck()
        {
            bool flag = true;
            //foreach(int i in isFullChecked)
            //{
            //    if(i == 0) //假如判查数组中的所有数都不为0，则返回true,否则返回false
            //    {
            //        flag = false;
            //    }
            //}

            if(Pinit.pType == 1)//小题训练，只用判12-15题
            {
                for(int i = 11;i<15; i++)
                {
                    if (isFullChecked[i] == 0) //假如判查数组中的所有数都不为0，则返回true,否则返回false
                    {
                        flag = false;
                    }
                }
            }else if(Pinit.pType == 2) //大题训练，只用判15-22题
            {
                for (int i = 15; i < 23; i++)
                {
                    if (isFullChecked[i] == 0) //假如判查数组中的所有数都不为0，则返回true,否则返回false
                    {
                        flag = false;
                    }
                }
            }else if(Pinit.pType == 3) //综合训练，需要判12-22题
            {
                for (int i = 12; i < 23; i++)
                {
                    if (isFullChecked[i] == 0) //假如判查数组中的所有数都不为0，则返回true,否则返回false
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Top = -vScrollBar1.Value;
        }

    }
}
