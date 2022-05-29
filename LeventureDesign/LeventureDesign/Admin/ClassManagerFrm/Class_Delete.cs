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
    public partial class Class_Delete : Form
    {
        ClassManagePage classAbove = null;
        public Class_Delete(ClassManagePage F1)
        {
            classAbove = F1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int classid = int.Parse(textBox1.Text.Trim().ToString());
            UserManagerMent classinit = new UserManagerMent();
            classinit.Class_Delete(classid);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IntOnly(e);
        }

        private void Class_Delete_Load(object sender, EventArgs e)
        {

        }

        private void Class_Delete_FormClosed(object sender, FormClosedEventArgs e)
        {
            classAbove.ClassRefreshment();
        }
    }
}
