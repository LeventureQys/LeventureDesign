#pragma once

#include <QtWidgets/QMainWindow>
#include "ui_sqlTesting.h"
#include <QtSql/QSqlDatabase>
#include "qdebug.h"
#include "QtSql/qsqldatabase.h"
class sqlTesting : public QMainWindow
{
    Q_OBJECT

public:
    sqlTesting(QWidget *parent = Q_NULLPTR);

private:
    Ui::sqlTestingClass ui;
};
