#include "QtQManager.h"

QtQManager::QtQManager(QWidget *parent)
	: QWidget(parent)
{
	ui.setupUi(this);

	// 此处初始化一个定时器，令lineEdit可以展示当前的时间
	timer1 = new QTimer(this); //新建一个定时器
	connect(timer1, SIGNAL(timeout()), this, SLOT(TimerFresh())); //timer1的timeout事件触发TimerFresh函数
	timer1->setTimerType(Qt::PreciseTimer);
	timer1->start(100);

	this->setFixedSize(480, 270);
}

void QtQManager::TimerFresh() //将刷新时间的内容放到一个槽函数内操作，当然这里也可以传入一个time这样应该会省空间
{
	QLineEdit* lE = this->findChild<QLineEdit*>("lineEdit");
	QDateTime time1 = QDateTime::currentDateTime(); //获取当前时间
	QString str = time1.toString("yyyy-MM-dd hh:mm:ss dddd");
	lE->setText(str);
}


QtQManager::~QtQManager()
{
}
