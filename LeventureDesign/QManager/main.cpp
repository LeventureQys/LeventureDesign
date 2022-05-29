
#include <QtWidgets/QApplication>
#include "DataOperate.h"
#include "QtQManager.h"
#include "QManager.h"
#pragma execution_character_set("utf-8")

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    //DataOperate dtop; 

    //dtop.initSql(); //初始化了一个dtop对象，其中的数据库类型是.db

    QManager qm;
    qm.show();

    //QtQManager w;
    //w.show();
    return a.exec();
}
