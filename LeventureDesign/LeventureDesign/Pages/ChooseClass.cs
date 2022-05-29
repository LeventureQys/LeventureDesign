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
    public partial class ChooseClass : Form
    {
        UserManagerMent userinit = new UserManagerMent();
        DataSet classes = new DataSet();
        //当Type=1时，被StuSCAnalyse调用 type =2 管理员调用
        int Type = 0; 
        int currentClass = 0; //当前用户
        PaperCore pinit = new PaperCore();
        public ChooseClass(int t)
        {
            Type = t;
            InitializeComponent();
        }

        private void ChooseUser_Load(object sender, EventArgs e)
        {
           
            if(Type==1)
            {
                userinit.initUser(PublicClass.PresentUserID);
                classes = userinit.Classvr_ByTeacherName(userinit.UserName);
            }
            else if(Type==2)
            {
                userinit.initUser(PublicClass.ChosenThing);
                classes = userinit.Classvr_ByTeacherName(userinit.UserName);
            }else if(Type == 3)//教师端查看排名
            {
                userinit.initUser(PublicClass.PresentUserID);
                classes = userinit.Classvr_ByTeacherName(userinit.UserName);
            }
            
            FreshMent();
        }

        private void FreshMent()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = classes;
            dataGridView1.DataMember = "lwx";
            InitTitle();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;    //取得选中行的索引

            currentClass = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()); //定义nuid

            if(Type == 1)
            {
                TeacherAnalyse teacher = new TeacherAnalyse(currentClass);
                teacher.Show();
            }else if(Type == 2)
            {
                TeacherAnalyse teacher = new TeacherAnalyse(currentClass);
                teacher.Show();
            }else if(Type == 3)
            {
                PublicClass.ChosenThing = currentClass;
                PaperSelect PS = new PaperSelect();
                PS.Show();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;    //取得选中行的索引
            if(index>=dataGridView1.Rows.Count-1)
            {
                return;
            }
            currentClass = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()); //定义nuid

            if (Type == 1)
            {
                TeacherAnalyse teacher = new TeacherAnalyse(currentClass);
                teacher.Show();
            }
            else if (Type == 2)
            {
                TeacherAnalyse teacher = new TeacherAnalyse(currentClass);
                teacher.Show();
            }
            else if (Type == 3)
            {
                PublicClass.ChosenThing = currentClass;
                PaperSelect PS = new PaperSelect();
                PS.Show();
            }
        }

        private void InitTitle()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "班级ID";
            dataGridView1.Columns[1].HeaderCell.Value = "教师姓名";
            dataGridView1.Columns[2].HeaderCell.Value = "年级";
            dataGridView1.Columns[3].HeaderCell.Value = "班号";
        }
    }
}
