using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeventureDesign.Login
{
    public partial class PwdchangePage : Form
    {
        private ForgetPage Father = null;
        public PwdchangePage(ForgetPage F1)
        {
            this.Father = F1;
            InitializeComponent();
        }

        private void btn_ChangeConfirm_Click(object sender, EventArgs e)
        {
            if(PublicClass.getText(txt_pwd) != PublicClass.getText(txt_pwdConfirm))//如果新密码不等于确认密码，则弹窗
            {
                PublicClass.showMessage("两次输入密码不一致！", "改密提示");
            }
            else
            {
                UserManagerMent changer = new UserManagerMent();
                string account = this.Father.getAccount(); //得到父窗口的账号信息
                changer.pwd_change(account, PublicClass.getText(txt_pwd));//传参，修改密码
            }

            PublicClass.showMessage("恭喜你，密码修改成功，新密码为：  " + PublicClass.getText(txt_pwd), "修改密码成功！");
            this.Close();
        }

        private void PwdchangePage_Load(object sender, EventArgs e)
        {

        }
    }
}
