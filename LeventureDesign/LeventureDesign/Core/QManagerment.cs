using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeventureDesign
{
    public class QManagerment
    {
        public int Qno; //题目题号
        public String PicPath; //题目路径
        //public int difficulty; //题目难度。1-10

        public int Cid; //题目章节编号 

        public int Belong; //题目所属大区
//1-9 选择题容易题10-12 选择题较难题13-14 填空题容易题15-16 选择题较难题17 三角函数\平面几何
//18 立体几何19 统计大题20 圆锥曲线21 导数大题22 坐标系与参数方程23 不等式选讲

        public String Answer; //答案
        //bool isInit; // 此bool值用于判定该类是否已初始化，在析构的时候设定为false
        DataOperator dtop = new DataOperator();
        
        public QManagerment()//初始化构造函数，当仅当构造一个QMnager类的时候吊用
        {
            Qno = -1; //题目题号
            PicPath = ""; //题目路径
            //difficulty = -1; //题目难度。1-10
            Cid = -1; //题目章节编号 
            Belong = -1; //题目所属大区，1选择，2填空，3问答，4选作
            Answer = ""; //答案
            dtop = new DataOperator();
            //isInit = false;
        }
        ~QManagerment() // 析构函数,其实没啥用，析构了基本上也不在乎原来的数据会怎么样了
        {
        }
       public void Q_Init(int Qno) //初始化函数，输入一个题号初始化一个对象
        {
            try
            {
                DataSet dts = new DataSet();
                dts = Q_Search(Qno);
                Qno = PublicClass.getInt(dts, 0, 0);
                PicPath = PublicClass.getText(dts, 0, 1);
                Cid = PublicClass.getInt(dts, 0, 2);
                Belong = PublicClass.getInt(dts, 0, 3);
                Answer = PublicClass.getText(dts, 0,4);

            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                
            }
        }
        public bool Q_Insert() //将当前用户数据插入
        {
            try
            {
                if (true)
                {
                    String str = String.Format("insert into tb_questiondata(Qpic_data,Cid,Qbelong,Answer) values('{0}','{1}','{2}','{3}')", PicPath,  Cid, Belong, Answer); // 将一个当前插入类的信息插入
                    str = str.ToString().Replace("\\", "\\\\");
                    int num = dtop.ExecSQLResult(str); // 执行插入活动
                    if (num != 0)
                    {
                        PublicClass.showMessage("题目插入成功", "插入提示");
                        return true;
                    }
                    else
                    {
                        PublicClass.showMessage("题目插入失败，请检查输入数据 或 联系管理员", "插入提示");
                        return false;
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "插入提示");
                return false;
            }
        }
            
        public DataSet Q_Search(int Questno) //查询的话，需要输入一个题号来查询，返回一个DataSet类型
        {
            try
            {
                string SearchQuest = "select * from tb_questiondata where Qno=" + Questno;

                DataSet st = new DataSet();

                st = dtop.GetSqlDataset(SearchQuest);

                return st;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return null;
            }
        }   
        
        public DataSet Q_SearchWithChapter(int ChapterID) //通过章节查询题目，查询对应章节的所有题目
        {
            try
            {
                string SearchQuest = "select * from tb_questiondata where Cid=" +ChapterID; //查询所有某个章节的题目

                DataSet st = new DataSet();

                st = dtop.GetSqlDataset(SearchQuest);

                return st;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return null;
            }
        }

        public DataSet Q_SearchWithPath(String Path) //通过图片路径查询试题，到时候图片查重要用
        {
            try
            {
                Path = Path.ToString().Replace("\\","\\\\");
                string SearchQuest = "select * from tb_questiondata where Qpic_data='" + Path+"'"; //查询所有某个章节的题目

                DataSet st = new DataSet();

                st = dtop.GetSqlDataset(SearchQuest);

                return st;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return null;
            }
        }

        public DataSet Q_SearchWithBelong(int Belong)
        {
            try
            {
                string SearchQuest = "select * from tb_questiondata where Qbelong=" + Belong; //查询所有某个章节的题目

                DataSet st = new DataSet();

                st = dtop.GetSqlDataset(SearchQuest);

                return st;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return null;
            }
        }

        public DataSet Q_SearchAll()
        {
            try
            {
                string SearchUser = "select * from tb_questiondata";
                DataSet st = new DataSet();
                st = dtop.GetSqlDataset(SearchUser);

                return st;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return null;
            }
        } //查找所有试题

        //public DataSet Q_SearchTargetDiff(int TargetDiff) // 通过目标难度筛选试题
        //{
        //    //搜索题目难度为目标难度正负2难度为准
        //    int TargetLow = TargetDiff - 2;
        //    int TargetHigh = TargetDiff + 2;
        //    String Sql = String.Format("Select * from tb_questiondata where qdifficulty>{0} and qdifficulty<{1}", TargetLow, TargetHigh);//获取一个范围内的所有试题


        //    DataSet st = new DataSet();

        //    st = dtop.GetSqlDataset(Sql);

        //    return st;
        //}
        
        public bool Q_isExist(String Path) //通过一个路径查重
        {
            try
            {
                DataSet test = Q_SearchWithPath(Path);

                if (test.Tables.Count == 1 && test.Tables[0].Rows.Count == 0) // 如果想要判别表内没有数据，应该是ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return false ;
            }
        }
        
        public bool Q_isExist(int Qno)
        {
            try
            {
                DataSet test = Q_Search(Qno);

                if (test.Tables.Count == 1 && test.Tables[0].Rows.Count == 0) // 如果想要判别表内没有数据，应该是ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return false;
            }
        }
        public bool Q_Delete(int Qno)
        {
            try
            {
                string DeleteQuest = "Delete from tb_questiondata where Qno='" + Qno + "'";
                int num = dtop.ExecSQLResult(DeleteQuest); //运行删除uid的命令
                if (num == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return false;
            }

        }

        public DataGridView Q_TitleInit(DataGridView dataGridView1)
        {
            dataGridView1.Columns[0].HeaderCell.Value = "题号";
            dataGridView1.Columns[1].HeaderCell.Value = "题目图片路径";
            //dataGridView1.Columns[2].HeaderCell.Value = "题目难度";
            dataGridView1.Columns[2].HeaderCell.Value = "题目所属章节";
            dataGridView1.Columns[3].HeaderCell.Value = "题目类型";
            dataGridView1.Columns[4].HeaderCell.Value = "题目答案";

            return dataGridView1;
        }

        public void Q_CidTrans(int Index)
        {
            Cid = Index;
        }

        public void Q_BelongTrans(int index)
        {
            //if (String.Compare(BelongTo, "选择题") == 0)
            //{
            //    Belong = 1;
            //}
            //else if (String.Compare(BelongTo, "填空题") == 0)
            //{
            //    Belong = 2;
            //}
            //else if (String.Compare(BelongTo, "问答题") == 0)
            //{
            //    Belong = 3;
            //}
            //else if (String.Compare(BelongTo, "选做题") == 0)
            //{
            //    Belong = 4;
            //}
            //else
            //{
            //    Belong = -1;
            //}
            //return;

            //0 : 1-9选择题容易题 1 : 10-12 选择题较难题 2 : 13-14 填空题容易题  3: 15-16 选择题较难题4: 17 三角函数\平面几何
            //5: 18 立体几何6: 19 统计大题7: 20 圆锥曲线8: 21 导数大题9: 22 坐标系与参数方程10: 23 不等式选讲

            Belong = index; //直接指定了算了，懒得比对了
        }

        public bool CheckPathAvaliable(String Path)
        {
            if(Path == "")//如果路径为空
            {
                PublicClass.showMessage("路径为空，请检查路径", "检查图片");
                return false;
            }
            else
            {
                if (Q_isExist(Path))//假如路径存在
                {
                    return true;
                }
                else//假如路径不存在
                {
                    PublicClass.showMessage("当前图片不存在，请检查图片路径", "检查图片");
                    return false;
                }
            }
        }

        public bool CheckBelongAvaliable(int Belong)
        {
            if(Belong == -1)
            {
                PublicClass.showMessage("请输入正确的题目类型", "类型错误");
                return false;
            }
            return true;
        }

        public bool Q_DeleteFromQno(int Qno)
        {
            DialogResult mesSelection = MessageBox.Show("是否确认要删除试题？", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (mesSelection == DialogResult.OK) //判断你有没有点ok
            {
                string DeleteQuest = "delete from tb_questiondata where Qno=" + Qno;
                int num = dtop.ExecSQLResult(DeleteQuest); //运行删除uid的命令
                if (num == 1)
                {
                    MessageBox.Show("试题删除成功！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("用户删除失败，可能不存在该用户！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
                return false;
        }

        public bool Q_Change()
        {
            //String str = String.Format("update tb_")

            if (!Q_isExist(Qno)) //假如更新后的题号不存在
            {
                PublicClass.showMessage("请勿修改题号并重新尝试", "修改提示");
                return false;
            }
            else
            {
                String Changer = String.Format("update tb_questiondata set Qpic_data='{0}',Cid='{1}',Qbelong='{2}',Answer='{3}' where Qno={4}", PicPath,  Cid, Belong, Answer,Qno);
                Changer = Changer.Replace("\\", "\\\\");
                int num = dtop.ExecSQLResult(Changer); //运行修改命令
                if (num == 1)
                {
                    MessageBox.Show("试题修改成功！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("试题修改失败，请检查输入信息！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
        }

       public int GetRandomQuest(int Belong)//此方法从数据库中随机获得一道由Belong决定的题，并返回特定的题目id
        {

            DataSet All = Q_SearchWithBelong(Belong); //获得所有该类型的题目

            Random ran = new Random(); //一个随机数类
            int random = ran.Next(All.Tables[0].Rows.Count); //从0-count挑选一个数字
            
                random = ran.Next(All.Tables[0].Rows.Count);//random不能为0，如果为0需要重判
            

            int Qno = int.Parse(All.Tables[0].Rows[random][0].ToString());
            return Qno;
            

            

        }
         
       public String GetFile(int Qno) //通过一个 Qno返回一个题目图片路径
        {
            DataSet dts = new DataSet();
            dts = Q_Search(Qno);
            String Filename = PublicClass.getText(dts, 0, 1);
            //Filename = Filename.Replace("\\", "\\\\"); //此处需要做一个转职，否则可能反斜杠的转置了就搜索不到对应的题目了
            return Filename;
        }

      public String ReturnAns(int Qno)
        {
            DataSet dts = new DataSet();
            dts = Q_Search(Qno); //初始化这个dataset

            return PublicClass.getText(dts, 0, 4);
        }

        public int ReturnCid()
        {
            return Cid;
      }



        }
    }

