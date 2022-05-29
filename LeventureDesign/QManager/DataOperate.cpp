#include "DataOperate.h"



void DataOperate::initSql() //初始化数据库，建立一个db，用以连接数据库
{
    QT_TRY{

        qno = ""; //试题编号
        qpic = ""; // 题目图片路径
        //QString qcontent; //试题文字
        difficulty = -1; //
        Cid = -1;
        BelongId = -1;
        Answer = "";

        db = QSqlDatabase::addDatabase("QMYSQL");

        //QSqlDatabase db;
        //if (QSqlDatabase::contains("qt_sql_default_connection"))
        //    db = QSqlDatabase::database("qt_sql_default_connection");
        //else
        //    db = QSqlDatabase::addDatabase("QMYSQL");
      
        db.setHostName("localhost");         //连接数据库主机名
        db.setPort(3306);                            //连接数据库端口号
        db.setDatabaseName("db_papermaker");    //连接数据库名
        db.setUserName("root");                //数据库用户名
        db.setPassword("1234");            //数据库密码
        db.open();

       
        if (!db.open()) //判断当前db是否已经连接成功
        {
            qDebug() << "不能连接" << "connect to mysql error" << db.lastError().text();
            return;
        }
        else
        {
            qDebug() << "连接成功" << "connect to mysql OK";
            QSqlQuery query = QSqlQuery(db); //一个执行sql语句的实例，会将存储的内容放到其中
           bool  value = query.exec("select * from tb_user");
            if (value) {
                qDebug() << "query 连接成功" << "query connect to mysql OK";
            }
            //query.exec("select * from tb_user");
          /*  query.next();
            qDebug() << query.value(1).toString();*/
           
        }

            
         }
    
         QT_CATCH(Except ex) {
                if (ex == EXCEP_ZERO) QT_RETHROW;
        
    }


}

bool DataOperate::Q_Insert() //向题库表中插入数据
{
    
    //initSql();注意这里的问题，不需要再初始化类了，再初始化啥都没了
    
    //QString str = QString("inser into tb_questiondata(Qpic_data,Qdifficulty,Cid,Qbelong,Answer) values('?','?','?','?','?')");//插入一条questiondate的内容
    QString str = QString("insert into tb_questiondata(Qpic_data,Qdifficulty,Cid,Qbelong,Answer) values('%1','%2','%3','%4','%5')").arg(qpic).arg(difficulty).arg(Cid).arg(BelongId).arg(Answer);
    if (Q_isExist(qpic)) {
        return false;
    }
    else {
        query.exec(str);
        return true;
    }
  
   
    //query.addBindValue(qpic);
    //query.addBindValue(difficulty);
    //query.addBindValue(Cid);
    //query.addBindValue(BelongId);
    //query.addBindValue(Answer);
   
 /*   bool isok = query.exec();
    if (!isok) {
        qDebug() << query.lastError();
    }*/
    //return isok; //执行此命令并返回执行情况

}

int DataOperate::getCidWithName(QString ChapterNeed)
{
    //QString ChapterNeed = Chapter->currentText(); // 得到Chapter内的文本，
    int Cid;


    if (QString::compare(ChapterNeed, "必修1") == 0) {
        Cid = 1;
    }
    else if(QString::compare(ChapterNeed, "必修2") == 0){
        Cid = 2;
    }
    else if(QString::compare(ChapterNeed, "必修3") == 0) {
        Cid = 3;
    }else if(QString::compare(ChapterNeed, "必修4") == 0) {
        Cid = 4;
    }
    else if (QString::compare(ChapterNeed, "必修5") == 0) {
        Cid = 5;
    }
    else {
        Cid = -1; //如果未空或输入错误
    }
    return Cid;
}

bool DataOperate::Cid_isEmpty() {
    if (Cid == -1) {
        return false;
    }
    return true;
}

int DataOperate::getBelongWithName(QString belong) {
    //QString belong = BelongNeed->currentText(); // 得到Chapter内的文本，
    BelongId = -1;
    if (QString::compare(belong, "选择题") == 0) {
        BelongId = 1;
    }
    else if (QString::compare(belong, "填空题") == 0) {
        BelongId = 2;
    }
    else if (QString::compare(belong, "问答题") == 0) {
        BelongId = 3;
    }
    else if (QString::compare(belong, "选做题") == 0) {
        BelongId = 4;
    }
    else {
        BelongId = -1; //如果未空或输入错误
    }

    return BelongId;
}

bool DataOperate::BelongId_isEmpty()
{
    if (BelongId == -1) {
        return true;
    }
    return false;
}

void DataOperate::Fresh_Model()//此方法用于刷新当前dtop 的 数据模型
{

    model->setQuery(QString("select * from tb_questiondata"));
    //列名  
    model->setHeaderData(0, Qt::Horizontal, QObject::tr("试题编号"));
    model->setHeaderData(1, Qt::Horizontal, QObject::tr("试题路径"));
    /*model->setHeaderData(2, Qt::Horizontal, tr("试题内容"));*/
    model->setHeaderData(2, Qt::Horizontal, QObject::tr("试题难度"));
    model->setHeaderData(3, Qt::Horizontal, QObject::tr("试题章节"));
    model->setHeaderData(4, Qt::Horizontal, QObject::tr("试题类型"));
    model->setHeaderData(5, Qt::Horizontal, QObject::tr("试题答案"));
}

bool DataOperate::Q_Search(int Qno) {
    //bool value = query.exec("select * from tb_user where Qno='%1'");
    QString str = QString("select * from tb_questiondata where Qno = '%1'").arg(Qno);
    int value = query.exec(str); // 此条用于判断是否连接成功
   model->setQuery(str);
    if (value) {
        qDebug() << "query 连接数据库成功" << endl;
       
        return true;
    }
    else {
        qDebug() << "query 连接数据库失败" << endl;
        return false;
    }
        
    return false;
    
}

bool DataOperate::Q_isExist(QString PicPath) {

    QString str = QString("select * from tb_questiondata where Qpic_data='%1'").arg(PicPath);// 建立一个查询，查找query

    bool value = query.exec(str);

    return value;
    
}

bool DataOperate::Q_isExist(int Qno) {
    QString str = QString("select * from tb_questiondata where Qno='%1'").arg(Qno);// 建立一个查询，查找query

    bool value = false;
        
      query.exec(str);  //注意,query只返回执行情况，而并没有关于是否存在数据的判定，也就是说只要语句没错，这个函数总会返回true
      value = query.next(); //如果需要判定，则用next就可以了，如果一个query连一个参数都没有，那自然是空的

    return value;
}

bool DataOperate::Q_Delete(int Qno)
{
    QString Del = QString("delete from tb_questiondata where Qno=%1").arg(Qno);
    if (Q_isExist(Qno)) {
        
        return false;
    }
    else {
        return true;
    }

    return false;
}
