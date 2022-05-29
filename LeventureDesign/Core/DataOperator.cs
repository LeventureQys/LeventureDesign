using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LeventureDesign
{
    class DataOperator
    {
        private static string connString = "server=127.0.0.1;port=3306;user=root;password=1234;database=db_papermaker;";

        //建立数据库连接对象
        public static MySqlConnection connection = new MySqlConnection(connString);

        public static bool isNullorEmpty(TextBox e)
        {
            try
            {
                if (e.Text.Trim() == "")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static bool isNullorEmpty(string e) //此方法检测输入的字符串是否为空
        {
            try
            {
                if (e.Trim() == "")
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        //检测输入的int类型变量是否未空
        public static bool isNullorEmpy(int e)
        {
            {
                if (e == -1 && e == 0)
                {
                    return true;
                }
                return false;
            }
        }

        //输入一条sql语句，执行并返回第一列，可用于判定是否完成
        public int ExecSQL(string sql) //此条一般用于做查询
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connection); //指定要执行的命令
                if (connection.State == System.Data.ConnectionState.Closed) //如果当前连接已关闭，则打开
                {
                    connection.Open(); //打开连接
                }
                int num = Convert.ToInt32(command.ExecuteScalar()); //执行该command,并将数据返回给num

                connection.Close();
                return num;//将该值返回给函数
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public string ExecSQLString(string sql) //此条一般用于做查询
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connection); //指定要执行的命令
                if (connection.State == System.Data.ConnectionState.Closed) //如果当前连接已关闭，则打开
                {
                    connection.Open(); //打开连接
                }
                string result = command.ExecuteScalar().ToString(); //执行该command,并将数据返回给num

                connection.Close();
                return result;//将该值返回给函数
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public int ExecSQLResult(string sql) //此条一般用于做增删改这种对数据库数据有直接影响的操作，反馈受影响的数据的行数
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connection); //指定要执行的命令
                if (connection.State == ConnectionState.Closed) //如果当前连接已关闭，则打开
                {
                    connection.Open(); //打开连接
                }
                int result = Convert.ToInt32(command.ExecuteNonQuery()); //执行该command,并将数据返回给result

                connection.Close();
                return result;//将该值返回给函数
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        public MySqlDataReader GetSqlDataReader(string sql) //返回一个DataReader，用于动态处理数据库，通常用于增删改
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlDataReader datareader = command.ExecuteReader(); //生成一个datareader
                return datareader; //将其返回
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }//千万注意，这里调用了datareader之后要记得close掉，否则有可能会出现不可预料的错误和资源浪费
        //close个鸡巴，我看我写的代码也没close过，算了哎

        public DataSet GetSqlDataset(string sql) //返回一个dataset，用于静态处理数据库，通常用于单纯的查询
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                MySqlDataAdapter sqlda = new MySqlDataAdapter(sql, connection);
                DataSet dts = new DataSet();
                sqlda.Fill(dts, "lwx");
                return dts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        #region 存储过程操作

        /// <summary>
        /// 执行存储过程，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlDataReader</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters) //运行数据库中的存储过程
                                                                                               //参数说明,storedProcName是存储过程的名称，parameters是变量数组，用于输入变量组
                                                                                               //           一、直接构造：
                                                                                               //              IDataParameter[] parameters = new IDataParameter[] { sqlparameter1, sqlparameter2, new SqlParameter(...) }

        //          二、通过ArrayList转换。
        //                  ArrayList paramlist = new ArrayList()
        //                  paramlist.Add(sqlparameter1 );
        //                  ....
        //                  ....

        //                  IDataParameter param = (IDataParameter[])paramlist.ToArray(typeof(IDataParameter));

        {
            using (connection)
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(storedProcName, connection);

                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {


                    foreach (MySqlParameter parameter in parameters)
                    {
                        if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                            (parameter.Value == null))
                        {
                            parameter.Value = DBNull.Value;
                        }
                        cmd.Parameters.Add(parameter);
                    }

                }
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }

        }
        #endregion


    }



}
