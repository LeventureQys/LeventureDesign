using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeventureDesign
{
    class AnswerCore
    {
        public String[] Answer = new String[23]; // 答案的基本属性
        public int UserId = -1;
        public int PaperId = -1;
        public int ScId = -1;
        public int[] SC = new int[23]; //一张一共二十三个得分的得分数组
        public int scdata = -1;
        public int AnsID = -1;
        public int currentSC = 0;

        public int isSelectionChecked = 0;
       public int isFullChecked = 0;
        //PaperCore paperinit = new PaperCore();

        DataOperator dtop = new DataOperator();
        DataSet dt = new DataSet();
        DataSet ClassSC = new DataSet();//一个代表了某个班级里所有同学成绩的dataset
        PaperCore pinit = new PaperCore();
        //AnswerCore Ainit = new AnswerCore();
        public AnswerCore()
        {

        }


        public bool CheckAnswer() //如果答案栏中有空的值
        {
            foreach (String include in Answer)
            {
                if (include == "")
                {
                    return false;
                }
            }
            return true;
        }
        public bool RequestUpdate() //插入试题申请，会对提交的申请做检查
        {
            bool IsEmpty = false;
            pinit.PaperInit(PaperId);

            if (UserId == -1 || PaperId == -3)
            {
                return false;
            }
            //foreach (String ans in Answer)//遍历答案数组
            //{
            //    if (ans == "" || ans == null)//数组判空
            //    {
            //        IsEmpty = true;
            //        IsEmpty = true;
            //    }
            //}
            if(pinit.pType == 1)//假如当前是小题训练
            {
                for(int i = 0; i < 16; i++)
                {
                    if(Answer[i] == "" || Answer == null)
                    {
                        IsEmpty = true;
                    }
                }
            }else if(pinit.pType == 2)
            {
                for (int i = 16; i < 23; i++)
                {
                    if (Answer[i] == "" || Answer == null)
                    {
                        IsEmpty = true;
                    }
                }
            }else if(pinit.pType == 3)
            {
                for (int i = 0; i < 23; i++)
                {
                    if (Answer[i] == "" || Answer == null)
                    {
                        IsEmpty = true;
                    }
                }
            }

            if (IsEmpty) //如果有题目还没做
            {
                if (PublicClass.DialogConfirm("当前还有试题没做完，请问是否继续提交试题？", "试卷提交"))
                {
                    //如果提交
                    for(int i = 0; i < Answer.Length; i++) //过一遍整个Answer表，避免报错
                    {
                        if (Answer[i] == "" || Answer[i] == null)
                        {
                            Answer[i] = "-1"; //-1在本系统中代表着null
                        }
                    }
                    if (InserAnswer())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            else //如果试题已经做完了，但还是要问一下是否一定要提交试卷了
            {
                if (PublicClass.DialogConfirm("是否确认提交试卷？", "试卷提交"))
                {
                    if (InserAnswer())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }


        }
        private void debug(String test)
        {
            Debug.WriteLine(test);
        }
        public bool InserAnswer() //将当前答案试题插入到表中
        {
            try
            {
                //检查完毕后，进入正式的插入
                CreateSc(); // 先建立一个Sc表
                String Insert = String.Format("Insert into tb_Ansdata(ans1,ans2,ans3,ans4,ans5,ans6,ans7,ans8,ans9,ans10,ans11,ans12,ans13,ans14,ans15,ans16,ans17,ans18,ans19,ans20,ans21,ans22,ans23,userid,paperid,scid) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}')", Answer[0], Answer[1], Answer[2], Answer[3], Answer[4], Answer[5], Answer[6], Answer[7], Answer[8], Answer[9], Answer[10], Answer[11], Answer[12], Answer[13], Answer[14], Answer[15], Answer[16], Answer[17], Answer[18], Answer[19], Answer[20], Answer[21], Answer[22], UserId, PaperId, ScId);
                Insert = Insert.Replace("\\", "\\\\");//插入前需要进行转换，因为已经将答案的路径改为了textbox，所以不需要用这条了，不过谁知道会不会用到呢？留着吧



                int num = dtop.ExecSQLResult(Insert); // 执行插入活动
                if (num == 1)
                {
                    //获取AnsId
                    String strAns = String.Format("select * from tb_Ansdata where paperid={0} and userid={1} and scid={2}", PaperId, UserId, ScId);
                    dt = dtop.GetSqlDataset(strAns); //执行语句，找到生成的dataset
                    A_GetAnsId(dt);

                    commentPaperSelection(PaperId, AnsID); //提交答案之后，直接批改选择题就行了
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool CreateSc() //建立sc表，并获得该sc表的scid
        {
            try
            {
                String Insert = String.Format("insert into tb_scdata(userid,paperid,SelectionChecked,FullChecked) values({0},{1},{2},{3})", UserId, PaperId,isSelectionChecked,isFullChecked);
                int num = dtop.ExecSQLResult(Insert); // 执行插入活动，插入一条只有基本信息的对象

                String Select = String.Format("select * from tb_scdata where userid={0} and paperid={1}", UserId, PaperId);
                dt = dtop.GetSqlDataset(Select); //执行语句，找到生成的dataset
                ScId = A_GetScId(dt); //获得当前的scid

                if (num == 1 && ScId != -1)
                {
                    for (int i = 0; i < SC.Length; i++)
                    {
                        SC[i] = 0; //将sc初始化为0
                    }
                    debug(String.Format("创建sc{0}数组成功", ScId));
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        public int A_GetScId(DataSet ScData) //此条获得ScId
        {
            ScId = int.Parse(ScData.Tables[0].Rows[0][0].ToString());
            return ScId;//获得最前面的那个数字，就是paperid

        }

        public int A_GetAnsId(DataSet AnsData)
        {
            AnsID = int.Parse(AnsData.Tables[0].Rows[0][0].ToString());
            return AnsID;//获得最前面的那个数字，就是paperid
        }
        public bool SC_IsExist(int userId, int paperid) //检查该用户在该考试的sc表是否存在，防止一个学生考两次试题
        {
            string select = String.Format("select * from tb_scdata where userid={0} and paperid={1}", userId, paperid);
            int num = dtop.ExecSQL(select);
            if (num != 0) //倘若搜出来的数字不为0，这里返回的数字其实相当于是工号
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RequestInserAnswer() //提交试卷入口
        {
            //1.插入答案

            if (RequestUpdate()) //此条插入一个答案，所有的操作都在里面了
            {
                debug("插入申请成功");
            }
            else
            {
                return false;
            }

            ////2.根据答案 先对选择题进行批改

            //commentPaperSelection(PaperId, AnsID);
            //debug("提交答案 选择题批改完毕");
            

            return true;


        }

        public bool AnswerInit(int ansid)
        {
            try
            {
                //通过ansid解析得到整个answer类，虽然有点麻烦，但估计之后会用到吧？
                DataSet dts = new DataSet();
                dts = A_Search(ansid); //获得当前类的 dataset
                AnsID = PublicClass.getInt(dts, 0, 0);
                UserId = PublicClass.getInt(dts, 0, 1);
                PaperId = PublicClass.getInt(dts, 0, 2);
                ScId = PublicClass.getInt(dts, 0, 3);
                pinit.PaperInit(PaperId); //初始化试卷类型
                for (int i = 0; i < Answer.Length; i++)
                {
                    Answer[i] = PublicClass.getText(dts, 0, i + 4); //ans[0] = dts[0][4]
                    debug(String.Format("当前第{0}题初始化完毕", i));
                }
                InitSc();
                return true;
            }
            catch (Exception ex)
            {
                debug(ex.ToString());
                return false;
            }

        }

        public bool AnswerInit(int paperid, int userid) //通过试卷ID和userid唯一锁定一个答卷
        {
            try
            {
                if (!A_isExist(paperid, userid))
                {
                     UserId = -1;
                     PaperId = -1;
                    ScId = -1;
                  
                    scdata = -1;
                    AnsID = -1;
                    currentSC = 0;

                    isSelectionChecked = 0;
                    isFullChecked = 0;
                    debug("当前答案初始化失败");
                    return false;
                   
                }

                //通过ansid解析得到整个answer类，虽然有点麻烦，但估计之后会用到吧？
                DataSet dts = new DataSet();
                dts = A_Search(paperid, userid); //获得当前类的 dataset
                AnsID = PublicClass.getInt(dts, 0, 0);
                UserId = PublicClass.getInt(dts, 0, 1);
                PaperId = PublicClass.getInt(dts, 0, 2);
                ScId = PublicClass.getInt(dts, 0, 3);
                InitSc();    //初始化答案

                pinit.PaperInit(PaperId); //初始化试卷类型
                
                for (int i = 0; i < Answer.Length; i++)
                {
                    Answer[i] = PublicClass.getText(dts, 0, i + 4); //ans[0] = dts[0][4]
                    debug(String.Format("当前第{0}题初始化完毕", i));
                }
                
                return true;
            }
            catch (Exception ex)
            {
                debug(ex.ToString());
                return false;
            }
        }
        public DataSet A_Search(int ansid)
        {
            string SearchPaper = "select * from tb_ansdata where ansid=" + ansid;

            dt = dtop.GetSqlDataset(SearchPaper);

            return dt;
        }

        public DataSet A_Search(int paperid, int userid)
        {

            string SearchPaper = String.Format("select * from tb_ansdata where paperid={0} and userid={1}", paperid, userid);

            dt = dtop.GetSqlDataset(SearchPaper);

            return dt;
        }
        public void commentPaperSelection(int paperId, int ansid) // 批改试卷选择题
        {

            debug("进入批改试卷");
            PaperCore paperinit = new PaperCore();
            if (paperinit.PaperInit(paperId))
            {
                debug("批改试卷->paper类初始化成功");
            }
            else
            {
                debug("批改试卷->paper类初始化失败请重新尝试");
                return;
            }

            if (AnswerInit(ansid))
            {
                debug("批改试卷->answer类初始化成功");
            }
            else
            {
                debug("批改试卷->answer类初始化失败");
                return;
            }

            String[] Correct = new String[23]; //正确答案组

            Correct = paperinit.ReturnFullAns(); //这样就得到一个正确答案组

            for (int i = 0; i < 12; i++) //对比选择题
            {
                if (Answer[i] == Correct[i])
                {
                    SC[i] = 5;
                }
                else
                {
                    SC[i] = 0;
                }
            }
            debug("试卷选择题批改成功");
            isSelectionChecked = 1; //修改当前选择题状态
            UpdateSelectionSc(); //上传分数





        }

        public bool UpdateSelectionSc() //更新答案
        {
            int FullSC = 0;

            if(pinit.pType == 1)//如果是小题训练，则总分设定为5x16 = 80
            {
                FullSC = 80;
            }else if(pinit.pType == 2) //大题训练，则总分为70分
            {
                FullSC = 70;
            }else if(pinit.pType == 3)//综合训练，总分150
            {
                FullSC = 150;
            }
            int currentSC = 0;

            for(int i = 0; i < SC.Length; i++) //currentSC为当前sc数组的总和
            {
                currentSC += SC[i];
            }
            String Update = String.Format("update tb_scdata set sc1={0},sc2={1},sc3={2},sc4={3},sc5={4},sc6={5},sc7={6},sc8={7},sc9={8},sc10={9},sc11={10},sc12={11},sc13={12},sc14={13},sc15={14},sc16={15},sc17={16},sc18={17},sc19={18},sc20={19},sc21={20},sc22={21},sc23={22},SelectionChecked={23},FullChecked={24},FullSC={25},CurrentSC={26},pType={27} where scid={28}", SC[0], SC[1], SC[2], SC[3], SC[4], SC[5], SC[6], SC[7], SC[8], SC[9], SC[10], SC[11], SC[12], SC[13], SC[14], SC[15], SC[16], SC[17], SC[18], SC[19], SC[20], SC[21], SC[22], isSelectionChecked, isFullChecked, FullSC, currentSC, pinit.pType, ScId);
            int num = dtop.ExecSQLResult(Update); //运行修改的命令
            if (num != 1)
            {
                debug("上传分数失败");
                return false;
            }
            else
            {
                //debug(String.Format("试卷{0}，q1数组初始化完毕", PaperId));
                debug("上传分数成功");
                return true;
            }

        }

        //public DataSet ReturnAnsByClassId(int classid)//返回当前某个班级在某场考试中某个人的所有答案
        //{
        //    UserManagerMent userinit = new UserManagerMent();
        //    DataSet stu = userinit.StuDataSet_Classid(classid); //赋值得到一个班级上所有学生的id



        //}

        public bool A_isExist(int paperid, int userid) // 检查当前试卷-用户是否有对应答卷
        {
            DataSet dt = new DataSet();
            dt = A_Search(paperid, userid);
            bool Flag = true;
            if ((dt == null) || (dt.Tables.Count == 0) || (dt.Tables.Count == 1 && dt.Tables[0].Rows.Count == 0))
            {
                Flag = false;
            }
            return Flag;

        }

        private void InitSc()
        {
            String Search = String.Format("select * from tb_scdata where paperid={0} and userid={1}", PaperId, UserId);
            dt = dtop.GetSqlDataset(Search); //搜索对应 的sc表
            //对数组进行填充,从标签从5-27

            for(int i = 0; i < SC.Length; i++)
            {
                SC[i] = PublicClass.getInt(dt, 0, i + 7);
            }
            isSelectionChecked = PublicClass.getInt(dt, 0, 5);
            isFullChecked = PublicClass.getInt(dt, 0, 6);
            currentSC = PublicClass.getInt(dt, 0, 3);
            debug("sc表初始化成功");


        }

        public void InitSc(int scid)
        {
            ScId = scid;
            String Search = String.Format("select * from tb_scdata where scid={0} ", scid);
            dt = dtop.GetSqlDataset(Search); //搜索对应 的sc表
            //对数组进行填充,从标签从5-27

            for (int i = 0; i < SC.Length; i++)
            {
                SC[i] = PublicClass.getInt(dt, 0, i + 7);
            }
            PaperId = PublicClass.getInt(dt, 0, 1);
            UserId = PublicClass.getInt(dt, 0, 2);
           
            isSelectionChecked = PublicClass.getInt(dt, 0, 5);
            isFullChecked = PublicClass.getInt(dt, 0, 6);
            currentSC = PublicClass.getInt(dt, 0, 3);
            pinit.PaperInit(PaperId);
            debug("sc表初始化成功");
        }
        //public bool FullSCCheck() //此方法检查试卷是否已批改
        //{

        //}

        public void InitSc(int paperid,int userid)//通过一张试卷id和考生id，可以锁定到一个特定的用户
        {
            if (A_isExist(paperid, userid))
            {
                String Search = String.Format("select * from tb_scdata where paperid={0} and userid={1} ", paperid, userid);
                dt = dtop.GetSqlDataset(Search); //搜索对应 的sc表
                                                 //对数组进行填充,从标签从5-27

                for (int i = 0; i < SC.Length; i++)
                {
                    SC[i] = PublicClass.getInt(dt, 0, i + 7);
                }
                PaperId = PublicClass.getInt(dt, 0, 1);
                UserId = PublicClass.getInt(dt, 0, 2);
                ScId = PublicClass.getInt(dt, 0, 0);
                isSelectionChecked = PublicClass.getInt(dt, 0, 5);
                isFullChecked = PublicClass.getInt(dt, 0, 6);
                currentSC = PublicClass.getInt(dt, 0, 3);
                pinit.PaperInit(PaperId);
                debug("sc表初始化成功");
            }
            debug(String.Format("用户-paperid:{0},userid:{1}的答卷不存在", paperid, userid));
        }

        public DataSet GetSc(int paperid,int userid)//给定试卷id和用户id，返回一个sc dataset
        {
            String Select = String.Format("Select * from tb_scdata where paperid={0} and userid={1}", paperid, userid);
            return dtop.GetSqlDataset(Select);
        }

        public DataSet GetSc_All()
        {
            return dtop.GetSqlDataset("select * from tb_scdata");
        }
        public int[] SCToCid(int scid)//给定一个sc表，返回其对应的Cid表,每个不同的试卷类型，会返回一个对应的23长度数组
        {
            InitSc(scid); //先对其进行初始化,这样就可以得到一个初始化了的pinit，这样我就有了一个QuestID数组来表示我的所有题目了
            QManagerment Qinit = new QManagerment();
            int[] temp = new int[23];
            for(int i = 0; i < 23; i++)
            {
                Qinit.Q_Init(pinit.QuestID[i]);
                temp[i] = Qinit.ReturnCid();
            }

            return temp;

        }

        public DataSet ClassSCDataset(int paperid,int classid)//输入一个paperid和classid，返回一个班级中所有成员该试卷答卷的SCdataset
        {
            
            UserManagerMent userinit = new UserManagerMent();//临时要用的userinit类
            //ClassSC.Tables.Add("lwx");//添加一张表，叫lwxk
            
            DataSet temp = new DataSet();// 需要先同意temp和ClassSC两个表的格式
            DataRow temprow;
            DataSet pattern = GetSc_All();

            temp = pattern.Clone();
            ClassSC = pattern.Clone(); //这下两张都是sc表了
            int[] Students = userinit.StudentID_Includedby_Classid(classid); //通过classid得到一个students的userid数组
            


            for(int i = 0; i < Students.Length; i++)
            {
                if(Students[i]!=0 && Students[i] != -1)//遍历班上所有学生，然后将其一条条插入到表中
                {
                    
                    temp = GetSc(paperid, Students[i]);
                    if (temp.Tables[0].Rows.Count > 0) //如果当前表中没有得分，就算了
                    {
                        temprow = temp.Tables[0].Rows[0];

                        //temprow = ClassSC.Tables[0].NewRow();
                        //ClassSC.Tables["lwx"].Rows.Add(temprow);
                        ClassSC.Tables[0].ImportRow(temprow);
                    } 
                    

                }
            }
            return ClassSC;
        }
        public double ClassAverage(int paperid,int classid)//输入ClassSc，返回班级考试总分平均分
        {

            DataSet Class = ClassSCDataset(paperid, classid);

            double AllSc = 0.0;

            for(int i = 0; i < Class.Tables[0].Rows.Count; i++)
            {
                AllSc += PublicClass.getInt(Class, 0, 3);
            }

            double Average = AllSc / Class.Tables[0].Rows.Count;

            return Average;
        }
    }
}
