#include "QManager.h"

QManager::QManager(QWidget *parent)
	: QWidget(parent)
{
	ui.setupUi(this);
	dtop.initSql();
    //on_btn_Fresh_clicked(); // ��ʼ�����������ݿ��е����ݷŵ�tableView��


    dtop.model = new QSqlQueryModel(ui.tableView);
    dtop.query = QSqlQuery(dtop.db); // �����dtop.query�ٽ���һ�γ�ʼ��
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
       // //����  
       // dtop.model->setHeaderData(0, Qt::Horizontal, tr("������"));
       // dtop.model->setHeaderData(1, Qt::Horizontal, tr("����·��"));
       // /*model->setHeaderData(2, Qt::Horizontal, tr("��������"));*/
       //dtop.model->setHeaderData(2, Qt::Horizontal, tr("�����Ѷ�"));
       // dtop.model->setHeaderData(3, Qt::Horizontal, tr("�����½�"));
       // dtop.model->setHeaderData(4, Qt::Horizontal, tr("��������"));
       // dtop.model->setHeaderData(5, Qt::Horizontal, tr("�����"));
        ui.tableView->setModel(dtop.model);//���ݷ��õ�tableView��
        ui.tableView->verticalHeader()->hide();//����ʾ���  
    }
    else
    {
        QMessageBox::warning(this, "����", "δ���ӣ�����.");
    }

}

void QManager::on_btn_Search_clicked() {
    //bool ok = false;
    int Qno = QInputDialog::getInt(this, "��Ŀ��ѯ", "��������Ҫ��ѯ�����", QLineEdit::Normal);
    if (dtop.Q_isExist(Qno)) {
        if (!Qno == NULL) {
            dtop.Q_Search(Qno);//�˴�ֻ���޸��˵�ǰdtop�µ�query
            //����  
            dtop.model->setHeaderData(0, Qt::Horizontal, tr("������"));
            dtop.model->setHeaderData(1, Qt::Horizontal, tr("����·��"));
            /*model->setHeaderData(2, Qt::Horizontal, tr("��������"));*/
            dtop.model->setHeaderData(2, Qt::Horizontal, tr("�����Ѷ�"));
            dtop.model->setHeaderData(3, Qt::Horizontal, tr("�����½�"));
            dtop.model->setHeaderData(4, Qt::Horizontal, tr("��������"));
            dtop.model->setHeaderData(5, Qt::Horizontal, tr("�����"));
            ui.tableView->setModel(dtop.model);//���ݷ��õ�tableView��
            ui.tableView->verticalHeader()->hide();//����ʾ��� 
        }
    }
    else {
        QMessageBox::warning(this, "������ʾ", "��������ȷ�����");
    }

    
}

void QManager::on_btn_Delete_clicked()
{
    bool ok = false;
    int Qno = QInputDialog::getInt(this, "����ɾ��", "��������Ҫɾ�������", QLineEdit::Normal,0,0,1,&ok);

    if (ok && dtop.Q_isExist(Qno)) {
        if (dtop.Q_Delete(Qno)) {
            QMessageBox::information(this, "ɾ����ʾ", "ɾ���ɹ�");
            on_btn_Fresh_clicked();//����ˢһ�£��޿ɺ�ǰ�
        }
        else {
            QMessageBox::warning(this, "ɾ����ʾ", "ɾ��ʧ�ܣ�����ɾ�������Ƿ���ȷ");

        }
    }
    else if(ok){
        QMessageBox::warning(this, "ɾ����ʾ", "��������ȷ�����");
    }
    
    
}
