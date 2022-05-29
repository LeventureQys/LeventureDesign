#pragma once

#include <QWidget>
#include "ui_QtQManager.h"
#include <qdatetime.h>
#include<qtimer.h> 


class QtQManager : public QWidget
{
	Q_OBJECT

public:

	QtQManager(QWidget *parent = Q_NULLPTR);
	~QtQManager();

public slots:
	void TimerFresh();

private:

	Ui::QtQManager ui;
	QTimer* timer1;
};
