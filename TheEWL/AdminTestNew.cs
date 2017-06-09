using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TheEWL
{
    public partial class AdminTestNew : UserControl
    {
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");

        private static AdminTestNew _instance;
        public static AdminTestNew Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new AdminTestNew();
                return _instance;

            }

        }
        public AdminTestNew()
        {
            InitializeComponent();
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            string theSqlCom = "INSERT INTO Test (TestName) VALUES ('"+txtTestName.Text+"')";
            OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
            theConnection.Open();
            int effectedRow = theData.ExecuteNonQuery();
            if (effectedRow>0)
            {
                MessageBox.Show("Ekleme Başarılı");
                txtTestName.Clear();
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu.\nBul Bakalım Bulabiliyorsan");
            }
            theConnection.Close();
        }
    }
}
