#include "QManager.h"

QManager::QManager(QWidget *parent)
	: QWidget(parent)
{
	ui.setupUi(this);
	dtop.initSql();
    //on_btn_Fresh_clicked(); // 初始化，将在数据库中的数据放到tableView上


    dtop.model = new QSqlQueryModel(ui.tableView);
    dtop.query = QSqlQuery(dtop.db); // 这里对dtop.query再进行一次初始化
    on_btn_Fresh_clicked();

	
}

QManager::~QManager()
{
}

void QManager::on_btn_Insert_clicked()
{
    QInsert *insert = new QInsert(dtop);
    
    insert->setWindowModality(Qt::ApplicationModal);

    insert->show();


}

void QManager::on_btn_Fresh_clicked() {
    bool ok = dtop.db.open();
    if (ok)
    {
        dtop.Fresh_Model();
       // dtop.model->setQuery(QString("select * from tb_questiondata"));
       // //列名  
       // dtop.model->setHeaderData(0, Qt::Horizontal, tr("试题编号"));
       // dtop.model->setHeaderData(1, Qt::Horizontal, tr("试题路径"));
       // /*model->setHeaderData(2, Qt::Horizontal, tr("试题内容"));*/
       //dtop.model->setHeaderData(2, Qt::Horizontal, tr("试题难度"));
       // dtop.model->setHeaderData(3, Qt::Horizontal, tr("试题章节"));
       // dtop.model->setHeaderData(4, Qt::Horizontal, tr("试题类型"));
       // dtop.model->setHeaderData(5, Qt::Horizontal, tr("试题答案"));
        ui.tableView->setModel(dtop.model);//数据放置到tableView中
        ui.tableView->verticalHeader()->hide();//不显示序号  
    }
    else
    {
        QMessageBox::warning(this, "错误", "未连接，请检查.");
    }

}

void QManager::on_btn_Search_clicked() {
    //bool ok = false;
    int Qno = QInputDialog::getInt(this, "题目查询", "请输入需要查询的题号", QLineEdit::Normal);
    if (dtop.Q_isExist(Qno)) {
        if (!Qno == NULL) {
            dtop.Q_Search(Qno);//此处只是修改了当前dtop下的query
            //列名  
            dtop.model->setHeaderData(0, Qt::Horizontal, tr("试题编号"));
            dtop.model->setHeaderData(1, Qt::Horizontal, tr("试题路径"));
            /*model->setHeaderData(2, Qt::Horizontal, tr("试题内容"));*/
            dtop.model->setHeaderData(2, Qt::Horizontal, tr("试题难度"));
            dtop.model->setHeaderData(3, Qt::Horizontal, tr("试题章节"));
            dtop.model->setHeaderData(4, Qt::Horizontal, tr("试题类型"));
            dtop.model->setHeaderData(5, Qt::Horizontal, tr("试题答案"));
            ui.tableView->setModel(dtop.model);//数据放置到tableView中
            ui.tableView->verticalHeader()->hide();//不显示序号 
        }
    }
    else {
        QMessageBox::warning(this, "查找提示", "请输入正确的题号");
    }

    
}

void QManager::on_btn_Delete_clicked()
{
    bool ok = false;
    int Qno = QInputDialog::getInt(this, "试题删除", "请输入需要删除的题号", QLineEdit::Normal,0,0,1,&ok);

    if (ok && dtop.Q_isExist(Qno)) {
        if (dtop.Q_Delete(Qno)) {
            QMessageBox::information(this, "删除提示", "删除成功");
            on_btn_Fresh_clicked();//做完刷一下，无可厚非吧
        }
        else {
            QMessageBox::warning(this, "删除提示", "删除失败，请检查删除对象是否正确");

        }
    }
    else if(ok){
        QMessageBox::warning(this, "删除提示", "请输入正确的题号");
    }
    
    
}
