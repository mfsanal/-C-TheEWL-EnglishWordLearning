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
    public partial class AdminTestList : UserControl
    {
        string SelectedRowID = "";
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");

        private static AdminTestList _instance;
        public static AdminTestList Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new AdminTestList();
                return _instance;

            }

        }
        public AdminTestList()
        {
            InitializeComponent();
            
        }
        public void RemoteLoad()
        {
            LoadTable();
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            string theSqlCom = "UPDATE Test SET TestName ='" + txtTestName.Text + "' WHERE ID=" + SelectedRowID ;
            OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
            theConnection.Open();
            MessageBox.Show(theSqlCom);
            int effectedRow = theData.ExecuteNonQuery();
            if (effectedRow > 0)
            {
                MessageBox.Show("Düzenleme Başarılı");
                txtTestName.Clear();
                SelectedRowID = "";
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu.\nBul Bakalım Bulabiliyorsan");
            }
            theConnection.Close();
            LoadTable();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string PairWordCount = "0";
            string theSqlComm = "SELECT COUNT(*) FROM Pair WHERE TestID=" + SelectedRowID;
            OleDbCommand theDataCheck = new OleDbCommand(theSqlComm, theConnection);
            theConnection.Open();
            OleDbDataReader TheRead = theDataCheck.ExecuteReader();
            if (TheRead.Read())
            {
                PairWordCount=TheRead[0].ToString();
            }
            theConnection.Close();

            if (PairWordCount != "0")
            {
                string theSqlComDelete = "DELETE FROM Pair WHERE TestID=" + SelectedRowID;
                OleDbCommand theDataDelete = new OleDbCommand(theSqlComDelete, theConnection);
                theConnection.Open();
                theDataDelete.ExecuteNonQuery();
                theConnection.Close();
            }

            string theSqlCom = "DELETE FROM Test WHERE ID=" + SelectedRowID;
            OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
            theConnection.Open();
            int effectedRow = theData.ExecuteNonQuery();
            if (effectedRow > 0)
            {
                MessageBox.Show("Silme Başarılı");
                txtTestName.Clear();
                SelectedRowID = "";
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu.\nBul Bakalım Bulabiliyorsan");
            }
            theConnection.Close();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtTestName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                SelectedRowID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTestName.Enabled = true;
            }
        }

        private void LoadTable()
        {
            theConnection.Open();
            string theSqlCom = "SELECT * FROM Test";
            OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter(theData);
            DataTable theDataTable = new DataTable();
            theDataAdapter.Fill(theDataTable);
            dataGridView1.DataSource = theDataTable;
            theConnection.Close();
            dataGridView1.Columns[0].Width = 45;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;        
        }
    }
}
