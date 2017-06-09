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
using System.IO;

namespace TheEWL
{
    public partial class AdminWordList : UserControl
    {
        string SelectedRowFileID = "";
        string SelectedRowID = "";
        string SelectedRowDetails = "";
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");

        private static AdminWordList _instance;
        public static AdminWordList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminWordList();
                return _instance;
            }

        }
        public AdminWordList()
        {
            InitializeComponent();
        }

        private void LoadTable()
        {
            theConnection.Open();
            string theSqlCom = "SELECT * FROM Word";
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
        public void RemoteLoad()
        {
            LoadTable();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                SelectedRowFileID = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                SelectedRowID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                SelectedRowDetails =
                      dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " - "
                    + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " - "
                    + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDetail.Text = SelectedRowDetails;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string theSqlCom = "DELETE FROM Word WHERE ID=" + SelectedRowID;
            OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
            theConnection.Open();
            int effectedRow = theData.ExecuteNonQuery();
            if (effectedRow > 0)
            {
                MessageBox.Show("Silme Başarılı");
                if (File.Exists(@"AUDIO\\" + SelectedRowFileID + ".mp3"))
                {
                    File.Delete(@"AUDIO\\" + SelectedRowFileID + ".mp3");
                }
                else
                {
                    MessageBox.Show("Ancak MP3 Dosyası Bulunamadı");
                }
                txtDetail.Clear();
                SelectedRowID = "";
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu.\nBul Bakalım Bulabiliyorsan");
            }
            theConnection.Close();
            LoadTable();
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"AUDIO\\" + SelectedRowFileID + ".mp3";
            wplayer.controls.play();
        }
    }
}
