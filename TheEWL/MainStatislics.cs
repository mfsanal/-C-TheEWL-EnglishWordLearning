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
    public partial class MainStatislics : UserControl
    {
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");
        int TotalTrue = 0;
        int TotalFalse = 0;
        int TotalTime = 0;
        int TotalWordsCount = 0;
        String TotalWords = "";

        private static MainStatislics _instance;
        public static MainStatislics Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainStatislics();
                return _instance;
            }

        }
        public MainStatislics()
        {
            InitializeComponent();
        }
        public void RemoteLoad(string theName,int theID)
        {
            txtName.Text = theName;
            String theCommand = "SELECT * FROM theData WHERE xUSERID='" + theID +"'";
            try
            {
                OleDbCommand theData = new OleDbCommand(theCommand, theConnection);
                theConnection.Open();
                OleDbDataReader TheRead = theData.ExecuteReader();
                while (TheRead.Read())
                {
                    TotalTrue += Convert.ToInt32(TheRead["xTRUE"].ToString());
                    TotalFalse += Convert.ToInt32(TheRead["xFALSE"].ToString());
                    TotalTime += Convert.ToInt32(TheRead["xTIME"].ToString());
                    TotalWords += TheRead["xWORDS"].ToString();
                }
                theConnection.Close();
            }
            catch{}
            TimeSpan tsTTime = TimeSpan.FromSeconds(TotalTime);
            txtTotalTime.Text = tsTTime.ToString();

            this.chrResult.Series["Points"].Points.AddXY("True", Convert.ToDouble(TotalTrue));
            this.chrResult.Series["Points"].Points.AddXY("False", Convert.ToDouble(TotalFalse));

            string[] words = TotalWords.Split(',');
            foreach (string word in words)
            {
                TotalWordsCount += 1;
            }
            txtTotalLearning.Text = (TotalWordsCount-1) + " Words";
        }
    }
}
