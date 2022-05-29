/********************************************************************************
** Form generated from reading UI file 'QtQManager.ui'
**
** Created by: Qt User Interface Compiler version 5.10.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_QTQMANAGER_H
#define UI_QTQMANAGER_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpacerItem>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_QtQManager
{
public:
    QWidget *layoutWidget;
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

    void setupUi(QWidget *QtQManager)
    {
        if (QtQManager->objectName().isEmpty())
            QtQManager->setObjectName(QStringLiteral("QtQManager"));
        QtQManager->resize(470, 200);
        QtQManager->setMinimumSize(QSize(470, 200));
        QtQManager->setMaximumSize(QSize(470, 200));
        layoutWidget = new QWidget(QtQManager);
        layoutWidget->setObjectName(QStringLiteral("layoutWidget"));
        layoutWidget->setGeometry(QRect(0, 0, 464, 190));
        verticalLayout_3 = new QVBoxLayout(layoutWidget);
        verticalLayout_3->setSpacing(6);
        verticalLayout_3->setContentsMargins(11, 11, 11, 11);
        verticalLayout_3->setObjectName(QStringLiteral("verticalLayout_3"));
        verticalLayout_3->setContentsMargins(0, 0, 0, 0);
        horizontalLayout_3 = new QHBoxLayout();
        horizontalLayout_3->setSpacing(6);
        horizontalLayout_3->setObjectName(QStringLiteral("horizontalLayout_3"));
        lab_Time = new QLabel(layoutWidget);
        lab_Time->setObjectName(QStringLiteral("lab_Time"));

        horizontalLayout_3->addWidget(lab_Time);

        lineEdit = new QLineEdit(layoutWidget);
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

        label = new QLabel(layoutWidget);
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

        Btn_Qmanager = new QPushButton(layoutWidget);
        Btn_Qmanager->setObjectName(QStringLiteral("Btn_Qmanager"));
        Btn_Qmanager->setEnabled(true);
        Btn_Qmanager->setMinimumSize(QSize(71, 71));
        Btn_Qmanager->setMaximumSize(QSize(71, 71));

        horizontalLayout->addWidget(Btn_Qmanager);

        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer);

        horizontalSpacer_2 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer_2);

        pushButton_3 = new QPushButton(layoutWidget);
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


        retranslateUi(QtQManager);

        QMetaObject::connectSlotsByName(QtQManager);
    } // setupUi

    void retranslateUi(QWidget *QtQManager)
    {
        QtQManager->setWindowTitle(QApplication::translate("QtQManager", "QtQManager", nullptr));
        lab_Time->setText(QApplication::translate("QtQManager", "\345\275\223\345\211\215\346\227\266\351\227\264:", nullptr));
        label->setText(QApplication::translate("QtQManager", "\346\254\242\350\277\216\346\202\250\357\274\214", nullptr));
        Btn_Qmanager->setText(QApplication::translate("QtQManager", "\351\242\230\345\272\223\347\256\241\347\220\206", nullptr));
        pushButton_3->setText(QApplication::translate("QtQManager", "\350\257\225\345\215\267\346\237\245\347\234\213", nullptr));
    } // retranslateUi

};

namespace Ui {
    class QtQManager: public Ui_QtQManager {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_QTQMANAGER_H
