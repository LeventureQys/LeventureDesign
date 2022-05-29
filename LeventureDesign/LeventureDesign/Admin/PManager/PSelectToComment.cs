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
    public partial class PSelectToComment : Form
    {

        UserManagerMent userinit = new UserManagerMent();
        AnswerCore ansinit = new AnswerCore();
        PaperCore paperInit = new PaperCore();
       


        DataSet dts_class = new DataSet();
        DataSet dts_paper = new DataSet();
        DataSet dts_stu = new DataSet();

        int currentClass = -1;
        int currentPaper = -1;
        int currentStu = -1;

        int type = 0; //0是进入查看试卷模式，1则是批改模式

        int DtType = 0; // 0是选择班级，1是选择试卷，2是选择个人
        public PSelectToComment(int t)
        {
            type = t;
            InitializeComponent();
        }

        private void PComment_Load(object sender, EventArgs e)
        {
            //if(type == 1)//如果是学生查看试卷
            //{

            //}
            if (PublicClass.isTeacher == true)
            {
                userinit.initUser(PublicClass.PresentUser); //初始化当前用户
                dts_class = userinit.classviewdataset_search(userinit.UserName); //初始化教师带领班级
                DtType = 0;
                FreshMent_Class();
            }
            else if(PublicClass.isAdmin == true)
            {
                userinit.initUser(PublicClass.PresentUser);
                dts_class = userinit.classView_seachall(); //如果是管理员，则直接查询所有的班级即可
                DtType = 0;
                this.Text = "查看答卷";
                FreshMent_Class();
            }else if(PublicClass.isStu == true)
            {
                userinit.initUser(PublicClass.PresentUser); //初始化当前用户
                dts_class = userinit.classviewdataset_search(userinit.UserClassid);
                DtType = 0;
                this.Text = "查看答卷";
                FreshMent_Class();
            }
            
           
        }
        private void reproduceDataset()
        {
            if (DtType == 0)//选择班级阶段，进行试卷展示
            {
                dts_paper.Tables[0].Columns.Remove("Number");

                dts_paper.Tables[0].Columns.Add("papertype", typeof(String));//插入一个int类型的列
                dts_paper.Tables[0].Columns["papertype"].SetOrdinal(1); //插入其到第二列
                for (int i = 0; i < dts_paper.Tables[0].Rows.Count; i++)
                {
                    //PShow.Tables[0].Rows[i].
                    if (PublicClass.getInt(dts_paper, i, 2) == 1)
                    {
                        dts_paper.Tables[0].Rows[i][1] = "小题训练";
                    }
                    else if (PublicClass.getInt(dts_paper, i, 2) == 2)
                    {
                        dts_paper.Tables[0].Rows[i][1] = "大题训练";
                    }
                    else if (PublicClass.getInt(dts_paper, i, 2) == 3)
                    {
                        dts_paper.Tables[0].Rows[i][1] = "综合训练";
                    }
                }
                //修改完毕之后将第2列删除
                dts_paper.Tables[0].Columns.Remove("pType");


                //对班级名称进行处理
                dts_paper.Tables[0].Columns.Add("classname", typeof(String));//插入一个int类型的列
                dts_paper.Tables[0].Columns["classname"].SetOrdinal(3); //插入其到第三列
                for (int i = 0; i < dts_paper.Tables[0].Rows.Count; i++)
                {
                    dts_paper.Tables[0].Rows[i][3] = userinit.returnName_ByClassid(PublicClass.getInt(dts_paper, i, 2));
                }
                dts_paper.Tables[0].Columns.Remove("classid");
            }
            else if (DtType == 1)//选择试卷阶段 ，修改学生dataset
            {
                dts_stu.Tables[0].Columns.Remove("account");
                dts_stu.Tables[0].Columns.Remove("password");
                dts_stu.Tables[0].Columns.Remove("authority");
                //dts_stu.Tables[0].Columns.Remove("sex");
                dts_stu.Tables[0].Columns.Remove("email");
                dts_stu.Tables[0].Columns.Remove("IsAvaliable");

                dts_stu.Tables[0].Columns.Add("classname", typeof(String));//插入一个int类型的列
                dts_stu.Tables[0].Columns["classname"].SetOrdinal(3); //插入其到第三列
                for (int i = 0; i < dts_stu.Tables[0].Rows.Count; i++)
                {
                    dts_stu.Tables[0].Rows[i][3] = userinit.returnName_ByClassid(PublicClass.getInt(dts_stu, i, 5));
                }
                dts_stu.Tables[0].Columns.Remove("classid");
            }
            else if (DtType == 2) //选择学生阶段
            {
                dts_stu.Tables[0].Columns.Remove("account");
                dts_stu.Tables[0].Columns.Remove("password");
                dts_stu.Tables[0].Columns.Remove("authority");
                //dts_stu.Tables[0].Columns.Remove("sex");
                dts_stu.Tables[0].Columns.Remove("email");
                dts_stu.Tables[0].Columns.Remove("IsAvaliable");

                dts_stu.Tables[0].Columns.Add("classname", typeof(String));//插入一个int类型的列
                dts_stu.Tables[0].Columns["classname"].SetOrdinal(3); //插入其到第三列
                for (int i = 0; i < dts_stu.Tables[0].Rows.Count; i++)
                {
                    dts_stu.Tables[0].Rows[i][3] = userinit.returnName_ByClassid(PublicClass.getInt(dts_stu, i, 5));
                }
                dts_stu.Tables[0].Columns.Remove("classid");
            }
            }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //双击班级后找试卷
        {
            if (DtType == 0) //选择到当前年级
            {
                
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
                {
                    PublicClass.showMessage("当前表为空，请重新回到班级页面选择", "选择试卷");
                    FreshMent_Class();

                    return;
                }
                currentClass = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()); //获得当前行第一个参数，也就是班级id

                dts_paper = paperInit.Search_Index(currentClass);
                FreshMent_Paper();//展示試卷頁面
                DtType = 1;//结束的时候再改DtType
                titleInit();



            }
            else if(DtType == 1) //选择到对应试卷，包括该班级的试卷和公共试卷
            {
                
                //此时已经有了 当前班级 和当前 试卷
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() =="")
                {
                    PublicClass.showMessage("当前表为空，请重新回到班级页面选择", "选择试卷");
                    FreshMent_Class();
                    return;
                }
                currentPaper = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()); //获得选择试卷id
                dts_stu = userinit.StuDataSet_Classid(currentClass); //获得当前学生类，并将其输入到stu中去
                DtType = 2;
                FreshMent_Stu();
                DtType = 2;
                //titleInit();

            }
            else if(DtType == 2)//找对应学生
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")

                {
                    PublicClass.showMessage("当前表为空，请重新回到班级页面选择", "选择试卷");
                    FreshMent_Class();
                    return;
                }
                currentStu = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()); //当前的学生id是
                if (currentStu == -1 || currentPaper == -1 || currentClass == -1)
                {
                    PublicClass.showMessage("查询的信息有误，或者当前学生并未参与考试", "批改试卷");
                    return;
                }
                if(type == 0)
                {

                    PComment PcInit = new PComment(currentClass, currentPaper, currentStu, PublicClass.ViewMode);

                    if (ansinit.A_isExist(currentPaper, currentStu))
                    {
                        PcInit.Show();
                    }
                }else if(type == 1) //假如是StuSCAnalyse调用该模块，则
                {

                }

               


            }

             

        }

        private void FreshMent_Class() //刷新datagridview
        {
            //titleInit();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = dts_class;//展示dts
            dataGridView1.DataMember = "lwx";
            lab_currentType.Text = "请选择班级";
            DtType = 0;
            titleInit();
        }

        private void FreshMent_Stu()
        {
            //titleInit();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            AddColumnIsChecked();
            reproduceDataset();
            dataGridView1.DataSource = dts_stu;//展示dts
            dataGridView1.DataMember = "lwx";
            lab_currentType.Text = "请选择学生";
            titleInit();
        }

        private void FreshMent_Paper()
        {
            //titleInit();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            reproduceDataset();
            dataGridView1.DataSource = dts_paper;//展示dts

            dataGridView1.DataMember = "lwx";
            lab_currentType.Text = "请选择试卷";
            titleInit();
        }

        private void titleInit()
        {
            if (DtType == 0) //如果当前找班级
            {
                dataGridView1.Columns[0].HeaderCell.Value = "班级ID";
                dataGridView1.Columns[1].HeaderCell.Value = "教师姓名";
                //dataGridView1.Columns[2].HeaderCell.Value = "题目难度";
                dataGridView1.Columns[2].HeaderCell.Value = "年级";
                dataGridView1.Columns[3].HeaderCell.Value = "班号";
                //dataGridView1.Columns[4].HeaderCell.Value = "班级总人数";
                FreshLab();
            }else if(DtType == 1) //如果当前找试卷 
            {
                //删除月份列，即第4列
                dataGridView1.Columns.Remove("month");
                dataGridView1.Columns.Remove("level");
                dataGridView1.Columns[0].HeaderCell.Value = "试卷ID";
                dataGridView1.Columns[1].HeaderCell.Value = "试卷类型";
                //dataGridView1.Columns[2].HeaderCell.Value = "题目难度";
                dataGridView1.Columns[2].HeaderCell.Value = "班级名称";
                //dataGridView1.Columns[3].HeaderCell.Value = "考试月份";
                //dataGridView1.Columns[3].HeaderCell.Value = "考试年级";
                dataGridView1.Columns[3].HeaderCell.Value = "试卷名称";
                //dataGridView1.Columns[6].HeaderCell.Value = "试卷名称";
                FreshLab();

            }
            else if(DtType == 2) //如果当前找人？
            {
                dataGridView1.Columns[0].HeaderCell.Value = "用户ID";
                dataGridView1.Columns[1].HeaderCell.Value = "是否批改";
                dataGridView1.Columns[2].HeaderCell.Value = "用户姓名";
                dataGridView1.Columns[3].HeaderCell.Value = "用户班级";
                dataGridView1.Columns[4].HeaderCell.Value = "用户性别";

                FreshLab();
            }
        }

       

        private void FreshLab()
        {
            if(DtType == 0)
            {
                lab_currentType.Text = String.Format("请选择班级");
            }else if(DtType == 1)
            {
                lab_currentType.Text = String.Format("请选择试卷");
            }
            else if(DtType == 2)
            {
                lab_currentType.Text = String.Format("请选择学生");
            }
        }

        private void btn_Fresh_Click(object sender, EventArgs e)
        {
            FreshMent_Class();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AddColumnIsChecked()//向dts中插入 当前试卷是否以批改的列
        {
            //Ainit.AnswerInit
            int User = 0;
            dts_stu.Tables[0].Columns.Add("是否批改", typeof(String));//插入一个int类型的列
            dts_stu.Tables[0].Columns["是否批改"].SetOrdinal(1); //插入其到第二列

            for (int i = 0; i < dts_stu.Tables[0].Rows.Count; i++)//遍历整个dataset
            {
                User = int.Parse(dts_stu.Tables[0].Rows[i][0].ToString());
                //Uinit.initUser(int.Parse(RankFull.Tables[0].Rows[i][4].ToString())); //初始化一个uinit
                //PublicClass.showMessage("当前答案并不存在，请检查该用户是否完成试卷", "初始化答案");
                //debug("当前答案初始化失败");
                String isChecked = "";
                if (!ansinit.AnswerInit(currentPaper, User))
                {
                    isChecked = "未参与";
                }
                //String isChecked = "";
                if(ansinit.isFullChecked == 1)
                {
                    isChecked = "已批改";
                }
                else
                {
                    isChecked = "未批改";
                }
                //dts_stu.Tables[0].Rows[i][2] = Uinit.UserName;
                dts_stu.Tables[0].Rows[i][1] = isChecked;
            }

        }
    }
}
