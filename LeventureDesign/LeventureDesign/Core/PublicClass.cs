using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
            try { return int.Parse(txt1.Text.Trim().ToString()); }catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return -1;
            }
            
        }
        public static int getInt(ComboBox box1)
        {
            return int.Parse(box1.Text.Trim().ToString());
        }
        public static string PresentUser = "";//设置当前去用户账号
        public static int PresentAuthority = -1;//设置当前用户权限等级
        public static string PresentName = "";
        public static int PresentUserID = -1;
        public static bool isStu = false; //不是学生
        public static bool isTeacher = false; //不是老师
        public static bool isAdmin = false; //不是管理员
        public static int ViewMode = 0; //观察者模式，0是观察者，1是操作者
        public static int ChosenThing = -1; //管理员选中的临时对象
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
        public static bool DoubleOnly(KeyPressEventArgs e)
        {
            {
                bool isava = false;
                if (char.IsDigit(e.KeyChar) || e.KeyChar == '\r' || e.KeyChar == '\b'||e.KeyChar=='.') //比int能多输入一个点
                    isava = false;
                else
                    isava = true;

                return isava;
            }
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

        public static string getText(DataGridView dgv,int indexX,int indexY)
        {
            if(dgv == null || dgv.Rows.Count == 0 || dgv.Rows[indexX] == null)
            {
                return "";
            }
            else
            {
                return dgv.Rows[indexX].Cells[indexY].Value.ToString();
            }
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
            try
            {
                return user.Tables[0].Rows[indexX][indexY].ToString();
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return null;
            }
        }

        public static int getInt(DataSet user, int indexX, int indexY)
        {
            try
            {
                if (user.Tables[0].Rows[indexX][indexY].ToString() == "" || user.Tables[0].Rows[indexX]==null || user.Tables[0].Columns[indexY]==null)//假如为空
                { return 0;}
                else
                {
                    return int.Parse(user.Tables[0].Rows[indexX][indexY].ToString());
                }
                
            }
            catch(Exception ex)
            {
                //PublicClass.showMessage(ex.ToString(), "");
                Debug.WriteLine(ex.ToString());
                return -1;
            }

        }

        public static int getInt(DataGridView dgv,int indexX,int indexY)
        {
            if (dgv.Rows[indexX].Cells[indexY].ToString() == "" || dgv.Rows[indexX] == null || dgv.Columns[indexY] == null)//假如为空
            { return -1; }
            else
            {
                Debug.WriteLine(dgv.Rows[indexX].Cells[indexY].Value.ToString());
                return int.Parse(dgv.Rows[indexX].Cells[indexY].Value.ToString());
            }
        }

        public static int getInt(DataRow dtr,int index)
        {
            if(dtr.ItemArray[index] == null || dtr.ItemArray.ToString() == "" || dtr == null)
            {
                return -1;
            }
            else
            {
                return int.Parse(dtr.ItemArray[index].ToString());
            }
        }
        //public static int getInt(DataSet.Rows)
        public static String GetPath_Pic() //弹出窗口，打开图片返回图片路径
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择一张图片";
            dialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp";
            String path = null; //创建一个路径类型
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) //打开一个对话框，而且当你点击确认之后则:
            {
                path = dialog.FileName; //得到一个当前文件的文件名
            }

            return path;
            
        }

        public static bool ArrayIsReapted(int[] Input) //数组判重
        {

            for (int i = 0; i < Input.Length; i++)
            {
                //int a = Input[i];
                for (int j = i + 1; j < Input.Length; j++)
                {
                    //int b = Input[j];
                    if (Input[i] == Input[j])
                        return true;

                }
            }

            return false;

        }

        public static bool DialogConfirm(String strMessage,String Title)
        {
            DialogResult dr = MessageBox.Show(strMessage, Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public static int DialogGetInt(String strMessage, String Title)
        //{
        //    //DialogResult dr = MessageBox
        //}
        //传入一个数组,求出一个数组的最大值
        static int GetMax(int[] array)//数组找最大值
        {
            int max = array[0];//用max记录最大值,循环比较数组内所有元素,发现有比它大就交换值,最后返回 Max
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        //传入一个数组,求出一个数组的最大值
        public static int GetMax(double[] array) //返回最大值的序号
        {
            double max = array[0];//用max记录最大值,循环比较数组内所有元素,发现有比它大就交换值,最后返回 Max
            int index = 0;
            
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    index = i;
                }
            }
            return index ;
        }

        public static DataSet DataSetClip_Last10times(DataSet dts)//做dataset切片，取得最后十个
        {
            DataSet temp = new DataSet();
            if (dts.Tables[0].Rows.Count <= 10)
            {
                temp = dts;
            }
            else //假如有超过十场的考试
            {
                temp = dts.Clone(); //复制结构，否则识别不到表很恶心
                int Length = dts.Tables[0].Rows.Count; //该表长度
                for (int i = 9; i >= 0; i--)//进行切片
                {
                    DataRow dr = temp.Tables[0].NewRow();
                    DataRow row = dts.Tables[0].Rows[Length - i];
                    dr.ItemArray = row.ItemArray;
                    temp.Tables[0].Rows.Add(dr);
                }



            }
            return temp;
        }
        public static bool isEmpty(double[] dou)//判断是否为空
        {
            bool flag = true;
            foreach(double i in dou)
            {
                if(i != 0.0 ) //只要有一个数据不为0，那么这个就变flag
                {
                    flag = false;
                }
            }
            return flag;
        }

        }
    }
    
