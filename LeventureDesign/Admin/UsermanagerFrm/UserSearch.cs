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
        int nuid;
        string nname;
        string naccount;
        string npassword;
        int nauthority;
        string nsex;
        string nemail;
        int nclassid;
        int nisavaliable;
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
            else //当我们以账号形式查询时
            {
                e.Handled = PublicClass.IntOnly(e);
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (PublicClass.isNullorEmpty(txt_index) && rabt_Account.Checked == true)
            {
                PublicClass.showMessage("请输入账号!", "查询提示");
            }
            else if(PublicClass.isNullorEmpty(txt_index) && rabt_Account.Checked == false)
            {
                PublicClass.showMessage("请输入对应工号！", "查询提示");
            }
            else if (!PublicClass.isNullorEmpty(txt_index) && rabt_Account.Checked)
            {
                dt = user.userdataset_search(PublicClass.getText(txt_index));
                user.DataView_InitUsers(dataGridView1, dt);
            }
            else
            {
                dt = user.userdataset_search(PublicClass.getInt(txt_index));
                user.DataView_InitUsers(dataGridView1, dt);
            }

           
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)   //若当前窗口为空
            {
                MessageBox.Show("请先查询用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nuid = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString()); //定义nuid
                nname = dataGridView1.Rows[0].Cells[1].Value.ToString(); //定义name
                naccount = dataGridView1.Rows[0].Cells[2].Value.ToString().Trim(); //定义account
                npassword = dataGridView1.Rows[0].Cells[3].Value.ToString().Trim(); //定义password
                nauthority = int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString().Trim()); //定义authority
                nsex = dataGridView1.Rows[0].Cells[5].Value.ToString().Trim(); //定义nsex
                nemail = dataGridView1.Rows[0].Cells[6].Value.ToString().Trim(); //定义nemail
                nclassid = int.Parse(dataGridView1.Rows[0].Cells[7].Value.ToString().Trim()); //定义classid
                nisavaliable = int.Parse(dataGridView1.Rows[0].Cells[8].Value.ToString().Trim());
                
                user.user_change(nuid, naccount, npassword, nauthority, nsex, nemail, nclassid, nname, nisavaliable);
            }
        }

        private void UserSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
