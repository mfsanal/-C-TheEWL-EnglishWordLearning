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
using System.Collections;

namespace TheEWL
{
    public partial class TestLearnWord : UserControl
    {
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");
        private string SelectedWordMP3 = "";
        List<theWord> theListe = new List<theWord>();
        string SelectedID = "-1"; string SelectedName = "-1";
        public TestLearnWord()
        {
            InitializeComponent();
        }
        private static TestLearnWord _instance;
        public static TestLearnWord Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TestLearnWord();
                return _instance;
            }

        }
        public void RemoteLoad(string theTestID,string theTestName)
        {
            clearForm();
            SelectedID = theTestID; SelectedName = theTestName;
            txtTestName.Text = "Test : " + theTestName;
            string theSqlCom = "SELECT Pair.ID,Word.Word,Word.Translated,Word.Type,Word.File FROM (Pair INNER JOIN Word ON Pair.WordID=Word.ID) WHERE Pair.TestID=" + theTestID;
            try
            {
                OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
                theConnection.Open();
                OleDbDataReader TheRead = theData.ExecuteReader();
                while (TheRead.Read())
                {
                    theListe.Add(new theWord(TheRead[1].ToString(), TheRead[2].ToString(), TheRead[3].ToString(), TheRead[4].ToString()));

                }
                theConnection.Close();
            }
            catch { }
            btnW1.Text = theListe[0].getWord();
        }

        void ButtonClickOneEvent(object sender, EventArgs e)
        {
            Button Betton = sender as Button;
            if (Betton != null)
            {
                string btnNo = Betton.Name.Substring(4);
                int cID = Convert.ToInt32(btnNo) - 1;
                btnPlay.Text = theListe[cID].getWord() + "\n" + theListe[cID].getType() + "\n" + theListe[cID].getTranslated();
                btnPlay.Tag = btnNo;
                SelectedWordMP3 = theListe[cID].getFile();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"AUDIO\\" + SelectedWordMP3 + ".mp3";
            wplayer.controls.play();
        }

        private void lvWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(lvWord.FocusedItem.SubItems[0].Name);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string cID=(string)btnPlay.Tag;
            switch (cID)
            {
                case "1": btnW2.Visible = true; btnW2.Text = theListe[1].getWord(); break;
                case "2": btnW3.Visible = true; btnW3.Text = theListe[2].getWord(); break;
                case "3": btnW4.Visible = true; btnW4.Text = theListe[3].getWord(); break;
                case "4": btnW5.Visible = true; btnW5.Text = theListe[4].getWord(); break;
                case "5": btnW6.Visible = true; btnW6.Text = theListe[5].getWord(); break;
                case "6": btnW7.Visible = true; btnW7.Text = theListe[6].getWord(); break;
                case "7": btnW8.Visible = true; btnW8.Text = theListe[7].getWord(); break;
                case "8": btnW9.Visible = true; btnW9.Text = theListe[8].getWord(); break;
                case "9": btnW10.Visible = true; btnW10.Text = theListe[9].getWord(); break;
                case "10": MessageBox.Show("Tebrikler\nHazırsan Şimdi Seni Bi Test Edelim"); MainTests.Instance.NextTest("TestSelectWord"); break;
            }
        }

        private void clearForm()
        {
            theListe.Clear();
            btnPlay.Text = "Choose Word";
            btnPlay.Tag = null;
            SelectedWordMP3 = "";
            btnW2.Visible = false;
            btnW3.Visible = false;
            btnW4.Visible = false;
            btnW5.Visible = false;
            btnW6.Visible = false;
            btnW7.Visible = false;
            btnW8.Visible = false;
            btnW9.Visible = false;
            btnW10.Visible = false;
            SelectedID = ""; SelectedName = "";
        }
    }
}
