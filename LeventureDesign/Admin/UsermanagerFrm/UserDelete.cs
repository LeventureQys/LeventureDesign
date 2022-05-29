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
    public partial class UserDelete : Form
    {
        public UserDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PublicClass.isNullorEmpty(textBox1))
            {
                PublicClass.showMessage("请输入需要删除的对象!", "删除提示");
            }
            else
            {
                UserManagerMent userinit = new UserManagerMent();
                userinit.user_delete(int.Parse(textBox1.Text.Trim()));
                textBox1.Clear();
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IntOnly(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
