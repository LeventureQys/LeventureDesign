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
    public partial class PAsk : Form
    {
        PaperCore PInit = new PaperCore(); //初始化一个试卷类
        public PAsk()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IntOnly(e);
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            //if(cB_Public.Checked == true)
            //{
            //    txt_classid.Text = "0";
            //}
            //if(txt_classid.Text == ""{
            //    PublicClass.showMessage("请输入申请班级")
            //})
            DateTime dt = DateTime.Now; //获得当前时间
            String Title = "申请试卷错误";
            //初始化数据
            PInit.month = dt.Month; //解析获得当前月份
            PInit.PYear = dt.Year;//解析得当年年份
            PInit.classid = PublicClass.getInt(txt_classid); //班级id
            UserManagerMent temp = new UserManagerMent();
            PInit.Level = temp.returnLevel_ByClassid(PublicClass.getInt(txt_classid)); //年级
            PInit.pType = com_pType.SelectedIndex + 1; //获得考试类型
           
            PInit.Number = PInit.GetPNumber(); //考试次数

            if(false) //如果是公选课，则classid设定为0
            {
                //PInit.classid = 0;
            }
            else
            {
                if(txt_classid.Text == "")
                {
                    PublicClass.showMessage("请输入班级id", "试卷生成");
                    return;
                }
            }

            if (!PInit.InitCheck())
            {
                PublicClass.showMessage("试卷信息初始化失败，请检查试卷信息", Title);
                return;
            }
            else
            {
                if(!PInit.CreatePapter()) //创造一张试卷
                {
                    PublicClass.showMessage("试卷生成失败", Title);
                    return;
                }
                PublicClass.showMessage(String.Format("试卷生成成功！试卷ID为{0}，试卷名称为{1}",PInit.PaperId,PInit.Pname), "试卷生成");

                //此时已经向数据库中插入了一个对象了！

             }
        }

        private void cB_Public_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
