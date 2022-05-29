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
    public partial class RegeditPage : Form
    {

        public RegeditPage()
        {
            InitializeComponent();
        }
        UserManagerMent reg = new UserManagerMent();

        private void txt_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.isAvaliable(e);
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.isAvaliable(e); 
        }

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IsAvaliableEmail(e);
        }

        private void txt_classid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IntOnly(e);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            
            if (PublicClass.getText(txt_Password) != PublicClass.getText(txt_confirm))
            {
                PublicClass.showMessage("两次输入的密码不一致，请重试", "登入提示");
                txt_confirm.Text = "";
                txt_Password.Text = "";
            }
            else
            {
                
                //输入所需属性
                reg.UserAccount = PublicClass.getText(txt_Account);
                reg.UserPassword = PublicClass.getText(txt_Password);
                reg.UserEmail = PublicClass.getText(txt_Email);
                reg.UserClassid = PublicClass.getInt(txt_classid);
                reg.UserName = PublicClass.getText(txt_Name);

                //判断性别
                if (radb_male.Checked)
                {
                    reg.UserSex = "男";
                }
                else if (radb_female.Checked)
                {
                    reg.UserSex = "女";
                }

                //判断权限
                if (comb_Authortity.Text == "教师")
                {
                    reg.UserAuthority = 2;
                }
                else if (comb_Authortity.Text == "学生")
                {
                    reg.UserAuthority = 1;
                }
                else if (comb_Authortity.Text == "管理员")
                {
                    reg.UserAuthority = 3;
                }

                reg.UserIsAvaliable = 0;

                //一个内在方法，进行登陆操作
                reg.regedit();
            }
        }

        private void Regedit_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //用于权限判断的逻辑
            if(comb_Authortity.Text == "学生")
            {
                lab_class.Enabled = true;
                txt_classid.Enabled = true;
            }
            else
            {
                lab_class.Enabled = false;
                txt_classid.Enabled = false;
                txt_classid.Text = "0";
            }
        }

        private void comb_Authortity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegeditPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void txt_confirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.isAvaliable(e);
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IsAvaliableName(e);
        }
    }
}
