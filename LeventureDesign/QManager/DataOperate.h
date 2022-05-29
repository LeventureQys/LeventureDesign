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
class DataOperate{ //这个类命名为是DataOperate

public :
	QSqlDatabase db; //这是我们用来处理数据库的基本对象，在initSql()中就已经初始化了db了，在具体后续的操作中，可以直接操作dtop.db对象
	void initSql(); 
	enum Except { EXCEP_ZERO, EXCEP_ONE };
	QSqlQueryModel* model = new QSqlQueryModel();// 一个将数据插入到QTabaleView的对象

	QSqlQuery query; //用来执行sql语句的对象


	QString qno = "";; //试题编号
	QString qpic = "";; // 题目图片路径
	//QString qcontent; //试题文字
	qint32 difficulty = -1; //
	qint32 Cid = -1;
	qint32 BelongId = -1;
	QString Answer = "";

	bool Q_Insert();
	int getCidWithName(QString ChapterNeed); // 输入一个QCombox类成员，返回一个Cid，目前只有五本书

	int getBelongWithName(QString belong);//输入一个QCombox类成员，返回QBelong 目前四种类型

	bool Cid_isEmpty(); //检查Cid是否未空
	bool BelongId_isEmpty(); // 检查BelongId是否未空

	void Fresh_Model();

	bool Q_Search(int Qno); // 输入Qno查询题目，修改当前dtop中的query

	bool Q_isExist(QString PicPath); // 此方法用于检查当前图片是否已经上传过数据库，
	bool Q_isExist(int Qno); // 通过qno查找是否存在题目的重载函数

	bool Q_Delete(int Qno);
};

