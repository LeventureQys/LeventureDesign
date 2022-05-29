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
    public partial class PLittleTran : Form
    {

        //int pType = -1;
        DataSet dt = new DataSet();
        PaperCore Pinit = new PaperCore();
        QManagerment Qinit = new QManagerment();
        int[] LittleQ = new int[16]; // 小题
        int[] BigQ = new int[7]; // 大题
        int[] FullQ = new int[23]; //完整训练
                                   //int QIndex = 1;
        //题号的上下界限
        int QMax = 0;
        int QMin = 0;


        //int Pattern; //表示当前进入的模式，0为浏览模式，1为做题模式

        //String CurrentPath = ""; // 用来展示answer图片的字符串
//新建一个字符串数组类型，一共23个
//Answer String数组当前的Index应该和Pindex对其，否则可能会出现意料之外的问题
        
        AnswerCore Answer = new AnswerCore();
        //一共23个问题，经过初始化之后的Qid应该是不为零而且也不重复的
        //
        //此时已经可以对Quest字符串数组进行注入
        String[] Quest = new String[23]; 
       
        int Pindex = 0;//当前试题索引
        //int PindexBig = 0;
        int ViewerMode = 0; //两种模式，0为观察模式，1为答题模式
        public void debug(String strMessage)
        {
            Debug.WriteLine(strMessage);
        }


        public PLittleTran(PaperCore P,int Pa) // 本窗口需要输入一套完整的试题
        {
            Pinit = P;
            //Pinit = P;
            //pType = Type;
            ViewerMode = Pa;
            Answer.UserId = PublicClass.PresentUserID;
            Answer.PaperId = Pinit.PaperId;
            
            InitializeComponent();
        }

        private void PLittleTran_Load(object sender, EventArgs e)
        {
            
            
            rad_A.Checked = false;
            rad_B.Checked = false;
            rad_C.Checked = false;
            rad_D.Checked = false;

            if (PublicClass.isStu == false)
            {
                btn_Confirm.Visible = false;
            }
            //pictureBox1.Image = Image.FromFile(Qinit.GetFile(151));
            //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            if (Pinit.pType == 1) //若当前试题为小题训练
            {
                QMin = 0;
                QMax = 15;
            }
            else if (Pinit.pType == 2)
            {
                Pindex = Pindex + 16; //直接将当前的index推到第十七题去
                QMin = 16;
                QMax = 22;
            }
            else if (Pinit.pType == 3)
            {
                QMin = 0;
                QMax = 22;
            }
            vScrollBar1.Maximum = pictureBox1.Height - panel1.Height;
            lab_WelCome.Text = String.Format("欢迎来到{0}", Pinit.Pname);
            this.Text = String.Format("欢迎来到{0}", Pinit.Pname);
            //lab_Index.Text = QIndex.ToString();

            //lab_Index.Text = String.Format("本题为第{0}题", Pindex + 1);

            String Type = pTypeTrans(Pinit.pType);
            lab_QType.Text = String.Format("本次考试类型为{0}", Type);

            //还是需要根据pType做判断，因为关于数组是否注入成功的重要判断就是当前数组是否为0，若为0则注入失败
            //String TItle = "试题展示/试题训练";


                if (!InitFull())//无论是哪种试题模式，都直接装载整张试卷，由index来决定其能访问的题号
                {
                    PublicClass.showMessage("当前试卷初始化失败", "试卷展示");
                }

                //此时已经获得了Quest 字符串，已经完全加载完毕了

                //FreshPanel_Doer();
                if (ViewerMode == 0) //如果是观察者模式
                {
                    FreshPanel_Viewer();
                btn_Confirm.Visible = false;
                }
                else
                {
                    FreshPanel_Doer();
                }

          }
        
        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            pictureBox1.Top = -vScrollBar1.Value;
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}
        private bool InitLittleTran()
        {
            try
            {
                if (Pinit.pType == 1)//小题训练，则只初始化小题组
                {
                    if (InitLittleQ())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    //将四个数组插入到LittleQ中去
                }
                else if (Pinit.pType == 2)//如果是大题训练
                {
                    if (InitBigQ())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(Pinit.pType == 3) //综合训练
                {
                    if (InitFull())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            } catch (Exception ex)
            {
                Pinit.debug(ex.ToString());
                return false;
            }


            return true;
        }

        private bool InitLittleQ()
        {
            try
            {

                Array.Copy(Pinit.q1, 0, LittleQ, 0, Pinit.q1.Length);
                Array.Copy(Pinit.q2, 0, LittleQ, Pinit.q1.Length, Pinit.q2.Length);
                Array.Copy(Pinit.q3, 0, LittleQ, Pinit.q1.Length + Pinit.q2.Length, Pinit.q3.Length);
                Array.Copy(Pinit.q4, 0, LittleQ, Pinit.q1.Length + Pinit.q2.Length + Pinit.q3.Length, Pinit.q4.Length);
                //QMax = 15;
                for(int i = 0;i<LittleQ.Length;i++)
                {
                    if (LittleQ[i] == 0) //检查LittleQ状态
                    {
                        Pinit.debug(String.Format("小题数组LittleQ当前第{0}题出问题了", i+1));
                        return false;
                    }
                }

                //LittleQ数组初始化完毕，开始初始化试题数组
                for (int i = 0; i < LittleQ.Length; i++)
                {
                    if (Qinit.GetFile(LittleQ[i]) == "") //检查一条插入一条
                    {
                        return false;
                    }
                    Quest[i] = Qinit.GetFile(LittleQ[i]); //将littleq数组中的每一个数字取出，并将其输入到 Quest中去
                    //不检查取出的字符串是否正常
                }
              return true;
            } catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }
       
        private bool InitBigQ()
        {
            try
            {
               
                    BigQ[0] = Pinit.q5;
                    BigQ[1] = Pinit.q6;
                    BigQ[2] = Pinit.q7;
                    BigQ[3] = Pinit.q8;
                    BigQ[4] = Pinit.q9;
                    BigQ[5] = Pinit.q10;
                    BigQ[6] = Pinit.q11;
                
                //QMax = 6;
                //int i = 0;
                for (int i = 0; i < BigQ.Length; i++)
                {
                    if(BigQ[i] == 0)
                    {
                        Pinit.debug(String.Format("大题数组BigQ当前第{0}题出问题了", i+17));
                        return false;
                    }
                }

                for (int i = 0; i < BigQ.Length; i++)
                {
                    if(Qinit.GetFile(BigQ[i]) == "")
                    {
                        return false; //检查一条插入一条
                    }
                    Quest[i+16] = Qinit.GetFile(BigQ[i]); //将BigQ数组中的每一个数字取出，并将其输入到 Quest中去
                    //Quest[16] = BigQ[0] 第17题应该是大题第一题
                    //不检查取出的字符串是否正常
                }
                return true;
                
            }catch(Exception ex)
            {
                Pinit.debug(ex.ToString());
                return false;
            }
        }

        private bool InitFull() //初始化综合训练
        {
            try
            {
                //QMax = 22;
                if (!InitLittleQ())
                {
                    debug("综合训练-小题获取失败");
                    return false;
                }

                if (!InitBigQ())
                {
                    debug("综合训练-大题获取失败");
                    return false;
                }

                //此时已经获得了littleq和bigq两个数组，此时只需要将其装入FullQ中即可

                Array.Copy(LittleQ, 0, FullQ, 0, LittleQ.Length);
                Array.Copy(BigQ, 0, FullQ, LittleQ.Length, BigQ.Length);

                for (int i = 0; i <FullQ.Length; i++)
                {
                    if (FullQ[i] == 0)
                    {
                        debug(String.Format("综合训练数组FullQ当前第{0}题出问题了", i + 1));
                        return false;
                    }
                }

                //后面其实不用再插入一次具体的题目了，因为在两次init中就已经插入了
                //也不用检查，反正都检查过了
                

                return true;
            }
            catch (Exception ex)
            {
                debug(ex.ToString());
                return false;
            }

        }

        private String pTypeTrans(int pType)
        {
            try
            {
                if (pType == 1)
                {
                    return "小题训练";
                }
                else if (pType == 2)
                {
                    return "大题训练";
               }
                else if (pType == 3)
                {
                    return "综合训练";
                }
                else
                {
                    debug("获取试卷类型出错");
                    return null;
                }
            }catch(Exception ex){
                debug(ex.ToString());
                return null;
            }
        }
        //刷新整个panel1
        private void FreshPanel_Doer()//做题模式,真正的每一次初始化 都靠这个FreshPanel来实现
        {
            rad_A.Checked = false;
            rad_B.Checked = false;
            rad_C.Checked = false;
            rad_D.Checked = false;

            //txt_Answer.Text = ""; 
            
            //每次刷新之后要清空当前panel上的已输入内容
            

            //lab_Index.Text = String.Format("本题为第{0}题", Pindex + 1);
            //pictureBox1.Image = Image.FromFile(Qinit.GetFile());
            if(Pindex < 12)//此时还是在做选择题
            {
                panel_Selection.Visible = true;
                panel_Answer.Visible = false;
            }
            else//此时已经是大题了
            {
                panel_Selection.Visible = false;
                panel_Answer.Visible = true;
            }


            //试题图片的展示

            pictureBox1.Image = Image.FromFile(Quest[Pindex]); //展示当前视图
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            //对当前答案的 处理
            if(Pindex < 12)
            {
                InitSelectionCheck();
            }
            else
            {
                //InitPathAndPic();
                InitrichTextBox(); //展示当前输入的文字
            }

            //txt_Index.Text = String.Format("")
            if(Pinit.pType == 1) //如果是小题训练
            {
                txt_Index.Text = String.Format("当前试题为{0}/16", Pindex+1);
            }else if(Pinit.pType == 2)// 如果是大题训练
            {
                
                txt_Index.Text = String.Format("当前试题为{0}/7", Pindex - 15);
                
            }
            else
            {
                txt_Index.Text = String.Format("当前试题为{0}/23", Pindex+1);
            }
        }
        private void FreshPanel_Viewer()//观察者模式
        {
            FreshPanel_Doer(); //刷新当前页面
            //panel1.Enabled = false;
            //panel1.Visible = false;
            panel_Answer.Enabled = false;
            panel_Answer.Visible = false;
            panel_Selection.Enabled = false;
            panel_Selection.Visible = false;

        }
        private String ReturnSelection() //判断当前选项，返回一个字符串，用于插入答案的时候用
        {
            
            if (rad_A.Checked)
            {
                return "A";
            }else if (rad_B.Checked)
            {
                return "B";
            }else if (rad_C.Checked)
            {
                return "C";
            }else if (rad_D.Checked)
            {
                return "D";
            }
            else
            {
                return "";
            }
        }
        //private String ReturnPath()//返回当前页面上的答案图片连接
        //{
        //    return txt_Answer.Text.ToString();
        //}
        private void InitSelectionCheck() //根据当前答案点亮对应的radiobutton,本方法当今当在index<16的情况下使用
        {
            if(Answer.Answer[Pindex] == "A")
            {
                rad_A.Checked = true;
            }else if(Answer.Answer[Pindex] == "B")
            {
                rad_B.Checked = true;
            }
            else if (Answer.Answer[Pindex] == "C")
            {
                rad_C.Checked = true;
            }
            else if (Answer.Answer[Pindex] == "D")
            {
                rad_D.Checked = true;
            }
            else
            {
                rad_A.Checked = false;
                rad_B.Checked = false;
                rad_C.Checked = false;
                rad_D.Checked = false;
            }
            
        }

        private void InitrichTextBox() //根据当前答案输入到richtextbox中去，因为没有用到imagebox，所以不需要判空
        {

            richTextBox1.Text = null;
            richTextBox1.Text = Answer.Answer[Pindex];

        }
        //private void InitPathAndPic() //根据对应答案，填充txt_Answer和pictureBox2
        //{
        //    if (Answer.Answer[Pindex] != null && Answer.Answer[Pindex]!="") //需要判空，否则image容易报错
        //    {
        //        //txt_Answer.Text = Answer.Answer[Pindex];
        //        //pictureBox2.Image = Image.FromFile(Answer.Answer[Pindex]); //展示当前视图
        //        //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; //图片是收缩的，总之有了看得到其实就行
        //    }
        //    else
        //    {
        //        //pictureBox2.Image = null;
        //        ////txt_Answer.Text = "";
        //        //pictureBox2.Refresh();
        //    }
        //}

        private void UpdateAnswer() //点击下一题 或者 上一题 或 提交的时候，更新Answer 字符串数组
        {
            if (Pindex < 12)
            {
                Answer.Answer[Pindex] = ReturnSelection();
            }
            else
            {
                //Answer.Answer[Pindex] = /*ReturnPath();*/
                Answer.Answer[Pindex] = richTextBox1.Text.ToString(); //如果是填空题或者是问答题，则直接将richTextBox1中的字符串内容输入到answer数组中去
            }
        }
        //private void UpdatePath(int index) //此方法用于检查对应的答案字符串
        //{
                
        //}

        //private void UpdateSelection() //根据当前答案点亮对应的radiobutton,本方法当今当在index<16的情况下使用
        //{
        //    String ans = Answer.Answer[Pindex]; //获取当前索引下的答案
        //    if(ans == "A")
        //    {
        //        rad_A.Checked = true;
        //    }else if(ans == "B")
        //    {
        //        rad_B.Checked = true;
        //    }else if (ans == "C")
        //    {
        //        rad_C.Checked = true;
        //    }else if (ans == "D")
        //    {
        //        rad_D.Checked = true;
        //    }
        //    else//若为空？
        //    {
                
        //    }
        //}
        private void btn_next_Click(object sender, EventArgs e)
        {
            UpdateAnswer(); //将答案注入到数组中去

            if (++Pindex <= QMax)
            {
                if (ViewerMode == 0)//观察模式
                {
                    FreshPanel_Viewer();
                }
                else
                {
                    FreshPanel_Doer();
                }
            }
            else
            {
                Pindex--;
                PublicClass.showMessage("当前已是本试卷最后一题", "翻页提示");            }

           
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            UpdateAnswer(); //将答案注入到数组中去

            if (--Pindex >= QMin)
            {
                if (ViewerMode == 0)
                {
                    FreshPanel_Viewer();
                }
                else
                {
                    FreshPanel_Doer();
                }
            }
            else
            {
                Pindex++;
                PublicClass.showMessage("当前已是本试卷第一题", "翻页提示");
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            UpdateAnswer(); //用户有可能是当前做到最后一题，所以最好是能让用户更新字符串 

            Answer.PaperId = Pinit.PaperId;
            
            if (!PublicClass.DialogConfirm("是否提交当前试卷", "试卷提交"))
            {
                return;
            }
            else
            {
                debug("以提交试题答案，请等候...");
                if (!Answer.RequestInserAnswer())
                {
                    PublicClass.showMessage("答案提交失败，请重新尝试或联系老师", "答案提交");
                }
                else {
                    PublicClass.showMessage("答案提交成功！", "答案提交");
                    this.Close();
                }
                
                
            }
        }

        private void panel_Selection_Paint(object sender, PaintEventArgs e)
        {
            InitSelectionCheck();
        }

        private void panel_Answer_Paint(object sender, PaintEventArgs e)
        {
            //InitPathAndPic();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String AnswerPath = PublicClass.GetPath_Pic();
            //txt_Answer.Text = AnswerPath;
            //pictureBox2.Image = Image.FromFile(AnswerPath); //展示当前视图
            //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            UpdateAnswer();

        }

      
    }
}
