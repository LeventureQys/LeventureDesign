using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeventureDesign
{

    public class PaperCore
    {
        //一些需要调用到的类
        DataOperator dtop = new DataOperator();
        UserManagerMent userInit = new UserManagerMent();
        QManagerment questInit = new QManagerment();
        
        DataSet st = new DataSet();
        DataSet Vr_show = new DataSet(); // 此试卷当前的视图，通过Paper_GetVR方法生成

        public int PaperId;  //一个主键

        public int pType;  //试卷种类，1为小题训练，2为大题训练，3为综合训练

        public int classid = 0; //使用该试卷考试的班级，如果为0则代表其为公共试卷

        //int TargetDiff; //理想难度

        //float IndeedDiff; //实际难度

        public int month; //试卷申请月份

        public int Number; //第x次申请试卷

        public String Level; //申请试卷的年级,对应class表中的level值，如果是选择班级的试卷，则直接从班级数据中解析，如果是公共试卷，则需要设定

        public int[] q1 = new int[9]; // 试卷题号,1->9

        public int[] q2 = new int[3]; //试卷题号,10-12

        public int[] q3 = new int[2]; //13->14

        public int[] q4 = new int[2]; //15-16

        public int q5; //17

        public int q6; //18

        public int q7; //19

        public int q8; //20

        public int q9; //21

        public int q10; //22

        public int q11; //23

        public int[] QuestID = new int[23];

        public void debug(String strMessage)
        {
            Debug.WriteLine(strMessage);
        }

        public DataSet[] quest = new DataSet[23];  // 一个23位的dataset数组
        public String Pname = "";
        int ClassName; //班号，由classid获得
        public int PYear;
        public String[] Ans = new String[23]; //正确答案数组
        public PaperCore() //初始化函数
        {
            PaperId = -1;
            pType = -1;
            month = -1;
            Number = -1;
            Level = "";
            for (int i = 0; i < q1.Length; i++)
            {
                q1[i] = -1;
            }
            for (int i = 0; i < q2.Length; i++)
            {
                q2[i] = -1;
            }
            for (int i = 0; i < q3.Length; i++)
            {
                q3[i] = -1;
            }
            for (int i = 0; i < q4.Length; i++)
            {
                q4[i] = -1;
            }
        q5 =-1; //17
        q6 = -1; //18
        q7 = -1; //19
        q8 = -1; //20
        q9 = -1; //21
        q10 = -1; //22
        q11 = -1; //23
    }

        public bool PaperInit(int pid)//从数据库中通过paperid搜索得到需要的数据来初始化一个类
        {
            try
            {

                //1.获取dataset
                //2.解析dataset注入到本类中去
                DataSet dts = new DataSet();
                dts = PSearch(pid);

                PaperId = PublicClass.getInt(dts, 0, 0); //获得paperid
                pType = PublicClass.getInt(dts, 0, 1); //获得dts的pType
                classid = PublicClass.getInt(dts, 0, 2);
                month = PublicClass.getInt(dts, 0, 3);
                Number = PublicClass.getInt(dts, 0, 4);
                Level = PublicClass.getText(dts, 0, 5);
                Pname = PublicClass.getText(dts, 0, 6);
                PYear = PublicClass.getInt(dts, 0, 30);
                //初始化QuestID数组

                for(int i = 0; i < QuestID.Length; i++)
                {
                    QuestID[i] = PublicClass.getInt(dts, 0, i+7);//QuestID[0] = dts[0][7]
                    debug(String.Format("当前初始化到第{0}题", i+1));
                }

                //初始化q1
                for (int i = 0; i < q1.Length; i++)
                {
                    q1[i] = PublicClass.getInt(dts, 0, i + 7); //q1[0] = dts[0][8]
                    debug(String.Format("当前初始化到1-9题中的第{0}题", i));
                }


                //初始化q2

                for (int i = 0; i < q2.Length; i++)
                {
                    q2[i] = PublicClass.getInt(dts, 0, i + 16);//q2[0] = dts[0][16]
                    debug(String.Format("当前初始化到10-12题中的第{0}题", i + 10));
                }

                //初始化q3
                for (int i = 0; i < q3.Length; i++)
                {
                    q3[i] = PublicClass.getInt(dts, 0, i + 19); //q3[0] = dts[0][19]
                    debug(String.Format("当前初始化到13-14题中的第{0}题", i + 13));
                }

                //初始化q4
                for (int i = 0; i < q4.Length; i++)
                {
                    q4[i] = PublicClass.getInt(dts, 0, i + 21);//q4[0] = dts[0][21]
                    debug(String.Format("当前初始化到15-16题中的第{0}题", i + 15));
                }
                q5 = PublicClass.getInt(dts, 0, 23);
                debug(String.Format("当前初始化到17题"));
                q6 = PublicClass.getInt(dts, 0, 24);
                debug(String.Format("当前初始化到18题"));
                q7 = PublicClass.getInt(dts, 0, 25);
                debug(String.Format("当前初始化到19题"));
                q8 = PublicClass.getInt(dts, 0, 26);
                debug(String.Format("当前初始化到20题"));
                q9 = PublicClass.getInt(dts, 0, 27);
                debug(String.Format("当前初始化到21题"));
                q10 = PublicClass.getInt(dts, 0, 28);
                debug(String.Format("当前初始化到22题"));
                q11 = PublicClass.getInt(dts, 0, 29);
                debug(String.Format("当前初始化到23题"));

                debug(String.Format("当前初始化成功"));

                ReturnFullAns(); //初始化当前类的答案数组
                return true;
            }
            catch(Exception ex)
            {
                debug(ex.ToString());
                debug("Paper初始化失败");
                return false;
            }
        }
        public void AnalysisLevel() //通过类中的Cid，分析返回得到Level,并注入到Level字符串中
        {
            UserManagerMent UserInit = new UserManagerMent();
            Level = UserInit.GetLevel(classid); //修改类中的Level值

        }

        public int AnalysisMonth(ComboBox box1) // 根据输入解析出月份，从combobox中输入一个index，然后那个index是从0开始的，+1即可
        {
            return box1.SelectedIndex+1;
        }

        public bool CreatePapter() //进行试卷生成
        {
            try
            {
                //生成试卷首先检查所有参数是否已经备齐
                //是初始化的检查
                if (!InitCheck())
                {
                    debug("初始化检查失败，请检查数组输入数组输入是否正常");
                    return false;
                }


                //若试卷基本属性以备齐
                //1.生成试卷名称
                //2.向数组中输入试卷
                //3.将试卷信息插入数据库

                //1生成试卷名
                Pname = CreatPName(); //生成一个试卷名
                debug("试卷名称生成成功");

                //2.向数组中输入试卷
                if (!InitPArrary()) //初始化试题数组
                { return false; }
                //试卷中每道试题的id获取成功

                //3.将试卷信息插入数据库
                if (!InsertQuest()) //将一个试卷的壳插入数据库8
                {
                    return false;
                }
                debug("试卷外壳生成成功");


                if (!UpdateQuestions())//向之前生成的试卷外壳进行试题插入
                {
                    debug("试卷生成失败");
                    return false; //失败则返回失败
                }
                else
                {
                    debug(String.Format("试卷生成成功，试卷号为{0}", PaperId));

                    return true;
                }
            }catch(Exception ex)
            {
                debug(ex.ToString());
                return false;
            }


            //return true;


        }

        public bool isExist(int number, int month, String Level)
        {
            string select = String.Format("select * from tb_paperdata where number={0} and month={1} and Level='{2}'",number,month,Level);
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

        public String CreatPName()
        {
            try
            {
                String Name = "";
                if (classid == 0)//如果是公共试卷
                {
                    Name = String.Format("育才中学{0}年级{3}年{1}月第{2}次考试", Level, month, Number,PYear);
                }
                else //如果有指定班级
                {
                    Name = String.Format("育才中学{0}年级{1}班{4}年{2}月第{3}次考试", Level, ClassName, month, Number,PYear);
                }
                return Name;
            }catch(Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "试卷名称生成失败");
                return "";
            }
        }

        public bool InsertQuest() //插入一个试题外壳
        {
            String Sql = String.Format("insert into tb_paperdata(pType,classid,month,number,level,pname,pyear) values({0},{1},{2},{3},'{4}','{5}',{6})", pType, classid, month, Number, Level, Pname,PYear);
            //Sql = str.ToString().Replace("\\", "\\\\");
            int num = dtop.ExecSQLResult(Sql); // 执行插入活动，插入一条只有基本信息的对象
            //int PNO = int.Parse(String.Format("Select * from tb_paperdata where ptype={0} and classid={1},month={2},level={3},number={4},pname={5}", pType, classid, month, Number, Level, Pname));
            
            String Search = String.Format("Select * from tb_paperdata where ptype='{0}' and classid='{1}' and month='{2}' and level='{3}' and number='{4}' and pname='{5}' and pyear='{6}'", pType, classid, month, Level, Number, Pname,PYear);
            DataSet st = new DataSet();
            st = dtop.GetSqlDataset(Search); //执行语句，找到生成的dataset

            PaperId = P_GetPaperId(st); //插入试卷后，将生成的试卷的paperId赋值给PaperId主键

            if (num != 0)
            {
                //PublicClass.showMessage("试题生成成功", "插入提示");
                //UpdateQuestions(); //上传试题
                return true;
            }
            else
            {
                PublicClass.showMessage("题目生成失败，请检查输入数据 或 联系管理员", "插入提示");
                return false;
            }
        }

        public bool UpdateQuestions() //初始化试卷的命题
        {
            try
            {
                String Updateq1 = String.Format("update tb_paperdata set qid1={0},qid2={1},qid3={2},qid4={3},qid5={4},qid6={5},qid7={6},qid8={7},qid9={8} where paperid={9}", q1[0], q1[1], q1[2], q1[3], q1[4], q1[5], q1[6], q1[7], q1[8], PaperId);
                //debug(String.Format("试卷{0}，q1数组初始化完毕", PaperId));
                int num = dtop.ExecSQLResult(Updateq1); //运行修改的命令
                if (num != 1)
                {
                    debug("数组q1初始化失败");
                    return false;
                }
                else
                {
                    debug(String.Format("试卷{0}，q1数组初始化完毕", PaperId));

                }

                String Updateq2 = String.Format("update tb_paperdata set qid10={0},qid11={1},qid12={2} where paperid={3}", q2[0], q2[1], q2[2], PaperId);
                //debug(String.Format("试卷{0}，q2数组初始化完毕", PaperId));
                num = dtop.ExecSQLResult(Updateq2); //运行修改的命令
                if (num != 1)
                {
                    debug("数组q2初始化失败");
                    return false;
                }
                else
                {
                    debug(String.Format("试卷{0}，q2数组初始化完毕", PaperId));

                }

                String Updateq3 = String.Format("update tb_paperdata set qid13={0},qid14={1} where paperid={2}", q3[0], q3[1], PaperId);
                //debug(String.Format("试卷{0}，q2数组初始化完毕", PaperId));
                num = dtop.ExecSQLResult(Updateq3); //运行修改的命令
                if (num != 1)
                {
                    debug("数组q3初始化失败");
                    return false;
                }
                else
                {
                    debug(String.Format("试卷{0}，q3数组初始化完毕", PaperId));
                }

                String Updateq4 = String.Format("update tb_paperdata set qid15={0},qid16={1} where paperid={2}", q4[0], q4[1], PaperId);
                //debug(String.Format("试卷{0}，q2数组初始化完毕", PaperId));
                num = dtop.ExecSQLResult(Updateq4); //运行修改的命令
                if (num != 1)
                {
                    debug("数组q4初始化失败");
                    return false;
                }
                else
                {
                    debug(String.Format("试卷{0}，q4数组初始化完毕", PaperId));
                }

                String UpdateBigQuest = String.Format("update tb_paperdata set qid17={0},qid18={1},qid19={2},qid20={3},qid21={4},qid22={5},qid23={6} where paperid={7}", q5,q6,q7,q8,q9,q10,q11,PaperId);
                //debug(String.Format("试卷{0}，q2数组初始化完毕", PaperId));
                num = dtop.ExecSQLResult(UpdateBigQuest); //运行修改的命令
                if (num != 1)
                {
                    debug("大题加载初始化失败");
                    return false;
                }
                else
                {
                    debug(String.Format("试卷{0}，大题初始化完毕", PaperId));
                    return true; //此时所有题目理应加载完毕
                }

                //return false;
            }
            catch(Exception ex)
            {
                debug(ex.ToString());
                return false;
            }

        }
        public bool InitCheck()//数据完整性的必要检查
        {
            String Title = "试卷生成错误";
            ClassName = userInit.GetNum_WithClassid(classid); //获得班级的名称

            if (month == -1)
            {
                PublicClass.showMessage("请输入正确月份", Title);
                debug("输入检查失败，请输入正确月份");
                return false;
            }
            else if (Number == -1)
            {
                PublicClass.showMessage("请输入此次考试是当月第几次测试", Title);
                debug("输入检查失败");
                return false;
            }
            else if (Level == "")
            {
                PublicClass.showMessage("请输入考试年级", Title);
                debug("输入检查失败");
                return false;
            }
            else if (pType == -1)
            {
                PublicClass.showMessage("请输入试卷类型", Title);
                debug("输入检查失败");
                return false;
            }
            debug("输入检查完成");
            return true;
        }
        public bool InitPArrary() //初始化试题数组
        {
            try
            {
                //bool access = false; //一个用于判断数组是否重复的值
                do //循环，当数组不再重复为止
                {
                    for (int i = 0; i < q1.Length; i++)
                    {
                        q1[i] = questInit.GetRandomQuest(0);
                        Thread.Sleep(250);

                    }
                } while (PublicClass.ArrayIsReapted(q1)); //注意这个感叹号之后是需要去掉的，表示如果其中的数组如果不为真，则继续

                debug("q1数组生成完成");

                do
                {
                    for (int i = 0; i < q2.Length; i++)
                    {
                        q2[i] = questInit.GetRandomQuest(1);
                        Thread.Sleep(500);
                    }
                } while (PublicClass.ArrayIsReapted(q2));
                debug("q2数组生成完成");

                do
                {
                    for (int i = 0; i < q3.Length; i++)
                    {
                        q3[i] = questInit.GetRandomQuest(2);
                        Thread.Sleep(500);
                    }
                } while (PublicClass.ArrayIsReapted(q3));
                debug("q3数组生成完成");

                do
                {
                    for (int i = 0; i < q4.Length; i++)
                    {
                        q4[i] = questInit.GetRandomQuest(3);
                        Thread.Sleep(100);
                    }
                } while (PublicClass.ArrayIsReapted(q4));

                debug("q4数组生成完成");


                 q5 = questInit.GetRandomQuest(4);
                Thread.Sleep(100);
                debug("q5生成完成");
                q6 = questInit.GetRandomQuest(5);
                Thread.Sleep(100);
                debug("q6生成完成");
                q7 = questInit.GetRandomQuest(6);
                Thread.Sleep(100);
                debug("q7生成完成");
                q8 = questInit.GetRandomQuest(7);
                Thread.Sleep(100);
                debug("q8生成完成");
                q9 = questInit.GetRandomQuest(8);
                Thread.Sleep(100);
                debug("q9生成完成");
                q10 = questInit.GetRandomQuest(9);
                Thread.Sleep(100);
                debug("q10生成完成");
                q11 = questInit.GetRandomQuest(10);
                Thread.Sleep(100);
                debug("q11生成完成");
                return true;
                //试卷中每道试题的id获取成功
                //此时试卷生成完成

                //将试卷内容插入数据库
            }catch(Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "试题数组生成出错");
                debug(ex.ToString());
                return false;

            }
        }
        public DataSet PSearch(int paperid) //通过试卷编号搜索返回试卷的dataset
        {
            string SearchPaper = "select * from tb_paperdata where paperid=" + paperid;

            st = dtop.GetSqlDataset(SearchPaper);

            return st;
        }

        public int P_GetPaperId(DataSet PaperSet)
        {
             return int.Parse(PaperSet.Tables[0].Rows[0][0].ToString());//获得最前面的那个数字，就是paperid
            
        }

        //public bool updateQuest()
        //{

        //}
        public int GetPNumber()//此方法获得该年级(该班)本月第几次进行测试
        {
            try
            {
                if (classid != 0)//若非年级公共试卷
                {
                    String Sql = String.Format("Select * from tb_paperdata where classid={0} and month={1} and Level='{2}'", classid, month, Level);
                    st = dtop.GetSqlDataset(Sql);//执行此语句
                    if (st.Tables.Count != 0)
                    {
                        debug("非年级公共试卷数量获得成功");
                        return st.Tables[0].Rows.Count+1; //获得该表中数据个数
                    }
                    else
                    {
                        debug("非年级公共试卷数量获得失败");
                        return -1;
                    }
                    
                }
                else//若为年级公共试卷5
                {
                    String Sql = String.Format("Select * from tb_paperdata where month={0} and Level='{1}'", month, Level);
                    st = dtop.GetSqlDataset(Sql);//执行此语句
                    if (st.Tables.Count != 0)
                    {
                        debug("年级公共试卷数量获得成功");
                        return st.Tables[0].Rows.Count+1; //获得该表中数据个数
                    }
                    else
                    {
                        debug("年级公共试卷数量获得失败");
                        return -1;
                    }

                }
                //return st.Tables[0].Rows.Count; //获得该表中数据个数
                
            }catch(Exception ex)
            {
                //debug("年级公共试卷数量获得失败");
                debug(ex.ToString());
                return -1;
            }
        }

        //public DataSet PSearch_
        public DataSet Search_Index() //从vr_paper_index表中查找到对象
        {
            //String Search = " select * from vr_paperdata_index"; //从vr_paper_index表中查找到对象
            try
            {
                String Search;
                
                if (PublicClass.isStu == true)
                {
                    userInit.initUser(PublicClass.PresentUserID);
                    Search = String.Format(" select * from tb_paperdata where classid={0} or classid=0 order by paperid desc", userInit.UserClassid);
                }
                else
                {
                     Search = " select * from tb_paperdata order by paperid desc";
                }
                
                DataSet st = new DataSet();
                st = dtop.GetSqlDataset(Search);

                return st;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return null;
            }
        }
        public DataSet Search_Index(int classid){
            try
            {
                String Search = String.Format(" select * from tb_paperdata where classid={0} or classid=0 order by paperid Desc",classid);
                DataSet st = new DataSet();
                st = dtop.GetSqlDataset(Search);

                return st;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return null;
            }
        } //如果输入班级，则从当前表中查找所有

        public String[] ReturnFullAns() //此条返回当前试卷中的正确答案数组,使用此方法前需要对类成员进行初始化
        {
            //获得题号数组 -》此步并没有必要，初始化的时候类中有一个自带的Question数组，里面包含了所有的试题题号

            //String[] Question = new String[23];
            //DataSet dts = new DataSet();

            //dts = PSearch(PaperId); 
            //for(int i = 0; i < Question.Length; i++)
            //{
            //    Question[i] = PublicClass.getText(dts, 0, i + 7); //question[0] = dts[0][7]
            //}

            //注意 其中选择题的判断通过index去操作

            QManagerment Qinit = new QManagerment();//初始化一个QManagerment类

            //String[] Ans = new String[23]; //一个答案的字符串数组

            for(int i = 0; i < Ans.Length; i++)
            {
                Ans[i] = Qinit.ReturnAns(QuestID[i]);
            }
            debug("数组初始化成功");
            return Ans;

        }

        public bool DelPaper(int paperid)
        {
            String Del = String.Format("delete from tb_paperdata where paperid={0}", paperid);
            String Del_SC = String.Format("delete from tb_scdata where paperid={0}", paperid);
            String Del_Ans = String.Format("delete from tb_ansdata where paperid={0}", paperid);
            int num = dtop.ExecSQLResult(Del); //运行删除uid的命令
            int num_1 = dtop.ExecSQLResult(Del_SC);
            int num_2 = dtop.ExecSQLResult(Del_Ans);
            if (num == 1) //只要删除了试卷就行，至于sc表和ans表中的信息，有没有删除不是重要指标
            {
                
                return true;
            }
            else
            {
                
                return false;
            }
        }

        public DataSet PaperDatasetRecent_ByClassid_1(int classid)//返回一个班级近十次的小题测试考试试卷dataset
        {
            String Select = String.Format("Select * from tb_paperdata where classid={0} and ptype={1}", classid,1);

            DataSet Return = dtop.GetSqlDataset(Select);
            DataSet temp = new DataSet();

            if (Return.Tables[0].Rows.Count <= 10)
            {
                temp = Return;
            }
            else {
                temp = Return.Clone(); //复制结构，否则识别不到表很恶心
                int Length = Return.Tables[0].Rows.Count; //该表长度
                for (int i = 9; i >= 0; i--)//进行切片
                {
                    DataRow dr = temp.Tables[0].NewRow();
                    DataRow row = Return.Tables[0].Rows[Length - i-1];
                    dr.ItemArray = row.ItemArray;
                    temp.Tables[0].Rows.Add(dr);
                }
            }

            return temp;
        }

        public DataSet PaperDatasetRecent_ByClassid_2(int classid) //大题测试
        {
            String Select = String.Format("Select * from tb_paperdata where classid={0} and ptype={1}", classid, 2);

            DataSet Return = dtop.GetSqlDataset(Select);
            DataSet temp = new DataSet();

            if (Return.Tables[0].Rows.Count <= 10)
            {
                temp = Return;
            }
            else
            {
                temp = Return.Clone(); //复制结构，否则识别不到表很恶心
                int Length = Return.Tables[0].Rows.Count; //该表长度
                for (int i = 9; i >= 0; i--)//进行切片
                {
                    DataRow dr = temp.Tables[0].NewRow();
                    DataRow row = Return.Tables[0].Rows[Length - i];
                    dr.ItemArray = row.ItemArray;
                    temp.Tables[0].Rows.Add(dr);
                }
            }

            return temp;
        }

        public DataSet PaperDatasetRecent_ByClassid_3(int classid) //大题测试
        {
            String Select = String.Format("Select * from tb_paperdata where classid={0} and ptype={1}", classid, 3);

            DataSet Return = dtop.GetSqlDataset(Select);
            DataSet temp = new DataSet();

            if (Return.Tables[0].Rows.Count <= 10)
            {
                temp = Return;
            }
            else
            {
                temp = Return.Clone(); //复制结构，否则识别不到表很恶心
                int Length = Return.Tables[0].Rows.Count; //该表长度
                for (int i = 9; i >= 0; i--)//进行切片
                {
                    DataRow dr = temp.Tables[0].NewRow();
                    DataRow row = Return.Tables[0].Rows[Length - i-1];
                    dr.ItemArray = row.ItemArray;
                    temp.Tables[0].Rows.Add(dr);
                }
            }

            return temp;
        }

        //public DataSet Pape
        public int[] PaperidsRecent_ByClassid_1(int classid) //返回某个班级近十场考试的paperids的数组
        {
            DataSet Classes = PaperDatasetRecent_ByClassid_1(classid);
            int[] Paperids = new int[Classes.Tables[0].Rows.Count];//一个用来获得所有paperid的数组
            for (int i = 0; i < Paperids.Length; i++)
            {
                Paperids[i] = PublicClass.getInt(Classes, i, 0);
            }
            return Paperids;
        }

        public int[] PaperidsRecent_ByClassid_2(int classid) //返回某个班级近十场考试的paperids的数组
        {
            DataSet Classes = PaperDatasetRecent_ByClassid_2(classid);
            int[] Paperids = new int[Classes.Tables[0].Rows.Count];//一个用来获得所有paperid的数组
            for (int i = 0; i < Paperids.Length; i++)
            {
                Paperids[i] = PublicClass.getInt(Classes, i, 0);
            }
            return Paperids;
        }

        public int[] PaperidsRecent_ByClassid_3(int classid) //返回某个班级近十场考试的paperids的数组
        {
            DataSet Classes = PaperDatasetRecent_ByClassid_3(classid);
            int[] Paperids = new int[Classes.Tables[0].Rows.Count];//一个用来获得所有paperid的数组
            for (int i = 0; i < Paperids.Length; i++)
            {
                Paperids[i] = PublicClass.getInt(Classes, i, 0);
            }
            return Paperids;
        }



    }


}
