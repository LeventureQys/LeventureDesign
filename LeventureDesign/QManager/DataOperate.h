#pragma once


#include <QTextCodec>
//#include <QMessageBox>
#include <qmessagebox.h>
#include <QDebug>
#include <QSqlDatabase>
#include <QMessageBox>
#include <qsqlerror.h>
#include <qexception.h>
#include <qsqlquery.h>
#include <qsqlquerymodel.h>
#include<qstring.h>
#include <qcombobox.h>
#include <exception> 
class DataOperate{ //���������Ϊ��DataOperate

public :
	QSqlDatabase db; //�������������������ݿ�Ļ���������initSql()�о��Ѿ���ʼ����db�ˣ��ھ�������Ĳ����У�����ֱ�Ӳ���dtop.db����
	void initSql(); 
	enum Except { EXCEP_ZERO, EXCEP_ONE };
	QSqlQueryModel* model = new QSqlQueryModel();// һ�������ݲ��뵽QTabaleView�Ķ���

	QSqlQuery query; //����ִ��sql���Ķ���


	QString qno = "";; //������
	QString qpic = "";; // ��ĿͼƬ·��
	//QString qcontent; //��������
	qint32 difficulty = -1; //
	qint32 Cid = -1;
	qint32 BelongId = -1;
	QString Answer = "";

	bool Q_Insert();
	int getCidWithName(QString ChapterNeed); // ����һ��QCombox���Ա������һ��Cid��Ŀǰֻ���屾��

	int getBelongWithName(QString belong);//����һ��QCombox���Ա������QBelong Ŀǰ��������

	bool Cid_isEmpty(); //���Cid�Ƿ�δ��
	bool BelongId_isEmpty(); // ���BelongId�Ƿ�δ��

	void Fresh_Model();

	bool Q_Search(int Qno); // ����Qno��ѯ��Ŀ���޸ĵ�ǰdtop�е�query

	bool Q_isExist(QString PicPath); // �˷������ڼ�鵱ǰͼƬ�Ƿ��Ѿ��ϴ������ݿ⣬
	bool Q_isExist(int Qno); // ͨ��qno�����Ƿ������Ŀ�����غ���

	bool Q_Delete(int Qno);
};

