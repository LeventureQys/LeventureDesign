#pragma once

#include <QWidget>
#include "ui_Search.h"

class Search : public QWidget
{
	Q_OBJECT

public:
	Search(QWidget *parent = Q_NULLPTR);
	~Search();

private:
	Ui::Search ui;
};
