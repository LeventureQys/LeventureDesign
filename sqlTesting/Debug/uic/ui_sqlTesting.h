/********************************************************************************
** Form generated from reading UI file 'sqlTesting.ui'
**
** Created by: Qt User Interface Compiler version 5.10.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SQLTESTING_H
#define UI_SQLTESTING_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QToolBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_sqlTestingClass
{
public:
    QWidget *centralWidget;
    QMenuBar *menuBar;
    QToolBar *mainToolBar;
    QStatusBar *statusBar;

    void setupUi(QMainWindow *sqlTestingClass)
    {
        if (sqlTestingClass->objectName().isEmpty())
            sqlTestingClass->setObjectName(QStringLiteral("sqlTestingClass"));
        sqlTestingClass->resize(600, 400);
        centralWidget = new QWidget(sqlTestingClass);
        centralWidget->setObjectName(QStringLiteral("centralWidget"));
        sqlTestingClass->setCentralWidget(centralWidget);
        menuBar = new QMenuBar(sqlTestingClass);
        menuBar->setObjectName(QStringLiteral("menuBar"));
        menuBar->setGeometry(QRect(0, 0, 600, 23));
        sqlTestingClass->setMenuBar(menuBar);
        mainToolBar = new QToolBar(sqlTestingClass);
        mainToolBar->setObjectName(QStringLiteral("mainToolBar"));
        sqlTestingClass->addToolBar(Qt::TopToolBarArea, mainToolBar);
        statusBar = new QStatusBar(sqlTestingClass);
        statusBar->setObjectName(QStringLiteral("statusBar"));
        sqlTestingClass->setStatusBar(statusBar);

        retranslateUi(sqlTestingClass);

        QMetaObject::connectSlotsByName(sqlTestingClass);
    } // setupUi

    void retranslateUi(QMainWindow *sqlTestingClass)
    {
        sqlTestingClass->setWindowTitle(QApplication::translate("sqlTestingClass", "\346\265\213\350\257\225\347\252\227\345\217\243", nullptr));
    } // retranslateUi

};

namespace Ui {
    class sqlTestingClass: public Ui_sqlTestingClass {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SQLTESTING_H
