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
    public partial class ForgetPage : Form
    {
        public ForgetPage()
        {
            InitializeComponent();
        }
        UserManagerMent forget = new UserManagerMent();
        
        private void txt_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.isAvaliable(e);
        }

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IsAvaliableEmail(e);
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IsAvaliableName(e);
        }

        private void btn_changepwd_Click(object sender, EventArgs e)
        {
            forget.UserAccount = PublicClass.getText(txt_Account);
            forget.UserEmail = PublicClass.getText(txt_Email);
            forget.UserName = PublicClass.getText(txt_name);
            if (rabt_male.Checked)
            {
                forget.UserSex = "男";
            }
            else
            {
                forget.UserSex = "女";
            }
            
            forget.forgetpwd(this);
        }

        public string getAccount()
        {
            return forget.UserAccount;
        }
        private void ForgetPage_Load(object sender, EventArgs e)
        {

        }
    }
}
