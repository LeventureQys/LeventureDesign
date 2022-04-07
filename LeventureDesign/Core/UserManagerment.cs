using LeventureDesign.Login;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeventureDesign
{
    public class UserManagerMent
    {
        public UserManagerMent()
        { //初始化构造函数
            UserAccount = "";
            UserPassword = "";
            UserEmail = "";
            UserSex = "";
            UserName = "";
            UserAuthority = -1;
            UserClassid = -1;
            UserIsAvaliable = -1;
            UserID = -1;
        }
        DataOperator dataoper = new DataOperator();

        public int UserID;
        public string UserAccount;
        public string UserPassword;
        public string UserEmail;
        public string UserSex;
        public string UserName;
        public int UserAuthority;
        public int UserClassid;
        public int UserIsAvaliable;

        //查询用户是否存在，若存在，则返回true，反之返回false
        public bool user_isExist(int uid) 
        {
            string select = "select * from tb_user where userid=" + uid;
            int num = dataoper.ExecSQL(select);
            if (num != 0) //倘若搜出来的数字不为0，这里返回的数字其实相当于是工号
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //查询用户是否存在，若存在，则返回true，反之返回false
        public bool user_isExist(string account)
        {
            
            string select = "select * from tb_user where account='" + account+"'";
            int num = dataoper.ExecSQL(select);
            if (num != 0) //倘若搜出来的数字不为0，这里返回的数字其实相当于是工号
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //检查账号密码是否同时成立
        public bool user_isExist(string account,string password)
        {
            string select = "select * from tb_user where account='" + account + "' and password='"+password+"'";
            int num = dataoper.ExecSQL(select);
            if (num != 0 && num != -1) //倘若搜出来的数字不为0，这里返回的数字其实相当于是工号
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //忘记密码处使用
        public bool user_isExist(string account, string email, string sex, string name)
        {
            string select = "select * from tb_user where account='" + account + "' and email='" + email + "' and sex='"+sex+"' and name='"+name+"'";
            int num = dataoper.ExecSQL(select);
            if (num != 0 && num != -1) //倘若搜出来的数字不为0，这里返回的数字其实相当于是工号
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //插入一个用户
        public void user_insert(string account, string password, int authority, string sex, string email, int ClassID, string name, int IsAvaliable)
        {

            string InsertUser = "insert into tb_user(account,password,authority,sex,email,classID,IsAvaliable,name) values('" + account + "','" + password + "','" + authority + "','" + sex + "','" + email + "','" + ClassID + "','" + IsAvaliable + "','" + name + "')"; //插入一条未被激活的用户
            int num = dataoper.ExecSQLResult(InsertUser);
            
        }
        //通过账号查找用户的权限等级，如果用户不存在则直接返回-1
       
        public int user_Authority(string account)
        {
            if (!user_isExist(account))
            {
                return -1;
            }
            else
            {
                string Sql = "select authority from tb_user where account='" + account + "'";
                return int.Parse(dataoper.ExecSQLString(Sql));
            }

            
        }
        //修改一个用户
        public void user_change(int uid, string account, string password, int authority, string sex, string email, int ClassID, string name, int IsAvaliable)
        {
            
            {
                string Changer = "update tb_user set " + "name='" + name + "',account='" + account + "',password='" + password + "',authority='" + authority + "',sex='" + sex + "',email='" + email + "',classid='" + ClassID + "',isavaliable='" + IsAvaliable + "' " + "where userid='" + uid + "'";
                int num = dataoper.ExecSQLResult(Changer); //运行删除uid的命令
                if (num == 1)
                {
                    MessageBox.Show("用户修改成功！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("用户修改失败，可能不存在该用户或输入信息错误！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void user_delete(int uid)//删除userid的账户
        {
            string DeleteUser = "delete from tb_user where userid=" + uid;
            int num = dataoper.ExecSQLResult(DeleteUser); //运行删除uid的命令
            if (num == 1)
            {
                MessageBox.Show("用户删除成功！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("用户删除失败，可能不存在该用户！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //pwdchange做密码修改
        public void pwd_change(string account,string password)
        {
            string changer = "update tb_user set password='" + password + "' where account='" + account + "'";

            //string Changer = "update tb_user set " + "name='" + name + "',account='" + account + "',password='" + password + "',authority='" + authority + "',sex='" + sex + "',email='" + email + "',classid='" + ClassID + "',isavaliable='" + IsAvaliable + "' " + "where userid='" + uid + "'";
            int num = dataoper.ExecSQLResult(changer); //运行删除uid的命令
            if (num == 1)
            {
                MessageBox.Show("密码修改成功！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("密码修改失败，可能不存在该用户或输入信息错误！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //查询所有用户，返回一个dataset
        public DataSet userdataset_all()
        {
            try { 
            string SearchUser = "select * from tb_user";
            DataSet st = new DataSet();
            st = dataoper.GetSqlDataset(SearchUser);

            return st;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return null;
            }
        }
        //以uid查询一个用户
        public DataSet userdataset_search(int uid)//查询用户信息，以uid
        {
            try { 
            string SearchUser = "select * from tb_user where userid=" + uid;
            DataSet st = new DataSet();
            st = dataoper.GetSqlDataset(SearchUser);

            return st;
            }
            catch (Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return null;
            }
        }

        public DataSet userdataset_search(string str)//查询用户信息，以账号
        {
            try
            {
                string SearchUser = "select * from tb_user where account='" + str + "'";
                return dataoper.GetSqlDataset(SearchUser);
            }catch(Exception ex)
            {
                PublicClass.showMessage(ex.ToString(), "查询提示");
                return null;
            }
        }

        public DataSet userdataset_searchUnAvaliable()//查询未激活用户信息
        {
            string SearchUser = "select * from tb_user where IsAvaliable=0;";
            return dataoper.GetSqlDataset(SearchUser);
        }

        public bool Login(string Account,string Password)
        {
            if (!user_isExist(Account))//如果找不到该账号
            {
                PublicClass.showMessage("输入账号不存在！", "登陆提示");
                return false;
            }
            else if(!user_isExist(Account,Password))
            {
                PublicClass.showMessage("输入密码出错，请检查输入密码！", "登陆提示");
            }
            else
            {
                UserAccount = Account;
                UserPassword = Password;

                PublicClass.PresentUser = UserAccount;//获得当前用户的账号
                PublicClass.PresentAuthority = user_Authority(UserAccount);//获得当前用户权限等级

                //在给了PublicClass的当前用户等级和权限等级之后，还需要把它的信息初始化一下

                return true;
            }

            return false;
        }

        //通过账号来初始化这个类
        public void initUser()
        {
            DataSet User = userdataset_search(PublicClass.PresentUser); // 通过账号查询对应用户的dataset

            UserID = PublicClass.getInt(User, 0, 0);
            UserName = PublicClass.getText(User, 0, 1);
            UserAccount = PublicClass.getText(User, 0, 2);
            UserPassword = PublicClass.getText(User, 0, 3);
            UserAuthority = PublicClass.getInt(User, 0, 4);
            UserSex = PublicClass.getText(User, 0, 5);
            UserEmail = PublicClass.getText(User, 0, 6);
            UserClassid = PublicClass.getInt(User, 0, 7);
            UserIsAvaliable = PublicClass.getInt(User, 0, 8);

        }

        public void initUser(string account)
        {
            DataSet User = userdataset_search(account); // 通过账号查询对应用户的dataset

            UserID = PublicClass.getInt(User, 0, 0);
            UserName = PublicClass.getText(User, 0, 1);
            UserAccount = PublicClass.getText(User, 0, 2);
            UserPassword = PublicClass.getText(User, 0, 3);
            UserAuthority = PublicClass.getInt(User, 0, 4);
            UserSex = PublicClass.getText(User, 0, 5);
            UserEmail = PublicClass.getText(User, 0, 6);
            UserClassid = PublicClass.getInt(User, 0, 7);
            UserIsAvaliable = PublicClass.getInt(User, 0, 8);
        }

        public void regedit()
        {
            UserIsAvaliable = 0; //注册用户的可用性都是0
            string type1 = "注册失败！";
            if(!PublicClass.isNullorEmpty(UserAccount,"请输入账号!",type1))
                if(!PublicClass.isNullorEmpty(UserPassword,"请输入密码！",type1))
                    if(!PublicClass.isNullorEmpty(UserSex,"请选择性别！",type1))
                        if(!PublicClass.isNullorEmpty(UserClassid,"请输入班号！",type1))
                            if(!PublicClass.isNullorEmpty(UserName,"请输入姓名",type1))
                                if(!PublicClass.isNullorEmpty(UserAuthority,"请输入权限等级",type1))
                                    if(!PublicClass.isNullorEmpty(UserIsAvaliable,"请输入该用户是否可用",type1))
                                        if(!PublicClass.isNullorEmpty(UserEmail,"请输入注册邮箱",type1))
                                            if(UserAuthority == 1 && UserClassid == 0) //如果一个学生的classid为0，则报错
                                            {
                                                PublicClass.showMessage("请输入正确的班级ID", type1);
                                            }
                                            else
                                            {
                                                //假如输入的逻辑已经完全完备了，则需要对下一步进行处理了
                                                if (user_isExist(UserAccount))//检查账号是否已存在？
                                                {
                                                    PublicClass.showMessage("输入账号已存在", type1);
                                                }
                                                else //正式插入一个用户
                                                {
                                                    user_insert(UserAccount, UserPassword, UserAuthority, UserSex, UserEmail, UserClassid, UserName, UserIsAvaliable);
                                                    PublicClass.showMessage("恭喜您，账号注册成功，请等待管理员审核", type1);
                                                }
                                            }
        }

        public void forgetpwd(ForgetPage F1)
        {
            string type2 = "忘记密码";
            if(!PublicClass.isNullorEmpty(UserAccount,"请输入账号!",type2))
                if(!PublicClass.isNullorEmpty(UserEmail, "请输入电子邮箱!", type2))
                    if(!PublicClass.isNullorEmpty(UserSex, "请输入性别!", type2))
                        if(!PublicClass.isNullorEmpty(UserName, "请输入姓名!", type2))  
                            {
                                if (!user_isExist(UserAccount))//如果用户不存在？
                                {
                                    PublicClass.showMessage("输入用户不存在", type2);
                                }
                                else if(!user_isExist(UserAccount,UserEmail,UserSex,UserName)) //检索该用户是否存在
                                {
                                    PublicClass.showMessage("该用户不存在，请检查输入信息或联系管理员", type2);
                                }
                                else//此处正式进行密码修改
                                {
                                    PwdchangePage forg = new PwdchangePage(F1);
                                    forg.Show();
                                }

                            }

                        
                         }

        //DataOperator dataoper = new DataOperator();
        public void Class_insert(string Level, int number, int teacherID)
        {
            string InsertClass = "insert into tb_class(teachID,num,level) values('" + teacherID + "','" + number + "','" + Level + "')";//插入一个班级
            int num = dataoper.ExecSQLResult(InsertClass);
            if (num >= 1)
            {
                MessageBox.Show("班级添加成功！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("班级添加失败，已存在相同用户或出现错误", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        } //插入一个用户，输入年级班次教师ID

        //通过classid删除一个用户
        public void Class_Delete(int ClassID)
        {
            string DeleteClass = "Delete from tb_class where classid='" + ClassID + "'";
            int num = dataoper.ExecSQLResult(DeleteClass); //运行删除uid的命令
            if (num == 1)
            {
                PublicClass.showMessage("班级删除成功", "删除提示");
            }
            else
            {
                PublicClass.showMessage("班级删除失败，可能不存在该用户！", "删除提示");
            }
        }

        public DataSet classviewdataset_search(int classid)
        {
            string SearchClass = "select * from vr_classviewer where classid=" + classid;
            DataSet st = new DataSet();
            st = dataoper.GetSqlDataset(SearchClass);

            return st;
        } //这个搜索视图，看的是老师的姓名

        public DataSet classtabledataset_search(int classid) //这个搜索dataset，原始数据，修改表的时候用
        {
            string SearchClass = "select * from tb_class where classid=" + classid;
            DataSet st = new DataSet();
            st = dataoper.GetSqlDataset(SearchClass);

            return st;
        }

        public void class_change(int nclassid, string nlevel, int nnum, int nteacherid, int nnumber)
        {
            try
            {


                string change = "update tb_class set level='" + nlevel + "',num=" + nnum + ",teachid='" + nteacherid + "',number=" + nnumber + " where classid=" + nclassid;
                int num = dataoper.ExecSQLResult(change); //运行删除uid的命令
                if (num == 1)
                {
                    MessageBox.Show("班级修改成功！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("班级修改失败，可能不存在该教师或输入信息错误！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //int ClassID;
        //int teachID;
        //int number;
        //string level;
        //int num;
        //DataOperator dataoper = new DataOperator();
        public DataSet classdataset_all() //获得所有class的dataset
        {
            string SearchUser = "select * from vr_classviewer";
            DataSet st = new DataSet();
            st = dataoper.GetSqlDataset(SearchUser);

            return st;
        }
        public void class_change(string level, int teachID, int number, int num1)
        {
            string Changer = "update tb_class set level='" + level + "',teachID='" + teachID + "',number='" + number + "',num='" + num1 + "'";
            int num = dataoper.ExecSQLResult(Changer); //运行修改的命令
            if (num == 1)
            {
                MessageBox.Show("班级修改成功！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("班级修改失败，可能不存在该用户或输入信息错误！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
