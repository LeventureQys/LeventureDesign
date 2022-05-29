#pragma once

#include <QWidget>
#include "ui_QManager.h"
#include "DataOperate.h"
#include"qsqlquerymodel.h"
#include "QInsert.h"
#include "qinputdialog.h"
class QManager : public QWidget
{
	Q_OBJECT

public:

	QManager(QWidget *parent = Q_NULLPTR);
	/*QInsert insert;*/
	~QManager();
	//QSqlQueryModel *model = new QSqlQueryModel(ui.tableView);
public slots:

	void on_btn_Fresh_clicked(); // 点击刷新按钮
	void on_btn_Insert_clicked(); //点击插入按钮
	void on_btn_Search_clicked(); // 点击查询按钮，根据题号查找题目
	void on_btn_Delete_clicked(); // 点击删除按钮，根据题号删除题目
private:
	Ui::QManager ui;
	DataOperate dtop;
	

private slots:
	//void on_Btn_Fresh_clicked(); // 点击刷新按钮
};
