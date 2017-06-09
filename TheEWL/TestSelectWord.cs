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
    public partial class TestSelectWord : UserControl
    {
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");
        string SelectedWordMP3 = "";
        int CurrID = 0;
        List<theWord> theListe = new List<theWord>();
        List<theWord> theQ = new List<theWord>();
        List<theWord> SelectWordList = new List<theWord>();
        Random rdm = new Random();
        public TestSelectWord()
        {
            InitializeComponent();
        }
        private static TestSelectWord _instance;
        public static TestSelectWord Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TestSelectWord();
                return _instance;
            }

        }
        public void RemoteLoad(string theTestID, string theTestName)
        {
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
            LoadQ();
        }
        void ButtonClickQ(object sender, EventArgs e)
        {
            Button Betton = sender as Button;
            if (Betton != null)
            {
                CurrID++;
                theWord z= (theWord)Betton.Tag;
                if(btnPlay.Text==z.getWord())
                {
                    Q(true);
                    MainTests.Instance.Say(1, 0);
                    MainTests.Instance.addWordList(z.getFile());
                }
                else
                {
                    Q(false);
                    MainTests.Instance.Say(0, 1);
                }
                LoadQ();
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"AUDIO\\" + SelectedWordMP3 + ".mp3";
            wplayer.controls.play();
        }
        private void LoadQ()
        {
            if (CurrID < 10)
            {
                int Say = -1;
                SelectWordList.Clear();
                theQ.Clear();
                for (int i = 0; i < theListe.Count; i++)
                {
                    SelectWordList.Add(theListe[i]);
                }
                SelectWordList.RemoveAt(CurrID);

                theQ.Add(theListe[CurrID]);
                btnPlay.Text = theListe[CurrID].getWord();
                SelectedWordMP3 = theListe[CurrID].getFile();

                Say = rdm.Next(SelectWordList.Count);
                theQ.Add(SelectWordList[Say]);
                SelectWordList.RemoveAt(Say);

                theQ.Reverse();

                Say = rdm.Next(SelectWordList.Count);
                theQ.Add(SelectWordList[Say]);
                SelectWordList.RemoveAt(Say);

                Say = rdm.Next(SelectWordList.Count);
                theQ.Add(SelectWordList[Say]);
                SelectWordList.RemoveAt(Say);

                theQ.Reverse();

                Q1.Text = theQ[0].getTranslated();
                Q1.Tag = theQ[0];
                Q2.Text = theQ[1].getTranslated();
                Q2.Tag = theQ[1];
                Q3.Text = theQ[2].getTranslated();
                Q3.Tag = theQ[2];
                Q4.Text = theQ[3].getTranslated();
                Q4.Tag = theQ[3];
            }
        }
        private void Q(bool sonuc)
        {
            switch (CurrID)
            {
                case 1:
                    btnW2.Visible = true;
                    if (sonuc)
                        btnW1.Image = ((System.Drawing.Image)(Properties.Resources.i_ok));
                    else
                        btnW1.Image = ((System.Drawing.Image)(Properties.Resources.i_no));
                    break;
                case 2:
                    btnW3.Visible = true;
                    if (sonuc)
                        btnW2.Image = ((System.Drawing.Image)(Properties.Resources.i_ok));
                    else
                        btnW2.Image = ((System.Drawing.Image)(Properties.Resources.i_no));
                    break;
                case 3:
                    btnW4.Visible = true;
                    if (sonuc)
                        btnW3.Image = ((System.Drawing.Image)(Properties.Resources.i_ok));
                    else
                        btnW3.Image = ((System.Drawing.Image)(Properties.Resources.i_no));
                    break;
                case 4:
                    btnW5.Visible = true;
                    if (sonuc)
                        btnW4.Image = ((System.Drawing.Image)(Properties.Resources.i_ok));
                    else
                        btnW4.Image = ((System.Drawing.Image)(Properties.Resources.i_no));
                    break;
                case 5:
                    btnW6.Visible = true;
                    if (sonuc)
                        btnW5.Image = ((System.Drawing.Image)(Properties.Resources.i_ok));
                    else
                        btnW5.Image = ((System.Drawing.Image)(Properties.Resources.i_no));
                    break;
                case 6:
                    btnW7.Visible = true;
                    if (sonuc)
                        btnW6.Image = ((System.Drawing.Image)(Properties.Resources.i_ok));
                    else
                        btnW6.Image = ((System.Drawing.Image)(Properties.Resources.i_no));
                    break;
                case 7:
                    btnW8.Visible = true;
                    if (sonuc)
                        btnW7.Image = ((System.Drawing.Image)(Properties.Resources.i_ok));
                    else
                        btnW7.Image = ((System.Drawing.Image)(Properties.Resources.i_no));
                    break;
                case 8:
                    btnW9.Visible = true;
                    if (sonuc)
                        btnW8.Image = ((System.Drawing.Image)(Properties.Resources.i_ok));
                    else
                        btnW8.Image = ((System.Drawing.Image)(Properties.Resources.i_no));
                    break;
                case 9:
                    btnW10.Visible = true;
                    if (sonuc)
                        btnW9.Image = ((System.Drawing.Image)(Properties.Resources.i_ok));
                    else
                        btnW9.Image = ((System.Drawing.Image)(Properties.Resources.i_no));
                    break;
                case 10:
                    if (sonuc)
                        btnW10.Image = ((System.Drawing.Image)(Properties.Resources.i_ok));
                    else
                        btnW10.Image = ((System.Drawing.Image)(Properties.Resources.i_no));
                    MessageBox.Show("Tebrikler\nŞimdi 2. Test");
                    MainTests.Instance.NextTest("TestListenFind");
                    break;
            }
        }

        private void clearForm()
        {
            theListe.Clear();
            SelectWordList.Clear();
            theQ.Clear();
            btnPlay.Text = "Choose Word";
            SelectedWordMP3 = "";
            btnW1.Image = null;
            btnW2.Visible = false;
            btnW3.Visible = false;
            btnW4.Visible = false;
            btnW5.Visible = false;
            btnW6.Visible = false;
            btnW7.Visible = false;
            btnW8.Visible = false;
            btnW9.Visible = false;
            btnW10.Visible = false;
            CurrID = 0;
        }
    }
}
