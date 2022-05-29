using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeventureDesign
{
    public partial class QMain : Form
    {
        public QMain()
        {
            InitializeComponent();
        }

        private void QMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_QManager_Click(object sender, EventArgs e)
        {
            QManager QM = new QManager();
            QM.Show();
        }

        private void btn_PaperMaker_Click(object sender, EventArgs e)
        {
            PaperManager Pm = new PaperManager();
            Pm.Show();
              
        }
    }
}
