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
   
    public partial class AdminPage : Form
    {

        LoginPage userAbove = new LoginPage();

        UserManagerMent user = new UserManagerMent();
        public AdminPage()
        {
            
            user.initUser(PublicClass.PresentUser); //初始化user
            InitializeComponent();
        }
        
        private void AdminPage_Load(object sender, EventArgs e)
        {
            label1.Text ="您好，欢迎"+ user.UserName+"管理员";
            PublicClass.PresentName = user.UserName;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = System.DateTime.Now.ToString();
        }

        private void btn_Usermanager_Click(object sender, EventArgs e)
        {
            UserManager userment = new UserManager(this);
            userment.Show();
        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            userAbove.Show();
        }
    }
}
