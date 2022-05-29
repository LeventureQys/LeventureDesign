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
    public partial class ChooseUser : Form
    {
        UserManagerMent userinit = new UserManagerMent();
        DataSet userset = new DataSet();
        //当Type=1时，学生成绩,type=2就是管理员-老师教学
        int Type = 0;
        int currentUser = 0; //当前用户
        public ChooseUser(int t) //
        {
            Type = t;
            InitializeComponent();
        }

        private void ChooseUser_Load(object sender, EventArgs e)
        {
            FreshMent();
        }

        private void FreshMent()
        {
            if(Type == 1)
            {
                userset = userinit.userdataset_all();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = userset;
                reproduceDataSet();
                dataGridView1.DataMember = "lwx";
                InitTitle();
            }else if(Type == 2)
            {
                userset = userinit.userdataset_getTeacher();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = userset;
                reproduceDataSet();
                dataGridView1.DataMember = "lwx";
                InitTitle();
            }
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;    //取得选中行的索引

            currentUser = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()); //定义nuid

            if (Type == 1)
            {
                StuSCAnalyse stu = new StuSCAnalyse(currentUser);
                stu.Show();
            }else if(Type == 2)
            {
                PublicClass.ChosenThing = currentUser; //将其绑定在ChosenThing上
                //TeacherAnalyse tea = new TeacherAnalyse()
                ChooseClass classed = new ChooseClass(2);
                classed.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;    //取得选中行的索引

            currentUser = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()); //定义nuid

            if (Type == 1)
            {
                StuSCAnalyse stu = new StuSCAnalyse(currentUser);
                stu.Show();
            }
            else if (Type == 2)
            {
                PublicClass.ChosenThing = currentUser; //将其绑定在ChosenThing上
                //TeacherAnalyse tea = new TeacherAnalyse()
                ChooseClass classed = new ChooseClass(2);
                classed.Show();
            }
        }
        private void InitTitle()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "用户ID";
            //dataGridView1.Columns[1].HeaderCell.Value = "是否批改";
            dataGridView1.Columns[1].HeaderCell.Value = "用户姓名";
            dataGridView1.Columns[2].HeaderCell.Value = "用户性别";
            dataGridView1.Columns[3].HeaderCell.Value = "用户班级";
        }

        private void reproduceDataSet()
        {
            userset.Tables[0].Columns.Remove("account");
            userset.Tables[0].Columns.Remove("password");
            userset.Tables[0].Columns.Remove("authority");
            //dts_stu.Tables[0].Columns.Remove("sex");
            userset.Tables[0].Columns.Remove("email");
            userset.Tables[0].Columns.Remove("IsAvaliable");

            userset.Tables[0].Columns.Add("classname", typeof(String));//插入一个int类型的列
            userset.Tables[0].Columns["classname"].SetOrdinal(3); //插入其到第三列
            for (int i = 0; i < userset.Tables[0].Rows.Count; i++)
            {
                if(PublicClass.getInt(userset, i, 4) == 0)
                {
                    //userset.Tables[0].Rows[i][3] = ""
                    userinit.initUser(PublicClass.getInt(userset, i, 0));
                    if(userinit.UserAuthority == 2)
                    {
                        userset.Tables[0].Rows[i][3] = "教师";
                    }else if(userinit.UserAuthority == 3)
                    {
                        userset.Tables[0].Rows[i][3] = "管理员";
                    }
                }
                else
                {
                    userset.Tables[0].Rows[i][3] = userinit.returnName_ByClassid(PublicClass.getInt(userset, i, 4));
                }
              
                
            }
            userset.Tables[0].Columns.Remove("classid");


        }
    }
}
