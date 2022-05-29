using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeventureDesign
{
    class AnalyseCore //分析核
    {
        DataOperator dtop = new DataOperator();
        UserManagerMent Uinit = new UserManagerMent();
        //DataSet AllDataSet = new DataSet();
        DataSet RankFull = new DataSet(); //全年级排序
        //DataSet ClassFull = new DataSet(); //班内排序

        DataSet RecentRankStu_3 = new DataSet(); //一个学生十次考试成绩的DataSet
        DataSet RecentRankStu_2 = new DataSet(); //一个学生十次考试成绩的DataSet
        DataSet RecentRankStu_1 = new DataSet(); //一个学生十次考试成绩的DataSet
        DataSet RecentRankStu = new DataSet(); //一个学生的十次考试成绩的DataSet

        DataSet AllRankStu_3 = new DataSet(); //一个学生的所有综合考试成绩的dataset
        DataSet AllRankStu_2 = new DataSet();
        DataSet AllRankStu_1 = new DataSet();
        DataSet AllRankStu = new DataSet();

        public int currentUser = -1; //当前被分析的用户id
        public int PaperID = -1;
        public int ClassID = -1;
        public int EnterMode = -1; //此模式决定了是学生还是老师

        //RecentSc数组用来存放近十次考试的总分，来表示其走势
        public int[] RecentSC_3 = new int[10];
        public int[] RecentSC_2 = new int[10];
        public int[] RecentSC_1 = new int[10];
        
        public double Linear_1;
        public double Linear_2;
        public double Linear_3;
        /// <summary>
        ///三个方差
        /// </summary>
        public double Var_1;
        public double Var_2;
        public double Var_3;

        //public double[] weak = new double[9]; //定义一个弱点参数，其中0-4 选修1-5 5圆曲 6导数 7坐标系与参数方程 8不等式选讲
        public double[] weakTarget = new double[23]; //做一个23个元素的弱点数组，用来标记哪几个题是弱点，其中weak值为 本题扣分/150 ，weakTarget中每个值的初始值都为0
                                                     
        public double[] TargetWeakness = new double[9];
        PaperCore pinit = new PaperCore();
        const double Per_3 = 1.00 / 1500;//综合训练中的分均带权
        const double Per_2 = 1.00 / 700; //大题训练中的分均带权
        const double Per_1 = 1.00 / 800; //小题训练中的分均带权

        public AnalyseCore() //分析只针对个人，不需要考虑试卷，因为每个人的成绩是通过十张试卷来完成的
        {
            //for (int i = 0; i < weak.Length; i++)
            //{
            //    weak[i] = 0.0; //初始化weak数组
            //}

            for(int i = 0; i < weakTarget.Length; i++)
            {
                weakTarget[i] = 0; //初始化weakTarget数组
            }
        }
        //public void AnalyseCoreInit(int user)//初始化两种方案，一种是 学生调用的，针对个人的，一种是管理员 和 老师查看的整体的
        //{
        //    currentUser = user;
        //    Uinit.initUser(user); //初始化user类
        //}


        //public void AnalyseCoreInit(int user,int paperid) 
        //{
        //    currentUser = user;
        //    PaperID = paperid;
        //}

        public DataSet GetRankFull_withPaperId() //查询到某个试卷对应的所有sc表
        {
            String Select = String.Format("select * from tb_scdata where paperid={0} ORDER BY FullSC", PaperID); //

            RankFull = dtop.GetSqlDataset(Select); //获得整张试卷的排序

            return RankFull;
        }

        public DataSet RankASC(int paperid)//获得某个试卷的RankFull之后给某张试卷排名
        {
            String Select = String.Format("select * from tb_scdata where paperid={0} and FullChecked=1 ORDER BY CurrentSC DESC", PaperID); //

            RankFull = dtop.GetSqlDataset(Select); //获得整张试卷的排序

            RankFull = DtsAnalyse(RankFull); //处理下RankFull

            return RankFull;
        }
        //public void RankAllDataSet()//将获取来的AllDataSet排序
        //{

        //}

        //public void GetRankClassFull_withPaperId(int paperid,int classid)
        //{
        //    String Select = String.Format("select * from tb_scdata where paperid={0} and classid={1} ORDER BY FullSC", paperid,classid); //通过

        //   ClassFull = dtop.GetSqlDataset(Select); //获得整张试卷的排序
        //}

        
        public DataSet DtsAnalyse(DataSet dt) //处理dataset，令其带有排名和姓名两项，用于展示整张试卷的带排名data
        {
            dt.Tables[0].Columns.Add("排名", typeof(int));//插入一个int类型的列
            dt.Tables[0].Columns["排名"].SetOrdinal(0); //插入其到第一列

            dt.Tables[0].Columns.Add("姓名", typeof(String));//插入一个int类型的列
            dt.Tables[0].Columns["姓名"].SetOrdinal(2); //插入其到第一列
            //int rowLength = 0;
            //rowLength = RankFull.Tables[0].Rows.Count;//rowlength为rankfull表的长度

            for (int i = 0; i < RankFull.Tables[0].Rows.Count; i++)//遍历整个dataset
            {
                dt.Tables[0].Rows[i][0] = i + 1; //从上到下进行一个排名
                Uinit.initUser(int.Parse(RankFull.Tables[0].Rows[i][4].ToString())); //初始化一个uinit
                dt.Tables[0].Rows[i][2] = Uinit.UserName;
            }
            return RankFull;
        }
        public void StuSCdts(int userid) //获得一个学生的所有考试情况
        {
            String Select_3 = String.Format("select * from tb_scdata where userid={0} and pType={1} and FullChecked=1",userid,  3); //抓取ptype=3的综合试卷
            String Select_2 = String.Format("select * from tb_scdata where userid={0} and pType={1} and FullChecked=1",userid, 2); //抓取ptype=2的综合试卷
            String Select_1 = String.Format("select * from tb_scdata where userid={0} and pType={1} and FullChecked=1",userid,1); //抓取ptype=1的综合试卷
            String Select = String.Format("select * from tb_scdata where userid={0}and FullChecked=1", userid); //抓取近十场考试的成绩，无论种类，用作弱点分析

            AllRankStu_3 = dtop.GetSqlDataset(Select_3);  //获得该学生的所有试卷排列
            AllRankStu_2 = dtop.GetSqlDataset(Select_2);
            AllRankStu_1 = dtop.GetSqlDataset(Select_1);

        }
        public void InitAnalyse(int userid) //获取并解析一个学生的近十场考试
        {
            

            StuSCdts(userid);//先初始化该学生的所有参与的考试的组
            //foreach(DataRow row in AllRankStu.Tables) //如此这般 切割出一个近十场考试的dataset
            //{
            //    DataRow dr = RecentRankStu.Tables[0].NewRow();
            //    dr.ItemArray = row.ItemArray;
            //    RecentRankStu.Tables[0].Rows.Add(dr);
            //}
            //假如有超过十场考试才切，如果没有，则直接展示即可
            if (AllRankStu_3.Tables[0].Rows.Count <= 10)
            {
                RecentRankStu_3 = AllRankStu_3;
            }
            else //假如有超过十场的考试
            {
                RecentRankStu_3 = AllRankStu_3.Clone(); //复制结构，否则识别不到表很恶心
                int Length = AllRankStu_3.Tables[0].Rows.Count; //该表长度
                for (int i = 9; i >= 0; i--)//进行切片
                {
                    DataRow dr = RecentRankStu_3.Tables[0].NewRow();
                    DataRow row = AllRankStu_3.Tables[0].Rows[Length - i-1];
                    dr.ItemArray = row.ItemArray;
                    RecentRankStu_3.Tables[0].Rows.Add(dr);
                }
            }

                if (AllRankStu_2.Tables[0].Rows.Count <= 10)
                {
                    RecentRankStu_2 = AllRankStu_2;
                }
                else //假如有超过十场的考试
                {
                    RecentRankStu_2 = AllRankStu_2.Clone(); //复制结构，否则识别不到表很恶心
                    int Length = AllRankStu_2.Tables[0].Rows.Count; //该表长度
                    for (int i = 9; i >= 0; i--)//进行切片
                    {
                        DataRow dr = RecentRankStu_2.Tables[0].NewRow();
                        DataRow row = AllRankStu_2.Tables[0].Rows[Length - i];
                        dr.ItemArray = row.ItemArray;
                        RecentRankStu_2.Tables[0].Rows.Add(dr);
                    }

                    if (AllRankStu_1.Tables[0].Rows.Count <= 10)
                    {
                        RecentRankStu_1 = AllRankStu_1;
                    }

                }

            if (AllRankStu_1.Tables[0].Rows.Count <= 10)
            {
                RecentRankStu_1 = AllRankStu_1;
            }
            else //假如有超过十场的考试
            {
                RecentRankStu_1 = AllRankStu_1.Clone(); //复制结构，否则识别不到表很恶心
                int Length = AllRankStu_1.Tables[0].Rows.Count; //该表长度
                for (int i = 9; i >= 0; i--)//进行切片
                {
                    DataRow dr = RecentRankStu_1.Tables[0].NewRow();
                    DataRow row = AllRankStu_1.Tables[0].Rows[Length - i-1];
                    dr.ItemArray = row.ItemArray;
                    RecentRankStu_1.Tables[0].Rows.Add(dr);
                }



            }

            //return RecentRankStu_3;

            AnalyseRecentSC();//完成上述所有之后 解析最近十场考试的结果
            ReturnLinear(); //除此之外还得分析一下K值
            WeakAnalyse(); //弱点分析
            ReturnVar(); //方差计算

        }

        public void AnalyseRecentSC()//解析最近十场考试的结果,调用前请调用StuRecentlySCdts()
        {
             //先初始化所有数据
            for(int i = 0; i < 10; i++) //给三个数组的所有数值附上-1
            {
                RecentSC_1[i] = -1;
                RecentSC_2[i] = -1;
                RecentSC_3[i] = -1;
            }

            //初始化完成后，给几个的分数组注入

            for(int i = 0; i < RecentRankStu_1.Tables[0].Rows.Count; i++)
            {
                RecentSC_1[i] = PublicClass.getInt(RecentRankStu_1, i, 3);
            }

            for (int i = 0; i < RecentRankStu_2.Tables[0].Rows.Count; i++)
            {
                RecentSC_2[i] = PublicClass.getInt(RecentRankStu_2, i, 3);
            }

            for (int i = 0; i < RecentRankStu_3.Tables[0].Rows.Count; i++)
            {
                RecentSC_3[i] = PublicClass.getInt(RecentRankStu_3, i, 3);
            }




        }

        public void ReturnVar()//计算方差
        {
            Var_1 = Variance(RecentSC_1);
            Var_2 = Variance(RecentSC_2);
            Var_3 = Variance(RecentSC_3);
        }

        
        public void ReturnLinear() //通过此条返回得到对应的斜率
        {
            List<Point> _PList1 = new List<Point>();
            List<Point> _PList2 = new List<Point>();
            List<Point> _PList3 = new List<Point>();
            int index = 0; 
            foreach(int i in RecentSC_1)
            {
               if(RecentSC_1[index]!= -1 && !double.IsNaN(RecentSC_1[index])) //刨去所有带-1和带有NaN的项
                {
                    _PList1.Add(new Point(++index, i));
                }    
            }
            Line line = LinearRegressionSolve(_PList1);
            Linear_1 = line.K;

            index = 0;
            foreach (int i in RecentSC_2)
            {
                if (RecentSC_2[index] != -1) //刨去所有带-1的项
                {
                    _PList2.Add(new Point(++index, i));
                }

            }
            line = LinearRegressionSolve(_PList2);
            Linear_2 = line.K;

            index = 0;
            foreach (int i in RecentSC_3)
            {
                if (RecentSC_3[index] != -1) //刨去所有带-1的项
                {
                    _PList3.Add(new Point(++index, i));
                }
            }
            line = LinearRegressionSolve(_PList3);
            Linear_3 = line.K;

        }

        public double ReturnLinear(double[] Array) //得到Array返回得到的斜率
        {
            List<Point> _PList1 = new List<Point>();
            int index = 0;
           int[] RecentSC_inside = new int[10];
            foreach (int i in Array)
            {
                if (Array[index] != -1 && !double.IsNaN(Array[index])) //刨去所有带-1的项和其为NaN的项
                {
                    _PList1.Add(new Point(++index, i));
                }
            }
            Line line = LinearRegressionSolve(_PList1);
            Linear_1 = line.K;
            return Linear_1;
        }
        public void WeakAnalyse() // 通过对sc分析，得到该学生的弱点
        {
            int[] TargetCid = new int[23]; //用来锚定Sc数组中每个得分对应的Cid
            int[] TargetScID = new int[10]; //获得近十次考试中的scid

            

            AnswerCore Ainit = new AnswerCore();
            //先对RecentRankStu_1进行分析

            for (int i = 0; i < 10; i++)
            {
                TargetScID[i] = PublicClass.getInt(RecentRankStu_1, i, 0); //获得Scid
            }

            //此时已经获得了TargetScid数组，也就是近十场考试的scid我们都获得了，之后就对每个scid进行分析
            for (int i = 0; i < 10; i++)
            {
                if (TargetScID[i] != 0 && TargetScID[i] != -1)  //假如得到的scid 不为0或-1才分析，如果是0的话，则说明没有这么多数据供分析
                {
                    Ainit.InitSc(TargetScID[i]); //初始化Ainit的sc表,此时会返回一个特定的sc数组
                                                 //对于该数组，因为是小题训练，所以只需要分析前十六题，其中前16题每道题都是5分

                    TargetCid = Ainit.SCToCid(Ainit.ScId); //初始化一个cid数组，也就是这个sc表中每道题对应的cid
                    for (int index = 0; index < 16; index++)
                    {

                        //找到对应的targetweakness并向上加一个加权值
                        TargetWeakness[TargetCid[index]] += (5 - Ainit.SC[index]) * Per_1;
                    }


                }
            }


            //解析RecentRankStu_2
            for (int i = 0; i < 10; i++)
            {
                TargetScID[i] = PublicClass.getInt(RecentRankStu_2, i, 0); //获得Scid
            }

            //此时已经获得了TargetScid数组，也就是近十场考试的scid我们都获得了，之后就对每个scid进行分析
            for (int i = 0; i < 10; i++)
            {
                if (TargetScID[i] != 0 && TargetScID[i] != -1)  //假如得到的scid 不为0或-1才分析，如果是0的话，则说明没有这么多数据供分析
                {
                    Ainit.InitSc(TargetScID[i]); //初始化Ainit的sc表,此时会返回一个特定的sc数组
                                                 //对于该数组，因为是小题训练，所以只需要分析前十六题，其中前16题每道题都是5分

                    TargetCid = Ainit.SCToCid(Ainit.ScId); //初始化一个cid数组，也就是这个sc表中每道题对应的cid
                    //此时分析的不再是前1-16题，而是17-23题
                    for (int index = 16; index < 23; index++)
                    {

                        //找到对应的targetweakness并向上加一个加权值
                        TargetWeakness[TargetCid[index]] += (12 - Ainit.SC[index]) * Per_2;
                    }
                }
            }


            for (int i = 0; i < 10; i++)
            {
                TargetScID[i] = PublicClass.getInt(RecentRankStu_3, i, 0); //获得Scid
            }

            //此时已经获得了TargetScid数组，也就是近十场考试的scid我们都获得了，之后就对每个scid进行分析
            for (int i = 0; i < 10; i++)
            {
                if (TargetScID[i] != 0 && TargetScID[i] != -1)  //假如得到的scid 不为0或-1才分析，如果是0的话，则说明没有这么多数据供分析
                {
                    Ainit.InitSc(TargetScID[i]); //初始化Ainit的sc表,此时会返回一个特定的sc数组
                                                 //对于该数组，因为是小题训练，所以只需要分析前十六题，其中前16题每道题都是5分

                    TargetCid = Ainit.SCToCid(Ainit.ScId); //初始化一个cid数组，也就是这个sc表中每道题对应的cid
                    //分析0-23题
                    for (int index = 0; index < 16; index++)
                    {

                        //找到对应的targetweakness并向上加一个加权值
                        TargetWeakness[TargetCid[index]] += (5 - Ainit.SC[index]) * Per_3;
                    }
                    //对大题解析
                    for (int index = 16; index < 23; index++)
                    {

                        //找到对应的targetweakness并向上加一个加权值
                        TargetWeakness[TargetCid[index]] += (12 - Ainit.SC[index]) * Per_3;
                    }
                }
            }

        }


        //private int[] ClipSC(DataSet SCdata,int IndexX)//通过该方法，对RecentRankStu做切片，逐行地得到一个23的得分的数组
        //{
        //    int[] clips = new int[23]; //
        //    for(int i = 0; i < 23; i++)
        //    {
        //        clips[i] = int.Parse(SCdata.Tables[0].Rows[IndexX][i].ToString());
        //    }

        //    return clips;
        //}





        //线性规划部分，勿动：
        public static Line LinearRegressionSolve(List<Point> _plist)
        {
            double k = 0, b = 0;
            double sumX = 0, sumY = 0;
            double avgX = 0, avgY = 0;
            foreach (var v in _plist)
            {
                sumX += v.X;
                sumY += v.Y;
            }
            avgX = sumX / (_plist.Count + 0.0);
            avgY = sumY / (_plist.Count + 0.0);

            //sumA=(x-avgX)(y-avgY)的和 sumB=(x-avgX)平方
            double sumA = 0, sumB = 0;
            foreach (var v in _plist)
            {
                sumA += (v.X - avgX) * (v.Y - avgY);
                sumB += (v.X - avgX) * (v.X - avgX);
            }
            k = sumA / (sumB + 0.0);
            b = avgY - k * avgX;

            Line line = new Line(k, b);
            return line;
        }

        public static Line LinearRegressionSolve2(List<Point> _plist)
        {
            double k = 0, b = 0;
            double sumX = 0, sumY = 0;
            double sumXY = 0, sumXX = 0;
            foreach (var v in _plist)
            {
                sumX += v.X;
                sumY += v.Y;
                sumXY += v.X * v.Y;
                sumXX += v.X * v.X;
            }

            k = (sumX * sumY / (_plist.Count + 0.0) - sumXY) / (sumX * sumX / (_plist.Count + 0.0) - sumXX);
            b = (sumY - k * sumX) / (_plist.Count + 0.00);

            Line line = new Line(k, b);
            return line;
        }

        public static Line LinearRegressionSolve3(List<Point> _plist)
        {
            double k = 0, b = 0;
            double sumX = 0, sumY = 0;
            double avgX = 0, avgY = 0;
            double sumXY = 0, sumXX = 0;
            foreach (var v in _plist)
            {
                sumX += v.X;
                sumY += v.Y;
                sumXY += v.X * v.Y;
                sumXX += v.X * v.X;
            }
            avgX = sumX / (_plist.Count + 0.0);
            avgY = sumY / (_plist.Count + 0.0);

            k = (sumXY - avgY * sumX) / (sumXX - avgX * sumX);
            b = avgY - k * avgX;

            Line line = new Line(k, b);
            return line;
        }

        //下列方法计算方差
        public double Var;
        public double avrg;
        public double Variance(int[] a) //计算方差，返回，因为是int数组，不用担心NaN的问题
        {
            double var = 0, n;
            avrg = a.Average();
            n = a.Count<int>();
            foreach (int x in a)
            {
                var += (x - avrg) * (x - avrg);
            }
            Var = var / n;
            return Var;
        }

        public double Variance(double[] a)
        {
            try
            {
                double var = 0, n;
                double multi = 0;
                int index = a.Length;
                for(int i = 0; i < a.Length; i++)
                {
                    if (double.IsNaN(a[i]))
                    {
                        index = i;
                        break; //跳出循环，带走index
                    }
                    multi += a[i];

                }
                avrg = multi / index+1;


                n = a.Count<double>();

                for(int i = 0; i < a.Length; i++)
                {
                    if (double.IsNaN(a[i]))
                    {
                    
                        continue;
                    }
                    var += (a[i] - avrg) * (a[i] - avrg);
                }
                Var = var / n;
                return Var;
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return double.NaN;
            }
            
        }
    }
}

    public class Line
    {
        public double K { get; set; }
        public double B { get; set; }

        public Line(double k, double b)
        {
            K = k;
            B = b;
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }




    

