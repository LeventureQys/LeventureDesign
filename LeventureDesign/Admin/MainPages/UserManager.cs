using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeventureDesign.Admin.UsermanagerFrm;

namespace LeventureDesign
{
    public partial class UserManager : Form
    {
        int nuid;
        string nname;
        string naccount;
        string npassword;
        int nauthority;
        string nsex;
        string nemail;
        int nclassid;
        int nisavaliable;
        AdminPage user = new AdminPage();
        DataSet users = new DataSet();

        UserManagerMent inituser = new UserManagerMent();
        public UserManager(AdminPage admin)
        {
            InitializeComponent();
            this.user = admin;
            
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            users = inituser.userdataset_all();//获得所有用户的userdata

            dataGridView1 = inituser.DataView_InitUsers(dataGridView1, users);

        }
        //刷新按钮，当按下刷新键时刷新当前gridview
        private void btn_Fresh_Click(object sender, EventArgs e)
        {
            users = inituser.userdataset_all();//获得所有用户的userdata

            //将dataset的内容输入dataGridView1
            dataGridView1.DataSource = users;
            dataGridView1.DataMember = "lwx";
            //dataGridView1.Columns[0].HeaderText = "工号/学号";
            timer1.Enabled = true;
            btn_access.Visible = false;

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            //切换到
            UserManagerMent userinit = new UserManagerMent();
            DataSet userset = new DataSet();

            userset = userinit.userdataset_searchUnAvaliable();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = userset;
            dataGridView1.DataMember = "lwx";

            btn_access.Visible = true; //点击查看申请后，申请通过按钮出现。
            //在点击了之后需要将这个计时器关闭一下，不然会没法显示
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //btn_Fresh_Click(null, null);
        }

        private void btn_access_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("请先选择对应用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int index = dataGridView1.CurrentRow.Index;    //取得选中行的索引  
                    nuid = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()); //定义nuid
                    nname = dataGridView1.Rows[index].Cells[1].Value.ToString(); //定义name
                    naccount = dataGridView1.Rows[index].Cells[2].Value.ToString().Trim(); //定义account
                    npassword = dataGridView1.Rows[index].Cells[3].Value.ToString().Trim(); //定义password
                    nauthority = int.Parse(dataGridView1.Rows[index].Cells[4].Value.ToString().Trim()); //定义authority
                    nsex = dataGridView1.Rows[index].Cells[5].Value.ToString().Trim(); //定义nsex
                    nemail = dataGridView1.Rows[index].Cells[6].Value.ToString().Trim(); //定义nemail
                    nclassid = int.Parse(dataGridView1.Rows[index].Cells[7].Value.ToString().Trim()); //定义classid
                    nisavaliable = 1; //将是否可用设定为1
                    UserManagerMent userinit = new UserManagerMent();
                    userinit.user_change(nuid, naccount, npassword, nauthority, nsex, nemail, nclassid, nname, nisavaliable);
                }
                //刷新
                btn_Check_Click(null, null);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void btn_userInsert_Click(object sender, EventArgs e)
        {
            UserAdd add = new UserAdd();
            add.Show();
        }

        private void btn_userDelete_Click(object sender, EventArgs e)
        {
            UserDelete dele = new UserDelete();
            dele.Show();
        }

        private void btn_userSearch_Click(object sender, EventArgs e)
        {
            UserSearch search = new UserSearch();
            search.Show();
        }

        

        private void btn_ClassManager_Click(object sender, EventArgs e)
        {
            ClassManagePage classes = new ClassManagePage();
            classes.Show();

        }

        private void btn_userChange_Click(object sender, EventArgs e)
        {
            UserSearch search = new UserSearch();
            search.Show();
        }
    }
}
