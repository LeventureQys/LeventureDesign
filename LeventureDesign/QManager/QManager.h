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

	void on_btn_Fresh_clicked(); // ���ˢ�°�ť
	void on_btn_Insert_clicked(); //������밴ť
	void on_btn_Search_clicked(); // �����ѯ��ť��������Ų�����Ŀ
	void on_btn_Delete_clicked(); // ���ɾ����ť���������ɾ����Ŀ
private:
	Ui::QManager ui;
	DataOperate dtop;
	

private slots:
	//void on_Btn_Fresh_clicked(); // ���ˢ�°�ť
};
