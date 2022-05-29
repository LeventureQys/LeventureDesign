/********************************************************************************
** Form generated from reading UI file 'QtProjiect.ui'
**
** Created by: Qt User Interface Compiler version 5.10.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_QTPROJIECT_H
#define UI_QTPROJIECT_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpacerItem>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QToolBar>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_QtProjiect
{
public:
    QWidget *centralWidget;
    QHBoxLayout *horizontalLayout_4;
    QVBoxLayout *verticalLayout_3;
    QHBoxLayout *horizontalLayout_3;
    QLabel *lab_Time;
    QLineEdit *lineEdit;
    QSpacerItem *horizontalSpacer_7;
    QSpacerItem *horizontalSpacer_8;
    QSpacerItem *horizontalSpacer_6;
    QVBoxLayout *verticalLayout_2;
    QHBoxLayout *horizontalLayout_2;
    QVBoxLayout *verticalLayout;
    QSpacerItem *verticalSpacer_4;
    QLabel *label;
    QSpacerItem *verticalSpacer_2;
    QSpacerItem *horizontalSpacer_3;
    QHBoxLayout *horizontalLayout;
    QSpacerItem *horizontalSpacer_4;
    QPushButton *Btn_Qmanager;
    QSpacerItem *horizontalSpacer;
    QSpacerItem *horizontalSpacer_2;
    QPushButton *pushButton_3;
    QSpacerItem *horizontalSpacer_5;
    QSpacerItem *verticalSpacer;
    QMenuBar *menuBar;
    QToolBar *mainToolBar;
    QStatusBar *statusBar;

    void setupUi(QMainWindow *QtProjiect)
    {
        if (QtProjiect->objectName().isEmpty())
            QtProjiect->setObjectName(QStringLiteral("QtProjiect"));
        QtProjiect->resize(480, 273);
        centralWidget = new QWidget(QtProjiect);
        centralWidget->setObjectName(QStringLiteral("centralWidget"));
        horizontalLayout_4 = new QHBoxLayout(centralWidget);
        horizontalLayout_4->setSpacing(6);
        horizontalLayout_4->setContentsMargins(11, 11, 11, 11);
        horizontalLayout_4->setObjectName(QStringLiteral("horizontalLayout_4"));
        verticalLayout_3 = new QVBoxLayout();
        verticalLayout_3->setSpacing(6);
        verticalLayout_3->setObjectName(QStringLiteral("verticalLayout_3"));
        horizontalLayout_3 = new QHBoxLayout();
        horizontalLayout_3->setSpacing(6);
        horizontalLayout_3->setObjectName(QStringLiteral("horizontalLayout_3"));
        lab_Time = new QLabel(centralWidget);
        lab_Time->setObjectName(QStringLiteral("lab_Time"));

        horizontalLayout_3->addWidget(lab_Time);

        lineEdit = new QLineEdit(centralWidget);
        lineEdit->setObjectName(QStringLiteral("lineEdit"));
        lineEdit->setMinimumSize(QSize(200, 0));
        lineEdit->setMaximumSize(QSize(200, 16777215));
        lineEdit->setReadOnly(true);

        horizontalLayout_3->addWidget(lineEdit);

        horizontalSpacer_7 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout_3->addItem(horizontalSpacer_7);

        horizontalSpacer_8 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout_3->addItem(horizontalSpacer_8);

        horizontalSpacer_6 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout_3->addItem(horizontalSpacer_6);


        verticalLayout_3->addLayout(horizontalLayout_3);

        verticalLayout_2 = new QVBoxLayout();
        verticalLayout_2->setSpacing(6);
        verticalLayout_2->setObjectName(QStringLiteral("verticalLayout_2"));
        horizontalLayout_2 = new QHBoxLayout();
        horizontalLayout_2->setSpacing(6);
        horizontalLayout_2->setObjectName(QStringLiteral("horizontalLayout_2"));
        verticalLayout = new QVBoxLayout();
        verticalLayout->setSpacing(6);
        verticalLayout->setObjectName(QStringLiteral("verticalLayout"));
        verticalSpacer_4 = new QSpacerItem(20, 13, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_4);

        label = new QLabel(centralWidget);
        label->setObjectName(QStringLiteral("label"));
        QFont font;
        font.setFamily(QStringLiteral("Arial"));
        font.setPointSize(12);
        label->setFont(font);

        verticalLayout->addWidget(label);

        verticalSpacer_2 = new QSpacerItem(20, 13, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_2);


        horizontalLayout_2->addLayout(verticalLayout);

        horizontalSpacer_3 = new QSpacerItem(328, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout_2->addItem(horizontalSpacer_3);


        verticalLayout_2->addLayout(horizontalLayout_2);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setSpacing(6);
        horizontalLayout->setObjectName(QStringLiteral("horizontalLayout"));
        horizontalSpacer_4 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer_4);

        Btn_Qmanager = new QPushButton(centralWidget);
        Btn_Qmanager->setObjectName(QStringLiteral("Btn_Qmanager"));
        Btn_Qmanager->setEnabled(true);
        Btn_Qmanager->setMinimumSize(QSize(71, 71));
        Btn_Qmanager->setMaximumSize(QSize(71, 71));

        horizontalLayout->addWidget(Btn_Qmanager);

        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer);

        horizontalSpacer_2 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer_2);

        pushButton_3 = new QPushButton(centralWidget);
        pushButton_3->setObjectName(QStringLiteral("pushButton_3"));
        pushButton_3->setMinimumSize(QSize(71, 71));
        pushButton_3->setMaximumSize(QSize(71, 71));

        horizontalLayout->addWidget(pushButton_3);

        horizontalSpacer_5 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer_5);


        verticalLayout_2->addLayout(horizontalLayout);

        verticalSpacer = new QSpacerItem(20, 13, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout_2->addItem(verticalSpacer);


        verticalLayout_3->addLayout(verticalLayout_2);


        horizontalLayout_4->addLayout(verticalLayout_3);

        QtProjiect->setCentralWidget(centralWidget);
        menuBar = new QMenuBar(QtProjiect);
        menuBar->setObjectName(QStringLiteral("menuBar"));
        menuBar->setGeometry(QRect(0, 0, 480, 23));
        QtProjiect->setMenuBar(menuBar);
        mainToolBar = new QToolBar(QtProjiect);
        mainToolBar->setObjectName(QStringLiteral("mainToolBar"));
        QtProjiect->addToolBar(Qt::TopToolBarArea, mainToolBar);
        statusBar = new QStatusBar(QtProjiect);
        statusBar->setObjectName(QStringLiteral("statusBar"));
        QtProjiect->setStatusBar(statusBar);

        retranslateUi(QtProjiect);

        QMetaObject::connectSlotsByName(QtProjiect);
    } // setupUi

    void retranslateUi(QMainWindow *QtProjiect)
    {
        QtProjiect->setWindowTitle(QApplication::translate("QtProjiect", "\351\242\230\345\272\223\347\256\241\347\220\206", nullptr));
        lab_Time->setText(QApplication::translate("QtProjiect", "\345\275\223\345\211\215\346\227\266\351\227\264:", nullptr));
        label->setText(QApplication::translate("QtProjiect", "\346\254\242\350\277\216\346\202\250\357\274\214", nullptr));
        Btn_Qmanager->setText(QApplication::translate("QtProjiect", "\351\242\230\345\272\223\347\256\241\347\220\206", nullptr));
        pushButton_3->setText(QApplication::translate("QtProjiect", "\350\257\225\345\215\267\346\237\245\347\234\213", nullptr));
    } // retranslateUi

};

namespace Ui {
    class QtProjiect: public Ui_QtProjiect {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_QTPROJIECT_H
