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
    public partial class AdminPair : UserControl
    {
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");
        string CurrListID = "";
        string CurrListName = "";
        string CurrListItemID = "-1";
        string CurrListPairItemID = "-1";

        private static AdminPair _instance;
        public static AdminPair Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminPair();
                return _instance;
            }

        }
        public AdminPair()
        {
            InitializeComponent();
            loadListTEST();
            loadListWORD();
        }
        public void RemoteLoad()
        {
            dgvPair.DataSource = null;
            CurrListName = "";
            loadListTEST();
            loadListWORD();
        }
        private void loadListTEST()
        {
            theConnection.Open();
            string theSqlCom = "SELECT * FROM Test";
            OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter(theData);
            DataTable theDataTable = new DataTable();
            theDataAdapter.Fill(theDataTable);
            dgvTest.DataSource = theDataTable;
            theConnection.Close();
            dgvTest.Columns[0].Width = 45;
            dgvTest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void loadListWORD()
        {
            theConnection.Open();
            string theSqlCom = "SELECT ID,Word,Translated FROM Word";
            OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter(theData);
            DataTable theDataTable = new DataTable();
            theDataAdapter.Fill(theDataTable);
            dgvWord.DataSource = theDataTable;
            theConnection.Close();
            dgvWord.Columns[0].Width = 45;
            dgvWord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvWord.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void loadListPair(string theID)
        {
            theConnection.Open();
            string theSqlCom = "SELECT Pair.ID,Word.Word,Test.TestName FROM (Pair INNER JOIN Word ON Pair.WordID=Word.ID) INNER JOIN Test ON Pair.TestID=Test.ID WHERE Pair.TestID=" + theID;
            //string theSqlCom = "SELECT * FROM Pair WHERE TestID='" + theID+"'";
            OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter(theData);
            DataTable theDataTable = new DataTable();
            theDataAdapter.Fill(theDataTable);
            dgvPair.DataSource = theDataTable;
            theConnection.Close();
            dgvPair.Columns[0].Width = 45;
            dgvPair.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPair.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (CurrListItemID != "-1")
            {
                string PairWordCount = "0";
                string theSqlComCheck = "SELECT COUNT(*) FROM Pair WHERE TestID=" + CurrListID + " and WordID=" + CurrListItemID;
                OleDbCommand theDataCheck = new OleDbCommand(theSqlComCheck, theConnection);
                theConnection.Open();
                OleDbDataReader TheRead = theDataCheck.ExecuteReader();
                if (TheRead.Read())
                {
                    PairWordCount = TheRead[0].ToString();
                }
                theConnection.Close();
                if (PairWordCount == "0")
                {
                    string theSqlCom = "INSERT INTO Pair (WordID,TestID) VALUES (" + CurrListItemID + "," + CurrListID + ")";
                    OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
                    theConnection.Open();
                    int effectedRow = theData.ExecuteNonQuery();
                    theConnection.Close();
                    if (effectedRow > 0)
                    {
                        MessageBox.Show("Ekleme Başarılı");
                        loadListPair(CurrListID);
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu.\nVeriTabanı Hatası...");
                    }
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu.\nKayıt Daha önce Mevcut...");
                }
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu.\nListe Seçilmedi...");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (CurrListPairItemID != "-1")
            {
                string theSqlCom = "DELETE FROM Pair WHERE ID=" + CurrListPairItemID;
                OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
                theConnection.Open();
                int effectedRow = theData.ExecuteNonQuery();
                theConnection.Close();
                if (effectedRow > 0)
                {
                    MessageBox.Show("Silme Başarılı");
                    loadListPair(CurrListID);
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu.\nBul Bakalım Bulabiliyorsan");
                }
            }
        }

        private void dgvTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CurrListID = dgvTest.Rows[e.RowIndex].Cells[0].Value.ToString();
                CurrListName = dgvTest.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSelectedTest.Text = CurrListName;
                loadListPair(CurrListID);
            }
            
        }

        private void dgvPair_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CurrListPairItemID = dgvPair.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void dgvWord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CurrListItemID = dgvWord.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
