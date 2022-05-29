/********************************************************************************
** Form generated from reading UI file 'QInsert.ui'
**
** Created by: Qt User Interface Compiler version 5.10.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_QINSERT_H
#define UI_QINSERT_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpacerItem>
#include <QtWidgets/QSpinBox>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_QInsert
{
public:
    QWidget *layoutWidget;
    QVBoxLayout *verticalLayout;
    QHBoxLayout *horizontalLayout;
    QLabel *label;
    QPushButton *btn_SelectPic;
    QLineEdit *line_DataPath;
    QSpacerItem *verticalSpacer;
    QHBoxLayout *horizontalLayout_2;
    QLabel *label_2;
    QSpinBox *comb_difficulty;
    QSpacerItem *verticalSpacer_2;
    QHBoxLayout *horizontalLayout_3;
    QLabel *label_3;
    QComboBox *comb_Chapter;
    QSpacerItem *verticalSpacer_3;
    QHBoxLayout *horizontalLayout_4;
    QLabel *label_4;
    QComboBox *comb_belong;
    QSpacerItem *verticalSpacer_4;
    QHBoxLayout *horizontalLayout_5;
    QLabel *lab_Answer;
    QComboBox *comb_Answer;
    QSpacerItem *verticalSpacer_5;
    QHBoxLayout *horizontalLayout_6;
    QPushButton *btn_SelectAns;
    QLineEdit *line_Answer;
    QPushButton *btn_Insert;

    void setupUi(QWidget *QInsert)
    {
        if (QInsert->objectName().isEmpty())
            QInsert->setObjectName(QStringLiteral("QInsert"));
        QInsert->resize(338, 297);
        layoutWidget = new QWidget(QInsert);
        layoutWidget->setObjectName(QStringLiteral("layoutWidget"));
        layoutWidget->setGeometry(QRect(20, 10, 300, 263));
        verticalLayout = new QVBoxLayout(layoutWidget);
        verticalLayout->setSpacing(6);
        verticalLayout->setContentsMargins(11, 11, 11, 11);
        verticalLayout->setObjectName(QStringLiteral("verticalLayout"));
        verticalLayout->setContentsMargins(0, 0, 0, 0);
        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setSpacing(6);
        horizontalLayout->setObjectName(QStringLiteral("horizontalLayout"));
        label = new QLabel(layoutWidget);
        label->setObjectName(QStringLiteral("label"));

        horizontalLayout->addWidget(label);

        btn_SelectPic = new QPushButton(layoutWidget);
        btn_SelectPic->setObjectName(QStringLiteral("btn_SelectPic"));
        btn_SelectPic->setMinimumSize(QSize(50, 0));
        btn_SelectPic->setMaximumSize(QSize(50, 16777215));

        horizontalLayout->addWidget(btn_SelectPic);

        line_DataPath = new QLineEdit(layoutWidget);
        line_DataPath->setObjectName(QStringLiteral("line_DataPath"));
        line_DataPath->setReadOnly(true);

        horizontalLayout->addWidget(line_DataPath);


        verticalLayout->addLayout(horizontalLayout);

        verticalSpacer = new QSpacerItem(298, 13, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer);

        horizontalLayout_2 = new QHBoxLayout();
        horizontalLayout_2->setSpacing(6);
        horizontalLayout_2->setObjectName(QStringLiteral("horizontalLayout_2"));
        label_2 = new QLabel(layoutWidget);
        label_2->setObjectName(QStringLiteral("label_2"));

        horizontalLayout_2->addWidget(label_2);

        comb_difficulty = new QSpinBox(layoutWidget);
        comb_difficulty->setObjectName(QStringLiteral("comb_difficulty"));
        comb_difficulty->setReadOnly(false);
        comb_difficulty->setMinimum(1);
        comb_difficulty->setMaximum(10);

        horizontalLayout_2->addWidget(comb_difficulty);


        verticalLayout->addLayout(horizontalLayout_2);

        verticalSpacer_2 = new QSpacerItem(298, 13, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_2);

        horizontalLayout_3 = new QHBoxLayout();
        horizontalLayout_3->setSpacing(6);
        horizontalLayout_3->setObjectName(QStringLiteral("horizontalLayout_3"));
        label_3 = new QLabel(layoutWidget);
        label_3->setObjectName(QStringLiteral("label_3"));

        horizontalLayout_3->addWidget(label_3);

        comb_Chapter = new QComboBox(layoutWidget);
        comb_Chapter->addItem(QString());
        comb_Chapter->addItem(QString());
        comb_Chapter->addItem(QString());
        comb_Chapter->addItem(QString());
        comb_Chapter->addItem(QString());
        comb_Chapter->setObjectName(QStringLiteral("comb_Chapter"));

        horizontalLayout_3->addWidget(comb_Chapter);


        verticalLayout->addLayout(horizontalLayout_3);

        verticalSpacer_3 = new QSpacerItem(298, 13, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_3);

        horizontalLayout_4 = new QHBoxLayout();
        horizontalLayout_4->setSpacing(6);
        horizontalLayout_4->setObjectName(QStringLiteral("horizontalLayout_4"));
        label_4 = new QLabel(layoutWidget);
        label_4->setObjectName(QStringLiteral("label_4"));

        horizontalLayout_4->addWidget(label_4);

        comb_belong = new QComboBox(layoutWidget);
        comb_belong->addItem(QString());
        comb_belong->addItem(QString());
        comb_belong->addItem(QString());
        comb_belong->addItem(QString());
        comb_belong->setObjectName(QStringLiteral("comb_belong"));

        horizontalLayout_4->addWidget(comb_belong);


        verticalLayout->addLayout(horizontalLayout_4);

        verticalSpacer_4 = new QSpacerItem(298, 13, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_4);

        horizontalLayout_5 = new QHBoxLayout();
        horizontalLayout_5->setSpacing(6);
        horizontalLayout_5->setObjectName(QStringLiteral("horizontalLayout_5"));
        lab_Answer = new QLabel(layoutWidget);
        lab_Answer->setObjectName(QStringLiteral("lab_Answer"));
        lab_Answer->setEnabled(true);

        horizontalLayout_5->addWidget(lab_Answer);

        comb_Answer = new QComboBox(layoutWidget);
        comb_Answer->addItem(QString());
        comb_Answer->addItem(QString());
        comb_Answer->addItem(QString());
        comb_Answer->addItem(QString());
        comb_Answer->setObjectName(QStringLiteral("comb_Answer"));
        comb_Answer->setEnabled(true);

        horizontalLayout_5->addWidget(comb_Answer);


        verticalLayout->addLayout(horizontalLayout_5);

        verticalSpacer_5 = new QSpacerItem(298, 13, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_5);

        horizontalLayout_6 = new QHBoxLayout();
        horizontalLayout_6->setSpacing(6);
        horizontalLayout_6->setObjectName(QStringLiteral("horizontalLayout_6"));
        btn_SelectAns = new QPushButton(layoutWidget);
        btn_SelectAns->setObjectName(QStringLiteral("btn_SelectAns"));
        btn_SelectAns->setEnabled(false);
        btn_SelectAns->setMinimumSize(QSize(50, 0));
        btn_SelectAns->setMaximumSize(QSize(50, 16777215));

        horizontalLayout_6->addWidget(btn_SelectAns);

        line_Answer = new QLineEdit(layoutWidget);
        line_Answer->setObjectName(QStringLiteral("line_Answer"));
        line_Answer->setEnabled(false);

        horizontalLayout_6->addWidget(line_Answer);


        verticalLayout->addLayout(horizontalLayout_6);

        btn_Insert = new QPushButton(layoutWidget);
        btn_Insert->setObjectName(QStringLiteral("btn_Insert"));

        verticalLayout->addWidget(btn_Insert);


        retranslateUi(QInsert);

        QMetaObject::connectSlotsByName(QInsert);
    } // setupUi

    void retranslateUi(QWidget *QInsert)
    {
        QInsert->setWindowTitle(QApplication::translate("QInsert", "\346\217\222\345\205\245\350\257\225\351\242\230", nullptr));
        label->setText(QApplication::translate("QInsert", "\350\257\225\351\242\230\345\233\276\347\211\207:", nullptr));
        btn_SelectPic->setText(QApplication::translate("QInsert", "\346\265\217\350\247\210...", nullptr));
        label_2->setText(QApplication::translate("QInsert", "\350\257\225\351\242\230\351\232\276\345\272\246:", nullptr));
        label_3->setText(QApplication::translate("QInsert", "\350\257\225\351\242\230\347\253\240\350\212\202:", nullptr));
        comb_Chapter->setItemText(0, QApplication::translate("QInsert", "\345\277\205\344\277\2561", nullptr));
        comb_Chapter->setItemText(1, QApplication::translate("QInsert", "\345\277\205\344\277\2562", nullptr));
        comb_Chapter->setItemText(2, QApplication::translate("QInsert", "\345\277\205\344\277\2563", nullptr));
        comb_Chapter->setItemText(3, QApplication::translate("QInsert", "\345\277\205\344\277\2564", nullptr));
        comb_Chapter->setItemText(4, QApplication::translate("QInsert", "\345\277\205\344\277\2565", nullptr));

        label_4->setText(QApplication::translate("QInsert", "\350\257\225\351\242\230\347\261\273\345\236\213:", nullptr));
        comb_belong->setItemText(0, QApplication::translate("QInsert", "\351\200\211\346\213\251\351\242\230", nullptr));
        comb_belong->setItemText(1, QApplication::translate("QInsert", "\345\241\253\347\251\272\351\242\230", nullptr));
        comb_belong->setItemText(2, QApplication::translate("QInsert", "\351\227\256\347\255\224\351\242\230", nullptr));
        comb_belong->setItemText(3, QApplication::translate("QInsert", "\351\200\211\345\201\232\351\242\230", nullptr));

        lab_Answer->setText(QApplication::translate("QInsert", "\347\255\224\346\241\210:", nullptr));
        comb_Answer->setItemText(0, QApplication::translate("QInsert", "A", nullptr));
        comb_Answer->setItemText(1, QApplication::translate("QInsert", "B", nullptr));
        comb_Answer->setItemText(2, QApplication::translate("QInsert", "C", nullptr));
        comb_Answer->setItemText(3, QApplication::translate("QInsert", "D", nullptr));

        btn_SelectAns->setText(QApplication::translate("QInsert", "\346\265\217\350\247\210...", nullptr));
        btn_Insert->setText(QApplication::translate("QInsert", "\346\217\220\344\272\244", nullptr));
    } // retranslateUi

};

namespace Ui {
    class QInsert: public Ui_QInsert {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_QINSERT_H
