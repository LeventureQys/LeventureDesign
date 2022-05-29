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
    public partial class QSearch : Form
    {
        QManagerment QInit = new QManagerment();
        DataSet Quest = new DataSet();
        public QSearch()
        {
            InitializeComponent();
        }



        private void txt_Qno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PublicClass.IntOnly(e);
        }

        private void QSearch_Load(object sender, EventArgs e)
        {
            txt_Path.Visible = true;
            txt_Qno.Visible = false;
            comb_Belong.Visible = false;
            comb_Chapter.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                txt_Path.Visible = true;
                btn_Search.Visible = true;
                  
                txt_Qno.Visible = false;
                comb_Belong.Visible = false;
                comb_Chapter.Visible = false;
                Clear_Edit();
            }
        }

        private void comb_Chapter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txt_Path.Visible = false;
                btn_Search.Visible = false;

                txt_Qno.Visible = true;
                comb_Belong.Visible = false;
                comb_Chapter.Visible = false;
                Clear_Edit();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txt_Path.Visible = false;
                btn_Search.Visible = false;

                txt_Qno.Visible = false;
                comb_Belong.Visible = true;
                comb_Chapter.Visible = false;
                Clear_Edit();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                txt_Path.Visible = false;
                btn_Search.Visible = false;

                txt_Qno.Visible = false;
                comb_Belong.Visible = false;
                comb_Chapter.Visible = true;
                Clear_Edit();
            }
        }

        private void btn_Access_Click(object sender, EventArgs e)
        {
            //点击查询后，首先需要根据状态选择情况，对当前的输入做分类
            String Title = "插入提示";
            String Search = "";
            int Searchi = -1;
            if (radioButton4.Checked) //路径
            {
                if (txt_Path.Text.ToString() != "")
                {
                    Search = txt_Path.Text.ToString();
                    Quest = QInit.Q_SearchWithPath(Search);
                }
                else
                {
                    PublicClass.showMessage("请打开一张图片", Title);
                    return;
                }


            }

            else if (radioButton1.Checked) //题号
            {
                if (txt_Qno.Text.ToString() != "") { 
                Searchi = PublicClass.getInt(txt_Qno);
                Quest = QInit.Q_Search(Searchi);
                }
                else
                {
                    PublicClass.showMessage("请输入题号", Title);
                    return;
                }
            }
            
            else if (radioButton2.Checked) //题目类型
            {
                if (comb_Belong.Text.ToString() != "")
                {
                    //Searchi = PublicClass.getInt(comb_Belong);
                    QInit.Q_BelongTrans(comb_Belong.SelectedIndex);
                    Searchi = QInit.Belong;
                    Quest = QInit.Q_SearchWithBelong(Searchi);
                }
                else
                {
                    PublicClass.showMessage("请选择题目类型", Title);
                    return;
                }
            }
            else if (radioButton3.Checked) //题目章节
            {
                if (comb_Chapter.Text.ToString() != "")
                {
                    QInit.Q_CidTrans(comb_Chapter.SelectedIndex);
                    Searchi = QInit.Cid;
                    Quest = QInit.Q_SearchWithChapter(Searchi);
                }
                else
                {
                    PublicClass.showMessage("请选择题目章节", Title);
                    return;
                }
            }

            //将dataset的内容输入dataGridView1
            dataGridView1.DataSource = Quest;
            dataGridView1.DataMember = "lwx";
            QInit.Q_TitleInit(dataGridView1);
        }

        private void txt_Qno_TextChanged(object sender, EventArgs e)
        {
            //btn_Search
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            String Path = PublicClass.GetPath_Pic(); // 得到一个图片地址
            txt_Path.Text = Path;
        }

        private void Clear_Edit() //清除所有内容
        {
            txt_Path.Text = "";
            //btn_Search.Visible = false;

            txt_Qno.Text = "";
            comb_Belong.Text ="";
            comb_Chapter.Text = "";
        }
    
        private void button1_Click(object sender, EventArgs e) //删除按钮
        {
            
            int Qno = -1;
            int index = dataGridView1.CurrentRow.Index; //当前选定的行
            Qno = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()); //定义Qno

            QInit.Q_DeleteFromQno(Qno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                QManagerment Change = new QManagerment();

                if (dataGridView1.DataSource == null)
                {
                    PublicClass.showMessage("请先进行查询", "修改试题");
                }
                else
                {
                    int index = dataGridView1.CurrentRow.Index; // 获得鼠标选定行

                    Change.Qno = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                    Change.PicPath = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    //Change.difficulty = int.Parse(dataGridView1.Rows[index].Cells[2].Value.ToString());
                    Change.Cid = int.Parse(dataGridView1.Rows[index].Cells[2].Value.ToString());
                    Change.Belong = int.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());
                    Change.Answer = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    if (Change.Q_Change()) //如果申请修改成功
                    {

                    }
                    else
                    {
                        Clear_Edit();//清除所有输入内容，重新输入
                        dataGridView1 = null; //清除dataGridView1
                    }
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
