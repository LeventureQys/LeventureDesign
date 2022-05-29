using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeventureDesign.Admin.UsermanagerFrm
{
    public partial class UserAdd : Form
    {
        string nname;
        string naccount;
        string npassword;
        int nauthority;
        string nsex;
        string nemail;
        int nclassid;
        public UserAdd()
        {
            InitializeComponent();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[0].Value== null) //假如未输入数据
            {
                MessageBox.Show("输入姓名不能为空！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridView1.Rows[0].Cells[1].Value == null)
            {
                MessageBox.Show("输入账号不能为空！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridView1.Rows[0].Cells[2].Value == null)
            {
                MessageBox.Show("输入密码不能为空！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridView1.Rows[0].Cells[3].Value == null || !(string.Equals(dataGridView1.Rows[0].Cells[3].Value.ToString(), "教师") || string.Equals(dataGridView1.Rows[0].Cells[3].Value.ToString(), "学生") || string.Equals(dataGridView1.Rows[0].Cells[3].Value.ToString(), "管理员")))
            {
                MessageBox.Show("输入权限仅包括 “学生” “教师” 和 “管理员”！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridView1.Rows[0].Cells[4].Value == null)
            {
                MessageBox.Show("输入性别不能为空！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridView1.Rows[0].Cells[5].Value == null)
            {
                MessageBox.Show("输入电子邮箱不能为空！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridView1.Rows[0].Cells[6].Value == null)
            {
                MessageBox.Show("输入班级ID不能为空！", "插入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else//通过输入检测
            {
                
                if (dataGridView1.Rows[0].Cells[3].Value.ToString() == "学生") //通过输入字段确定权限等级
                    nauthority = 1;
                else if (dataGridView1.Rows[0].Cells[3].Value.ToString() == "教师")
                    nauthority = 2;
                else if (dataGridView1.Rows[0].Cells[3].Value.ToString() == "管理员")
                    nauthority = 3;

                nname = dataGridView1.Rows[0].Cells[0].Value.ToString(); //定义name
                naccount = dataGridView1.Rows[0].Cells[1].Value.ToString().Trim(); //定义account
                npassword = dataGridView1.Rows[0].Cells[2].Value.ToString().Trim(); //定义password
                nsex = dataGridView1.Rows[0].Cells[4].Value.ToString().Trim(); //定义nsex
                nemail = dataGridView1.Rows[0].Cells[5].Value.ToString().Trim(); //定义nemail
                nclassid = int.Parse(dataGridView1.Rows[0].Cells[6].Value.ToString().Trim()); //定义classid

                if (nauthority != 1) //如果不是学生，则将其classid设定为0
                    nclassid = 0;

                UserManagerMent userinit = new UserManagerMent();
                if (userinit.user_isExist(naccount)) //如果当前用户的账号已存在
                {
                    PublicClass.showMessage("插入提示", "当前账号已存在");
                }
                else // 假如不存在一个重复的账户
                {
                    userinit.user_insert(naccount, npassword, nauthority, nsex, nemail, nclassid, nname, 1); //直接通过管理员插入用户的话，直接激活权限就可以了
                    PublicClass.showMessage("插入成功！", "插入提示");
                    for(int i = 0; i < 7; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = null;
                    }
                }
                //userinit.user_insert(naccount, npassword, nauthority, nsex, nemail, nclassid, nname, 1); //直接通过管理员插入用户的话，直接激活权限就可以了

            }

        }
    }
}
