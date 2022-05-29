using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeventureDesign
{
    class QCore
    {
        DataOperator dataoper = new DataOperator();
        DataSet question = new DataSet();
        public DataSet Qdataset_all()
        {
            try
            {
                string SearchUser = "select * from tb_tb_questiondata";
                DataSet st = new DataSet();
                st = dataoper.GetSqlDataset(SearchUser);

                return st;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public DataGridView Q_DataGridViewInit(DataGridView dataGridView1, DataSet Question)
        {
            try
            {
                dataGridView1.DataSource = Question;
                dataGridView1.DataMember = "lwx";
                dataGridView1.Columns[0].HeaderText = "题号";
                dataGridView1.Columns[1].HeaderText = "图片";
                dataGridView1.Columns[2].HeaderText = "内容";
                dataGridView1.Columns[3].HeaderText = "难度";
                dataGridView1.Columns[4].HeaderText = "所属章节";
                dataGridView1.Columns[5].HeaderText = "题目片区";
                dataGridView1.Columns[6].HeaderText = "答案";
               
                return dataGridView1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            return null;
        }
    }
}
