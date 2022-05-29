#include "QInsert.h"

QInsert::QInsert(DataOperate dt,QWidget *parent)
	: QWidget(parent)
{
	ui.setupUi(this);
	 // ��ʼ��dtop����
	dtop = dt;
}

QInsert::~QInsert()
{
}

void QInsert:: on_btn_Insert_clicked()
{

	//��Ϊ��Ҫ�����ֻ��ͼƬ��ַһ������������ö���Ĭ��ֵ���������ҽ�Ϊֻ�����ͣ��û��޷��޸ģ����Բ���Ҫ�ж�
	dtop.query = QSqlQuery(dtop.db);
	dtop.qpic = ui.line_DataPath->text();
	dtop.difficulty = ui.comb_difficulty->text().toInt();

	QString ChapterNeed = ui.comb_Chapter->currentText();
	dtop.Cid = dtop.getCidWithName(ChapterNeed);

	QString belong = ui.comb_belong->currentText();
	dtop.BelongId = dtop.getBelongWithName(belong);

	//dtop.Answer = ui.comb_Answer->currentText();
	if (dtop.BelongId == 1) { //������ѡ���⣬���combox���ô�
		dtop.Answer = ui.comb_Answer->currentText();
	}
	else
	{
		dtop.Answer = ui.line_DataPath->text(); // ����Ǳ���⣬�����Ҫ��line��ȥ��ȡ
	}

	if (dtop.qpic.isEmpty()) // ���ͼƬ����δ��
	{
		QMessageBox::warning(this, "������ʾ", "�����һ��ͼƬ");
	}
	else {
		if (!dtop.Q_isExist(dtop.qpic)) {

			if (dtop.Q_Insert()) {
				QMessageBox::information(this, "������ʾ", "����ɹ�");
				//dtop->initSql(); // ʹ����Ϻ���ע�����³�ʼ��dtop
				ui.line_DataPath->setText("");
			}
			else {
				QMessageBox::warning(this, "������ʾ", "����ʧ��");
			}
		}
		else {
			QMessageBox::warning(this, "������ʾ", "����ͼƬ�ظ���������ѡ��");
		}
		
	}
}

void QInsert::on_comb_belong_currentIndexChanged(int e) //�����߼��ж��޸Ĵ��� �Ŀ�����
{
	if (e != 0) {
		ui.lab_Answer->setEnabled(false); //�����ǰ��index��Ϊѡ���⣬������������Ϊ������
		ui.comb_Answer->setEnabled(false);
		ui.btn_SelectAns->setEnabled(true);
		ui.line_Answer->setEnabled(true);
		ui.comb_Answer->setCurrentIndex(0); // ����εĴ�combox����Ϊa
	}
	else {
		ui.lab_Answer->setEnabled(true); //�����ǰ��indexΪѡ���⣬������������Ϊ����
		ui.comb_Answer->setEnabled(true);
		ui.btn_SelectAns->setEnabled(false);
		ui.line_Answer->setEnabled(false);
		ui.line_Answer->setText("");
	}
}

void QInsert::on_btn_SelectAns_clicked()
{
	picPath = QFileDialog::getOpenFileName(this, "����ͼƬ", QDir::currentPath(), "ͼƬ�ļ�(*.png *.jpg *.bmp *.jpeg)");

	if (picPath.isEmpty()) {

		return;

	}
	else {

		//ui.line_DataPath->setText(picPath); //�趨��ַ��
		ui.line_Answer->setText(picPath);
	}
}

void QInsert::on_btn_SelectPic_clicked() {



	picPath = QFileDialog::getOpenFileName(this,"����ͼƬ", QDir::currentPath(), "ͼƬ�ļ�(*.png *.jpg *.bmp *.jpeg)");

	if (picPath.isEmpty()) {

		return;

	}
	else {

		ui.line_DataPath->setText(picPath); //�趨��ַ��
	}

	
}