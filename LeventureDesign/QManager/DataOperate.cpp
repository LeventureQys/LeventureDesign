#include "DataOperate.h"



void DataOperate::initSql() //��ʼ�����ݿ⣬����һ��db�������������ݿ�
{
    QT_TRY{

        qno = ""; //������
        qpic = ""; // ��ĿͼƬ·��
        //QString qcontent; //��������
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
      
        db.setHostName("localhost");         //�������ݿ�������
        db.setPort(3306);                            //�������ݿ�˿ں�
        db.setDatabaseName("db_papermaker");    //�������ݿ���
        db.setUserName("root");                //���ݿ��û���
        db.setPassword("1234");            //���ݿ�����
        db.open();

       
        if (!db.open()) //�жϵ�ǰdb�Ƿ��Ѿ����ӳɹ�
        {
            qDebug() << "��������" << "connect to mysql error" << db.lastError().text();
            return;
        }
        else
        {
            qDebug() << "���ӳɹ�" << "connect to mysql OK";
            QSqlQuery query = QSqlQuery(db); //һ��ִ��sql����ʵ�����Ὣ�洢�����ݷŵ�����
           bool  value = query.exec("select * from tb_user");
            if (value) {
                qDebug() << "query ���ӳɹ�" << "query connect to mysql OK";
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

bool DataOperate::Q_Insert() //�������в�������
{
    
    //initSql();ע����������⣬����Ҫ�ٳ�ʼ�����ˣ��ٳ�ʼ��ɶ��û��
    
    //QString str = QString("inser into tb_questiondata(Qpic_data,Qdifficulty,Cid,Qbelong,Answer) values('?','?','?','?','?')");//����һ��questiondate������
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
    //return isok; //ִ�д��������ִ�����

}

int DataOperate::getCidWithName(QString ChapterNeed)
{
    //QString ChapterNeed = Chapter->currentText(); // �õ�Chapter�ڵ��ı���
    int Cid;


    if (QString::compare(ChapterNeed, "����1") == 0) {
        Cid = 1;
    }
    else if(QString::compare(ChapterNeed, "����2") == 0){
        Cid = 2;
    }
    else if(QString::compare(ChapterNeed, "����3") == 0) {
        Cid = 3;
    }else if(QString::compare(ChapterNeed, "����4") == 0) {
        Cid = 4;
    }
    else if (QString::compare(ChapterNeed, "����5") == 0) {
        Cid = 5;
    }
    else {
        Cid = -1; //���δ�ջ��������
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
    //QString belong = BelongNeed->currentText(); // �õ�Chapter�ڵ��ı���
    BelongId = -1;
    if (QString::compare(belong, "ѡ����") == 0) {
        BelongId = 1;
    }
    else if (QString::compare(belong, "�����") == 0) {
        BelongId = 2;
    }
    else if (QString::compare(belong, "�ʴ���") == 0) {
        BelongId = 3;
    }
    else if (QString::compare(belong, "ѡ����") == 0) {
        BelongId = 4;
    }
    else {
        BelongId = -1; //���δ�ջ��������
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

void DataOperate::Fresh_Model()//�˷�������ˢ�µ�ǰdtop �� ����ģ��
{

    model->setQuery(QString("select * from tb_questiondata"));
    //����  
    model->setHeaderData(0, Qt::Horizontal, QObject::tr("������"));
    model->setHeaderData(1, Qt::Horizontal, QObject::tr("����·��"));
    /*model->setHeaderData(2, Qt::Horizontal, tr("��������"));*/
    model->setHeaderData(2, Qt::Horizontal, QObject::tr("�����Ѷ�"));
    model->setHeaderData(3, Qt::Horizontal, QObject::tr("�����½�"));
    model->setHeaderData(4, Qt::Horizontal, QObject::tr("��������"));
    model->setHeaderData(5, Qt::Horizontal, QObject::tr("�����"));
}

bool DataOperate::Q_Search(int Qno) {
    //bool value = query.exec("select * from tb_user where Qno='%1'");
    QString str = QString("select * from tb_questiondata where Qno = '%1'").arg(Qno);
    int value = query.exec(str); // ���������ж��Ƿ����ӳɹ�
   model->setQuery(str);
    if (value) {
        qDebug() << "query �������ݿ�ɹ�" << endl;
       
        return true;
    }
    else {
        qDebug() << "query �������ݿ�ʧ��" << endl;
        return false;
    }
        
    return false;
    
}

bool DataOperate::Q_isExist(QString PicPath) {

    QString str = QString("select * from tb_questiondata where Qpic_data='%1'").arg(PicPath);// ����һ����ѯ������query

    bool value = query.exec(str);

    return value;
    
}

bool DataOperate::Q_isExist(int Qno) {
    QString str = QString("select * from tb_questiondata where Qno='%1'").arg(Qno);// ����һ����ѯ������query

    bool value = false;
        
      query.exec(str);  //ע��,queryֻ����ִ�����������û�й����Ƿ�������ݵ��ж���Ҳ����˵ֻҪ���û����������ܻ᷵��true
      value = query.next(); //�����Ҫ�ж�������next�Ϳ����ˣ����һ��query��һ��������û�У�����Ȼ�ǿյ�

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
