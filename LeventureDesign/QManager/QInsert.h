#pragma once

#include <QWidget>
#include "ui_QInsert.h"
#include "qfile.h"
#include "qfiledialog.h"
#include "qstring.h"
#include"qdir.h"
#include"DataOperate.h"
class QInsert : public QWidget
{
	Q_OBJECT

public:
	QInsert(DataOperate dt,QWidget *parent = Q_NULLPTR);

	~QInsert();
	QString picPath;
	DataOperate dtop;


private:
	Ui::QInsert ui;
private slots:
	void on_btn_SelectPic_clicked();
	void on_btn_Insert_clicked();
	void on_comb_belong_currentIndexChanged(int e);
	void on_btn_SelectAns_clicked(); //¸ølineÉÏ´ð°¸
};
