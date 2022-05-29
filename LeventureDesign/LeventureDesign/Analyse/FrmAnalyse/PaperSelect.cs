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
    public partial class PaperSelect : Form
    {
        PaperCore Pinit = new PaperCore();
        DataOperator dtop = new DataOperator(); //现实用
        DataSet dts = new DataSet();
        DataSet RankSet = new DataSet();
        AnalyseCore AnaInit = new AnalyseCore();

        int currentPaperid = -1;

        int AIndex = 0;
        public PaperSelect()
        {
            InitializeComponent();
            
        }

        private void PaperSelect_Load(object sender, EventArgs e)
        {
            button1_Click(null, null); // 点击试卷刷新按钮
            AIndex = 0;
            //dts = Pinit.Search_Index(); //获得vr_paperdata表中的所有数据
            //FreshMent();//刷新当前页面
        }

        private void PapertitleInit()
        {
            dataGridView1.Columns.Remove("month");
            dataGridView1.Columns.Remove("number");
            dataGridView1.Columns.Remove("classid");
            dataGridView1.Columns.Remove("level");
            dataGridView1.Columns[0].HeaderCell.Value = "试卷ID";
            dataGridView1.Columns[1].HeaderCell.Value = "试卷类型";
            //dataGridView1.Columns[2].HeaderCell.Value = "考试班级";
            //dataGridView1.Columns[3].HeaderCell.Value = "考试月份";
            //dataGridView1.Columns[3].HeaderCell.Value = "考试次序";
            //dataGridView1.Columns[3].HeaderCell.Value = "考试年级";
            dataGridView1.Columns[2].HeaderCell.Value = "考试名称";
        }
        private void FreshMent() //刷新当前页面
        {
            for (int i = 0; i < dts.Tables[0].Rows.Count; i++)
            {
                //PShow.Tables[0].Rows[i].
                if (PublicClass.getInt(dts, i, 2) == 1)
                {
                    dts.Tables[0].Rows[i][1] = "小题训练";
                }
                else if (PublicClass.getInt(dts, i, 2) == 2)
                {
                    dts.Tables[0].Rows[i][1] = "大题训练";
                }
                else if (PublicClass.getInt(dts, i, 2) == 3)
                {
                    dts.Tables[0].Rows[i][1] = "综合训练";
                }
            }
            //dts.Tables[0].Rows.Remove(3);
            //dts.Tables[0].Rows.Remove(4);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = dts;//展示dts
            dataGridView1.DataMember = "lwx";
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RankTitleInit()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "排名";
            dataGridView1.Columns.Remove("scid");
            PaperCore pinit = new PaperCore();
            pinit.PaperInit(currentPaperid);
            label1.Text = String.Format("{0}的排名如下", pinit.Pname);
            //dataGridView1.Columns[1].HeaderCell.Value = "得分表ID";
            dataGridView1.Columns[1].HeaderCell.Value = "考生姓名";
            dataGridView1.Columns[2].HeaderCell.Value = "试卷ID";
            dataGridView1.Columns[3].HeaderCell.Value = "用户ID";
            dataGridView1.Columns[4].HeaderCell.Value = "当前得分";
            dataGridView1.Columns[5].HeaderCell.Value = "理论总分";
            dataGridView1.Columns.Remove("selectionchecked");
            dataGridView1.Columns.Remove("fullchecked");
            //dataGridView1.Columns[7].HeaderCell.Value = "选择题批改情况";
            //dataGridView1.Columns[8].HeaderCell.Value = "试卷批改情况";

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            if(PublicClass.isAdmin == true)
            {
                if (AIndex == 0)
                {
                    int rowsLength = 0;
                    currentPaperid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()); //获得当前行的paperid
                    AnaInit.PaperID = currentPaperid;//初始化anainit paperid

                    dts = AnaInit.RankASC(currentPaperid);
                    //dts.Columns.Add
                    FreshMent();
                    RankTitleInit();
                    rowsLength = dataGridView1.Rows.Count; //获得长度
                                                           //dataGridView1.Columns.Add(new DataColumn("排名", typeof(int))); //插入一个int类型的列

                    AIndex = 1;
                }
            }else if(PublicClass.isTeacher == true)
            {
                if (AIndex == 0)
                {
                    int rowsLength = 0;
                    currentPaperid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()); //获得当前行的paperid
                    AnaInit.PaperID = currentPaperid;//初始化anainit paperid

                    dts = AnaInit.RankASC(currentPaperid);
                    //dts.Columns.Add
                    FreshMent();
                    RankTitleInit();
                    rowsLength = dataGridView1.Rows.Count; //获得长度
                                                           //dataGridView1.Columns.Add(new DataColumn("排名", typeof(int))); //插入一个int类型的列

                    AIndex = 1;
                }
            }
               
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PublicClass.isAdmin == true)
            {
                dts = Pinit.Search_Index(); //获得vr_paperdata表中的所有数据
                FreshMent();
                PapertitleInit();
                if (AIndex == 1) { AIndex = 0; }
            }else if(PublicClass.isTeacher == true)
            {
                dts = Pinit.Search_Index(PublicClass.ChosenThing); //获得vr_paperdata表中的所有数据
                FreshMent();
                PapertitleInit();
                if (AIndex == 1) { AIndex = 0; }
            }
           
           
        }

        private void ScInitTitle()
        {

        }
        private void FreshRank()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "答卷ID";
            dataGridView1.Columns[1].HeaderCell.Value = "试卷ID";
            dataGridView1.Columns[2].HeaderCell.Value = "用户ID";
        }
        private void reproduceStuDataSet()
        {
            UserManagerMent userinit = new UserManagerMent();
            dts.Tables[0].Columns.Remove("account");
            dts.Tables[0].Columns.Remove("password");
            dts.Tables[0].Columns.Remove("authority");
            //dts_stu.Tables[0].Columns.Remove("sex");
            dts.Tables[0].Columns.Remove("email");
            dts.Tables[0].Columns.Remove("IsAvaliable");

            dts.Tables[0].Columns.Add("classname", typeof(String));//插入一个int类型的列
            dts.Tables[0].Columns["classname"].SetOrdinal(3); //插入其到第三列
            for (int i = 0; i < dts.Tables[0].Rows.Count; i++)
            {
                dts.Tables[0].Rows[i][3] = userinit.returnName_ByClassid(PublicClass.getInt(dts, i, 5));
            }
            dts.Tables[0].Columns.Remove("classid");
        }
    }
}
