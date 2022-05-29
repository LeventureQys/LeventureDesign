using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LeventureDesign
{
    class PublicClass
    {
        //用于做输入键值时的事件判定句柄，若是数字或字母，则可以接受，若不是，则不能接受。在实际代码中用e.Handle来判断
        //KeyPressEventArgs 这样的输入检测型的函数使用范例
        //一般在KeyPress事件用
        //e.Handled = PublicClass.isAvaliable(e);

        //所有的int类型初始化或清除时都必须为-1，用以作为是否赋值的标准
        //所有的string类型初始化或清除时都必须为""
        public static int getInt(TextBox txt1)
        {
            return int.Parse(txt1.Text.Trim().ToString());
        }
        public static string PresentUser = "";//设置当前去用户账号
        public static int PresentAuthority = -1;//设置当前用户权限等级
        public static string PresentName = "";
        public static bool isAvaliable(KeyPressEventArgs e) //是否是可用的数字字母组合
        {
            bool isava = false;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\r' || e.KeyChar == '\b' || char.IsLetter(e.KeyChar))
                isava = false;
            else
                isava = true;

            return isava;
        }
        public static bool IsAvaliableEmail(KeyPressEventArgs e)//跟上面的比多了个@和.，用做判断邮箱
        {
            bool isava = false;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\r' || e.KeyChar == '\b' || char.IsLetter(e.KeyChar) || e.KeyChar == '@' || e.KeyChar == '.')
                isava = false;
            else
                isava = true;

            return isava;
        }
        public static bool IsAvaliableName(KeyPressEventArgs e) //是否为合法姓名
        {
            bool isava = false;
            if ((int)e.KeyChar > 127 || e.KeyChar == '\r' || e.KeyChar == '\b' || char.IsLetter(e.KeyChar)) //如果是汉字
                isava = false;
            else
                isava = true;

            return isava;
        }
        //
        //
        //
        public static bool IntOnly(KeyPressEventArgs e) //仅支持数字类型
        {
            bool isava = false;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\r' || e.KeyChar == '\b')
                isava = false;
            else
                isava = true;

            return isava;
        }
        public static bool isNumber(string st)
        {
            try
            {
                int var1 = Convert.ToInt32(st);
                return true;
            }
            catch
            {
                return false;
            }
        }//是否是数字？

        public static void showMessage(string strMessage, string strTitle) //展示一个提示框，展示strMessage，和标题strTitle
        {
            MessageBox.Show(strMessage, strTitle);
        }
      
        // bool类型决定是true还是false时展开
        public static void showMessage(bool TrueorFalse, string strMessage, string Type)
        {
            if (TrueorFalse)
            {
                if (TrueorFalse)//如果查到了才需要显示窗体消息
                {
                    PublicClass.showMessage(strMessage, Type);
                }

            }
            else
            {
                if (!TrueorFalse)//如果没查到才需要显示对应窗体消息
                {
                    PublicClass.showMessage(strMessage, Type);
                }

            }
        }

        public static string getText(TextBox txt1)
            {
                return txt1.Text.Trim().ToString();
            }
            //此方法用于判断空int值,若为空则返回true同时展示一个文本框strMessage代表需要展示的内容，Type代表展示的标题
            public static bool isNullorEmpty(int num, string strMessage, string Type)
            {
                if (num == -1)
                {
                    showMessage(strMessage, Type);
                    return true;
                }
                return false;
            }
            //用于判断空串
            public static bool isNullorEmpty(string str, string strMessage, string Type)
            {
                if (str == "")
                {
                    showMessage(strMessage, Type);
                    return true;
                }
                return false;
            }

        public static string getText(DataSet user,int indexX,int indexY)
        {
            return user.Tables[0].Rows[indexX][indexY].ToString();
        }

        public static int getInt(DataSet user, int indexX, int indexY)
        {
            try
            {

                return int.Parse(user.Tables[0].Rows[indexX][indexY].ToString());
            }
            catch(Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "");
                return -1;
            }

        }

    }
    } 
