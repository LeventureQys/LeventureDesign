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
    public partial class PaperManager : Form
    {
        PaperCore Pinit = new PaperCore();
        DataSet PShow = new DataSet();
        UserManagerMent userinit = new UserManagerMent();
        AnswerCore Ans = new AnswerCore();

        public PaperManager()
        {if (PublicClass.isAdmin == true)
            {
                InitializeComponent();
            }
            else //如果时学生或者教师进入，则
            {
                InitializeComponent();
                btn_Fresh.Visible = false;
                btn_Del.Visible = false;
                btn_Request.Visible = false;
            }
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            PAsk ask = new PAsk();
            ask.Show();
        }

        private void PaperManager_Load(object sender, EventArgs e)
        {
            btn_Fresh_Click(null, null);
        }
        //修饰展示的dataset
        private void reproduceDataset()
        {
            if (PShow != null)
            {
                PShow.Tables[0].Columns.Remove("Number");

                PShow.Tables[0].Columns.Add("papertype", typeof(String));//插入一个int类型的列
                PShow.Tables[0].Columns["papertype"].SetOrdinal(1); //插入其到第二列
                for (int i = 0; i < PShow.Tables[0].Rows.Count; i++)
                {
                    //PShow.Tables[0].Rows[i].
                    if (PublicClass.getInt(PShow, i, 2) == 1)
                    {
                        PShow.Tables[0].Rows[i][1] = "小题训练";
                    }
                    else if (PublicClass.getInt(PShow, i, 2) == 2)
                    {
                        PShow.Tables[0].Rows[i][1] = "大题训练";
                    }
                    else if (PublicClass.getInt(PShow, i, 2) == 3)
                    {
                        PShow.Tables[0].Rows[i][1] = "综合训练";
                    }
                }

                //修改完毕之后将第2列删除
                PShow.Tables[0].Columns.Remove("pType");


                //对班级名称进行处理
                PShow.Tables[0].Columns.Add("classname", typeof(String));//插入一个int类型的列
                PShow.Tables[0].Columns["classname"].SetOrdinal(3); //插入其到第三列
                for (int i = 0; i < PShow.Tables[0].Rows.Count; i++)
                {
                    PShow.Tables[0].Rows[i][3] = userinit.returnName_ByClassid(PublicClass.getInt(PShow, i, 2));
                }
                PShow.Tables[0].Columns.Remove("classid");
            }
            else
            {
                return;
            }
 
        }
        private void btn_Fresh_Click(object sender, EventArgs e)
        {
            if(true)
            {
                PShow = Pinit.Search_Index(); //此条展示的是vr_paper_index对象
                                              //将dataset的内容输入dataGridView1
                reproduceDataset();
                dataGridView1.DataSource = PShow;
                dataGridView1.DataMember = "lwx";
                InitTitle();
            }
            //else if(PublicClass.isTeacher == true)
            //{
            //    PShow = 
            //}
                
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // 点击某个数据后展开对应的试卷
        {
            if (PublicClass.isStu == false)
            {
                //双击后应该要能展示一张完整的试卷
                //试卷的展示应该要通过两个参数
                //一个是pType，确定该试卷应该去哪张表中获取数据
                //一个是paperid，从指定的view中找到对应的数据
                int currentIndex = -1;
                if (dataGridView1.DataSource == null)
                {
                    btn_Fresh_Click(null, null);
                }
                else
                {

                    currentIndex = dataGridView1.CurrentCell.RowIndex; // 获得当前行标
                    if(dataGridView1.CurrentRow.Cells[1].Value.ToString() == "小题训练")
                    {
                        Pinit.pType = 1;
                    }else if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "大题训练")
                    {
                        Pinit.pType = 2;
                    }else if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "综合训练")
                    {
                        Pinit.pType = 3;
                    }
                    Pinit.PaperId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());//获取当前行 第一列的数据，也就是paperid

                    //if()
                    //Pinit.Paper_GetVR(); //获得一张试卷的视图，其中试卷的种类已经在该方法中被定义了
                    //PLittleTran Little = new PLittleTran(Pinit.Paper_GetVR(),Pinit.pType);

                    //此时我们在Pinit中已经获得了PaperId了

                    Pinit.PaperInit(Pinit.PaperId); //此时我们初始化当前的这个Pinit对象，让它通过这个PaperId初始化成为一个完整的Pinit对象

                    PLittleTran PLittle = new PLittleTran(Pinit, 0); //通过Pinit初始化一个PLittle窗口

                    PLittle.Show(); //展示PLittle窗口

                }
            }
            else //PublicClass.isStu == true
            {
                //双击后应该要能展示一张完整的试卷
                //试卷的展示应该要通过两个参数
                //一个是pType，确定该试卷应该去哪张表中获取数据
                //一个是paperid，从指定的view中找到对应的数据
                int currentIndex = -1;
                if (dataGridView1.DataSource == null)
                {
                    btn_Fresh_Click(null, null);
                } //检查datagridview是否为空
                else
                {

                    currentIndex = dataGridView1.CurrentCell.RowIndex; // 获得当前行标
                    //Pinit.pType = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()); //获取当前行 第二列的数据，也就是pType
                    if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "综合训练") 
                    {
                        Pinit.pType = 3;
                    }
                    Pinit.PaperId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());//获取当前行 第一列的数据，也就是paperid

                    //if()
                    //Pinit.Paper_GetVR(); //获得一张试卷的视图，其中试卷的种类已经在该方法中被定义了
                    //PLittleTran Little = new PLittleTran(Pinit.Paper_GetVR(),Pinit.pType);

                    //此时我们在Pinit中已经获得了PaperId了

                    //此时还需要检查一次 当前用户是否已经做过本试卷了，如果做过了，就不应该让他在做一次，以免数据失真
                    if (Ans.SC_IsExist(PublicClass.PresentUserID, Pinit.PaperId))
                    {
                        PublicClass.showMessage("您已经提交试卷，请勿再度提交！", "考试通知");
                    }
                    else
                    {
                        Pinit.PaperInit(Pinit.PaperId); //此时我们初始化当前的这个Pinit对象，让它通过这个PaperId初始化成为一个完整的Pinit对象

                        PLittleTran PLittle = new PLittleTran(Pinit, 1); //通过Pinit初始化一个PLittle窗口

                        PLittle.Show(); //展示PLittle窗口}

                    }

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (PublicClass.DialogConfirm("是否要删除当前选定试卷?", "删除试卷"))
            {
                int currentPaperid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if(Pinit.DelPaper(currentPaperid)) //删除对应的paper
                {
                    PublicClass.showMessage("试卷删除成功！", "删除试卷");
                }

            }
        }

        private void InitTitle()
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.Columns.Remove("month");
                dataGridView1.Columns[0].HeaderCell.Value = "试卷ID";
                dataGridView1.Columns[1].HeaderCell.Value = "试卷类型";
                dataGridView1.Columns[2].HeaderCell.Value = "申请班级";
                dataGridView1.Columns[3].HeaderCell.Value = "申请年级";
                dataGridView1.Columns[4].HeaderCell.Value = "试卷名称";
            }
            else
            {
                return;
            }
        }
    }
}
