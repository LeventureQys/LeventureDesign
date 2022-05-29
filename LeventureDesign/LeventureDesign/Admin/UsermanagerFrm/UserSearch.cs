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
    public partial class UserSearch : Form
    {
        //int nuid;
        //string nname;
        //string naccount;
        //string npassword;
        //int nauthority;
        //string nsex;
        //string nemail;
        //int nclassid;
        //int nisavaliable;
        UserManagerMent user = new UserManagerMent();
        DataSet dt = new DataSet();
        public UserSearch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void tabt_UserID_CheckedChanged(object sender, EventArgs e)
        {
            txt_index.Text = "";   //当这个按钮变换状态是，将输入框清空
        }

        private void txt_index_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rabt_Account.Checked)//当我们以账号形式查询时
            {
                e.Handled = PublicClass.isAvaliable(e);
            }
            else if(rabt_Account.Checked)//当我们以账号形式查询时
            {
                e.Handled = PublicClass.IntOnly(e);
            }else if (rad_Classid.Checked)
            {
                e.Handled = PublicClass.IntOnly(e);
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (txt_index.Text == "" && !rad_UserAuthority.Checked)
            {
                PublicClass.showMessage("请输入查询内容！", "查询失败");
            }

            if (rabt_Account.Checked)
            {
                dt = user.userdataset_search(PublicClass.getText(txt_index));
            }
           else if (rad_Classid.Checked)
            {
                dt = user.Student_Includedby_Classid(PublicClass.getInt(txt_index));
            }else if (rad_UserAuthority.Checked)
            {
                int index = 0;
                if(comboBox1.SelectedIndex == 0)
                {
                    index = 1;
                }else if(comboBox1.SelectedIndex == 1)
                {
                    index = 2;
                }else if(comboBox1.SelectedIndex == 2)
                {
                    index = 3;
                }
                dt = user.SearchUser_ByAuthority(index);
            }else if (rabt_UserID.Checked)
            {
                dt = user.userdataset_search(PublicClass.getInt(txt_index));
            }

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "lwx";
            initTitle();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.DataSource == null)   //若当前窗口为空
            {
                MessageBox.Show("请先查询用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (PublicClass.DialogConfirm("是否提交修改？", "修改申请"))
                {
                    //获得当前选定行的索引
                    int currentRow = dataGridView1.CurrentRow.Index;

                    UserManagerMent userinit = new UserManagerMent();
                    userinit.UserID = PublicClass.getInt(dataGridView1, currentRow, 0);
                    userinit.UserName = PublicClass.getText(dataGridView1, currentRow, 1);
                    userinit.UserAccount = PublicClass.getText(dataGridView1, currentRow, 2);
                    userinit.UserPassword = PublicClass.getText(dataGridView1, currentRow, 3);
                    userinit.UserAuthority = PublicClass.getInt(dataGridView1, currentRow, 4);
                    userinit.UserSex = PublicClass.getText(dataGridView1, currentRow, 5);
                    userinit.UserEmail = PublicClass.getText(dataGridView1, currentRow, 6);
                    userinit.UserClassid = PublicClass.getInt(dataGridView1, currentRow, 7);
                    userinit.UserIsAvaliable = PublicClass.getInt(dataGridView1, currentRow, 8);
                    userinit.user_change(userinit.UserID, userinit.UserAccount, userinit.UserPassword, userinit.UserAuthority, userinit.UserSex, userinit.UserEmail, userinit.UserClassid, userinit.UserName, userinit.UserIsAvaliable);

                }
                else
                {
                    return;
                }

            }
        }

        private void UserSearch_Load(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int user = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            UserManagerMent userinit = new UserManagerMent();
            userinit.user_delete(user);
            
        }

        private void rad_UserAuthority_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_UserAuthority.Checked == true)
            {
                comboBox1.Visible = true;
                txt_index.Visible = false;
            }
            else
            {
                comboBox1.Visible = false;
                txt_index.Visible = true;
            }
        }
        private void initTitle()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "用户ID";
            dataGridView1.Columns[1].HeaderCell.Value = "用户姓名";
            dataGridView1.Columns[2].HeaderCell.Value = "用户账号";
            dataGridView1.Columns[3].HeaderCell.Value = "用户密码";
            dataGridView1.Columns[4].HeaderCell.Value = "用户权限";
            dataGridView1.Columns[5].HeaderCell.Value = "用户性别";
            dataGridView1.Columns[6].HeaderCell.Value = "用户邮箱";
            dataGridView1.Columns[7].HeaderCell.Value = "用户班级";
            dataGridView1.Columns[8].HeaderCell.Value = "是否激活";
        }
    }
}
