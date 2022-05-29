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
    public partial class QuestInsert : Form
    {
        QManagerment QInit = new QManagerment(); //初始化一个公用QManagerment对象
        public QuestInsert()
        {

            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0 || comboBox3.SelectedIndex == 1) //如果选择的index是选择题，则
            {
                btn_Search2.Enabled = false; //下面两个选项就不能用了
                txt_Path2.Enabled = false;
                comb_Answer.Enabled = true;

                txt_Path2.Text = ""; // 清空path2地址栏,虽然用不上
                comb_Answer.Text = "A";
            }
            else // 如果不是选择题，是填空题或者别的
            {
                btn_Search2.Enabled = true; //下面两个选项就不能用了
                txt_Path2.Enabled = true;
                comb_Answer.Enabled = false;

                txt_Path2.Text = ""; // 清空path2地址栏,虽然用不上
                comb_Answer.Text = "";
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择一张图片";
            dialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) //打开一个对话框，而且当你点击确认之后则:
            {
                String path = dialog.FileName; //得到一个当前文件的文件名
                txt_Path1.Text = path; //将其输入到txt_Path下
            }
        }

        private void btn_Search2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择一张图片";
            dialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) //打开一个对话框，而且当你点击确认之后则:
            {
                String path = dialog.FileName; //得到一个当前文件的文件名
                txt_Path2.Text = path; //将其输入到txt_Path下
            }
        }

        private void btn_QAccess_Click(object sender, EventArgs e)
        {
            if (QInit.Q_isExist(txt_Path1.Text)) //QInit.Q_isExist(txt_Path1.Text)
            {
                PublicClass.showMessage("当前图片已存在，请重新选择", "插入提示");
                return;
            }

            if (txt_Path1.Text == "") //如果题目图片栏未空
            {
                PublicClass.showMessage("请打开一张图片", "插入提示");
                return;
            }
            else //其他内容是有默认值保护的，所以不需要判定是否为空
            {
                if (comboBox3.SelectedIndex == 0 || comboBox3.SelectedIndex == 1) //如果当前选择的是选择题 两种选择题
                {
                    QInit.Answer = comb_Answer.Text.ToString(); //答案是选择题框中的一个答案         
                }
                else
                {
                    if (txt_Path2.Text == "") // 如果答案栏为空
                    {
                        PublicClass.showMessage("请选择一张答案图片", "插入提示");
                        return;
                    }
                    else //如果答案栏不为空，则答案为选择题答案
                    {
                        QInit.Answer = txt_Path2.Text.ToString(); //否则 答案就是图片栏中的地址
                    }
                }

            }
            QInit.PicPath = txt_Path1.Text.ToString();
            //QInit. = PublicClass.getInt(comboBox1);
            QInit.Q_CidTrans(comboBox2.SelectedIndex);
            QInit.Q_BelongTrans(comboBox3.SelectedIndex);

            if (QInit.Q_Insert())
            {
                txt_Path1.Text = ""; //清空当前地址栏
                txt_Path2.Text = "";//清空答案栏
            }
        }

        private void QuestInsert_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
