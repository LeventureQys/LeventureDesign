
#include <QtWidgets/QApplication>
#include "DataOperate.h"
#include "QtQManager.h"
#include "QManager.h"
#pragma execution_character_set("utf-8")

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    //DataOperate dtop; 

    //dtop.initSql(); //��ʼ����һ��dtop�������е����ݿ�������.db

    QManager qm;
    qm.show();

    //QtQManager w;
    //w.show();
    return a.exec();
}
