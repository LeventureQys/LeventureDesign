#include "QInsert.h"

QInsert::QInsert(DataOperate dt,QWidget *parent)
	: QWidget(parent)
{
	ui.setupUi(this);
	 // 初始化dtop对象
	dtop = dt;
}

QInsert::~QInsert()
{
}

void QInsert:: on_btn_Insert_clicked()
{

	//因为需要输入的只有图片地址一条，其余的设置都有默认值保护，而且皆为只读类型，用户无法修改，所以不需要判定
	dtop.query = QSqlQuery(dtop.db);
	dtop.qpic = ui.line_DataPath->text();
	dtop.difficulty = ui.comb_difficulty->text().toInt();

	QString ChapterNeed = ui.comb_Chapter->currentText();
	dtop.Cid = dtop.getCidWithName(ChapterNeed);

	QString belong = ui.comb_belong->currentText();
	dtop.BelongId = dtop.getBelongWithName(belong);

	//dtop.Answer = ui.comb_Answer->currentText();
	if (dtop.BelongId == 1) { //假如是选择题，则从combox中拿答案
		dtop.Answer = ui.comb_Answer->currentText();
	}
	else
	{
		dtop.Answer = ui.line_DataPath->text(); // 如果是别的题，则答案需要从line上去获取
	}

	if (dtop.qpic.isEmpty()) // 如果图片连接未空
	{
		QMessageBox::warning(this, "插入提示", "请插入一张图片");
	}
	else {
		if (!dtop.Q_isExist(dtop.qpic)) {

			if (dtop.Q_Insert()) {
				QMessageBox::information(this, "插入提示", "插入成功");
				//dtop->initSql(); // 使用完毕后请注意重新初始化dtop
				ui.line_DataPath->setText("");
			}
			else {
				QMessageBox::warning(this, "插入提示", "插入失败");
			}
		}
		else {
			QMessageBox::warning(this, "插入提示", "插入图片重复，请重新选择");
		}
		
	}
}

void QInsert::on_comb_belong_currentIndexChanged(int e) //此条逻辑判断修改答案栏 的可用性
{
	if (e != 0) {
		ui.lab_Answer->setEnabled(false); //如果当前的index不为选择题，则将两个栏设置为不可用
		ui.comb_Answer->setEnabled(false);
		ui.btn_SelectAns->setEnabled(true);
		ui.line_Answer->setEnabled(true);
		ui.comb_Answer->setCurrentIndex(0); // 令被屏蔽的答案combox设置为a
	}
	else {
		ui.lab_Answer->setEnabled(true); //如果当前的index为选择题，则将两个栏设置为可用
		ui.comb_Answer->setEnabled(true);
		ui.btn_SelectAns->setEnabled(false);
		ui.line_Answer->setEnabled(false);
		ui.line_Answer->setText("");
	}
}

void QInsert::on_btn_SelectAns_clicked()
{
	picPath = QFileDialog::getOpenFileName(this, "查找图片", QDir::currentPath(), "图片文件(*.png *.jpg *.bmp *.jpeg)");

	if (picPath.isEmpty()) {

		return;

	}
	else {

		//ui.line_DataPath->setText(picPath); //设定地址栏
		ui.line_Answer->setText(picPath);
	}
}

void QInsert::on_btn_SelectPic_clicked() {



	picPath = QFileDialog::getOpenFileName(this,"查找图片", QDir::currentPath(), "图片文件(*.png *.jpg *.bmp *.jpeg)");

	if (picPath.isEmpty()) {

		return;

	}
	else {

		ui.line_DataPath->setText(picPath); //设定地址栏
	}

	
}