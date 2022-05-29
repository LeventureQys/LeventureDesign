/********************************************************************************
** Form generated from reading UI file 'QManager.ui'
**
** Created by: Qt User Interface Compiler version 5.10.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_QMANAGER_H
#define UI_QMANAGER_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QTableView>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_QManager
{
public:
    QAction *actionSave;
    QWidget *layoutWidget;
    QHBoxLayout *horizontalLayout;
    QTableView *tableView;
    QVBoxLayout *verticalLayout;
    QPushButton *btn_Fresh;
    QPushButton *btn_Insert;
    QPushButton *btn_Delete;
    QPushButton *btn_Search;
    QPushButton *btn_Change;

    void setupUi(QWidget *QManager)
    {
        if (QManager->objectName().isEmpty())
            QManager->setObjectName(QStringLiteral("QManager"));
        QManager->resize(724, 382);
        actionSave = new QAction(QManager);
        actionSave->setObjectName(QStringLiteral("actionSave"));
        QIcon icon;
        icon.addFile(QString::fromUtf8("C:/Users/Administrator/Desktop/\347\273\230\345\233\276-\345\256\236\344\276\213/\347\231\273\351\231\206\347\252\227\344\275\223\345\256\236\347\216\260\346\265\201\347\250\213.png"), QSize(), QIcon::Normal, QIcon::Off);
        actionSave->setIcon(icon);
        layoutWidget = new QWidget(QManager);
        layoutWidget->setObjectName(QStringLiteral("layoutWidget"));
        layoutWidget->setGeometry(QRect(0, 0, 721, 383));
        horizontalLayout = new QHBoxLayout(layoutWidget);
        horizontalLayout->setSpacing(6);
        horizontalLayout->setContentsMargins(11, 11, 11, 11);
        horizontalLayout->setObjectName(QStringLiteral("horizontalLayout"));
        horizontalLayout->setContentsMargins(0, 0, 0, 0);
        tableView = new QTableView(layoutWidget);
        tableView->setObjectName(QStringLiteral("tableView"));

        horizontalLayout->addWidget(tableView);

        verticalLayout = new QVBoxLayout();
        verticalLayout->setSpacing(6);
        verticalLayout->setObjectName(QStringLiteral("verticalLayout"));
        btn_Fresh = new QPushButton(layoutWidget);
        btn_Fresh->setObjectName(QStringLiteral("btn_Fresh"));
        btn_Fresh->setMinimumSize(QSize(71, 71));
        btn_Fresh->setMaximumSize(QSize(71, 71));

        verticalLayout->addWidget(btn_Fresh);

        btn_Insert = new QPushButton(layoutWidget);
        btn_Insert->setObjectName(QStringLiteral("btn_Insert"));
        btn_Insert->setMinimumSize(QSize(71, 71));
        btn_Insert->setMaximumSize(QSize(71, 71));

        verticalLayout->addWidget(btn_Insert);

        btn_Delete = new QPushButton(layoutWidget);
        btn_Delete->setObjectName(QStringLiteral("btn_Delete"));
        btn_Delete->setMinimumSize(QSize(71, 71));
        btn_Delete->setMaximumSize(QSize(71, 71));

        verticalLayout->addWidget(btn_Delete);

        btn_Search = new QPushButton(layoutWidget);
        btn_Search->setObjectName(QStringLiteral("btn_Search"));
        btn_Search->setMinimumSize(QSize(71, 71));
        btn_Search->setMaximumSize(QSize(71, 71));

        verticalLayout->addWidget(btn_Search);

        btn_Change = new QPushButton(layoutWidget);
        btn_Change->setObjectName(QStringLiteral("btn_Change"));
        btn_Change->setMinimumSize(QSize(71, 71));
        btn_Change->setMaximumSize(QSize(71, 71));

        verticalLayout->addWidget(btn_Change);


        horizontalLayout->addLayout(verticalLayout);


        retranslateUi(QManager);

        QMetaObject::connectSlotsByName(QManager);
    } // setupUi

    void retranslateUi(QWidget *QManager)
    {
        QManager->setWindowTitle(QApplication::translate("QManager", "\351\242\230\345\272\223\347\256\241\347\220\206", nullptr));
        actionSave->setText(QApplication::translate("QManager", "\344\277\235\345\255\230", nullptr));
#ifndef QT_NO_TOOLTIP
        actionSave->setToolTip(QApplication::translate("QManager", "Save", nullptr));
#endif // QT_NO_TOOLTIP
#ifndef QT_NO_SHORTCUT
        actionSave->setShortcut(QApplication::translate("QManager", "Ctrl+S", nullptr));
#endif // QT_NO_SHORTCUT
        btn_Fresh->setText(QApplication::translate("QManager", "\345\210\267\346\226\260\351\242\230\345\272\223", nullptr));
        btn_Insert->setText(QApplication::translate("QManager", "\345\242\236\345\212\240\350\257\225\351\242\230", nullptr));
        btn_Delete->setText(QApplication::translate("QManager", "\345\210\240\351\231\244\350\257\225\351\242\230", nullptr));
        btn_Search->setText(QApplication::translate("QManager", "\346\237\245\350\257\242\350\257\225\351\242\230", nullptr));
        btn_Change->setText(QApplication::translate("QManager", "\344\277\256\346\224\271\350\257\225\351\242\230", nullptr));
    } // retranslateUi

};

namespace Ui {
    class QManager: public Ui_QManager {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_QMANAGER_H
