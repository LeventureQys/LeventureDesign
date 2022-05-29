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
        PaperCore PInit = new PaperCore(); //��ʼ��һ���Ծ���
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
            //    PublicClass.showMessage("����������༶")
            //})
            DateTime dt = DateTime.Now; //��õ�ǰʱ��
            String Title = "�����Ծ����";
            //��ʼ������
            PInit.month = dt.Month; //������õ�ǰ�·�
            PInit.PYear = dt.Year;//�����õ������
            PInit.classid = PublicClass.getInt(txt_classid); //�༶id
            UserManagerMent temp = new UserManagerMent();
            PInit.Level = temp.returnLevel_ByClassid(PublicClass.getInt(txt_classid)); //�꼶
            PInit.pType = com_pType.SelectedIndex + 1; //��ÿ�������
           
            PInit.Number = PInit.GetPNumber(); //���Դ���

            if(false) //����ǹ�ѡ�Σ���classid�趨Ϊ0
            {
                //PInit.classid = 0;
            }
            else
            {
                if(txt_classid.Text == "")
                {
                    PublicClass.showMessage("������༶id", "�Ծ�����");
                    return;
                }
            }

            if (!PInit.InitCheck())
            {
                PublicClass.showMessage("�Ծ���Ϣ��ʼ��ʧ�ܣ������Ծ���Ϣ", Title);
                return;
            }
            else
            {
                if(!PInit.CreatePapter()) //����һ���Ծ�
                {
                    PublicClass.showMessage("�Ծ�����ʧ��", Title);
                    return;
                }
                PublicClass.showMessage(String.Format("�Ծ����ɳɹ����Ծ�IDΪ{0}���Ծ�����Ϊ{1}",PInit.PaperId,PInit.Pname), "�Ծ�����");

                //��ʱ�Ѿ������ݿ��в�����һ�������ˣ�

             }
        }

        private void cB_Public_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
