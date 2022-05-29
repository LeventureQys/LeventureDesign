using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeventureDesign
{
    class FileIO
    {
        public string OpenFile() //打开文件控件，选中文件，返回路径
        {
            try
            {
                string strFileName = "";
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "图片文件(*.jpg;*.png;*.jpeg;*.bm)|*.jpg;*.png;*.jpeg;*.bmp";
                ofd.ValidateNames = true; // 验证用户输入是否是一个有效的Windows文件名
                ofd.CheckFileExists = true; //验证路径的有效性
                ofd.CheckPathExists = true;//验证路径的有效性
                if (ofd.ShowDialog() == DialogResult.OK) //用户点击确认按钮，发送确认消息
                {
                    strFileName = ofd.FileName;//获取在文件对话框中选定的路径或者字符串

                }
                return strFileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public string OpenFolder() //打开文件夹控件
        {
            try
            {
                string sPath = "";
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "选择文件所在文件夹目录";  //定义在对话框上显示的文本

                if (folder.ShowDialog() == DialogResult.OK)
                {
                    sPath = folder.SelectedPath;
                }
                return sPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

      
    }
}
