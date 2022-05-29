#include "sqlTesting.h"

sqlTesting::sqlTesting(QWidget *parent)
    : QMainWindow(parent)
{
    ui.setupUi(this);
    qDebug() << QSqlDatabase::drivers();
   
}
