#include "QtQManager.h"

QtQManager::QtQManager(QWidget *parent)
	: QWidget(parent)
{
	ui.setupUi(this);

	// �˴���ʼ��һ����ʱ������lineEdit����չʾ��ǰ��ʱ��
	timer1 = new QTimer(this); //�½�һ����ʱ��
	connect(timer1, SIGNAL(timeout()), this, SLOT(TimerFresh())); //timer1��timeout�¼�����TimerFresh����
	timer1->setTimerType(Qt::PreciseTimer);
	timer1->start(100);

	this->setFixedSize(480, 270);
}

void QtQManager::TimerFresh() //��ˢ��ʱ������ݷŵ�һ���ۺ����ڲ�������Ȼ����Ҳ���Դ���һ��time����Ӧ�û�ʡ�ռ�
{
	QLineEdit* lE = this->findChild<QLineEdit*>("lineEdit");
	QDateTime time1 = QDateTime::currentDateTime(); //��ȡ��ǰʱ��
	QString str = time1.toString("yyyy-MM-dd hh:mm:ss dddd");
	lE->setText(str);
}


QtQManager::~QtQManager()
{
}
