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
    public partial class MainTests : UserControl
    {
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");
        public string SelectedID = "-1";  public string SelectedName = "-1";
        private int sayTrue =0, sayFalse = 0;
        public int xTime = 0;
        List<string> WordIDS = new List<string>();
        int USERID = -1;

        public MainTests()
        {
            InitializeComponent();
            panelMain.Controls.Add(TestLearnWord.Instance);
            panelMain.Controls.Add(TestListenFind.Instance);
            panelMain.Controls.Add(TestListenWrite.Instance);
            panelMain.Controls.Add(TestSelectWord.Instance);
        }
        private static MainTests _instance;
        public static MainTests Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainTests();
                return _instance;
            }

        }
        public void RemoteLoad(int theUserID)
        {
            USERID = theUserID;
            lvTest.Visible = true;
            btnStart.Visible = true;
            btnLearnWords.Visible = false;
            btnListenFind.Visible = false;
            btnListenWrite.Visible = false;
            btnSelectWord.Visible = false;
            panelMain.Visible = false;
            lvTest.Clear();
            xTime = 0;
            cntFalse.Visible = false;
            cntTrue.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtSayac.Visible = false;
            WordIDS.Clear();
            //////////////////////////////////
            ImageList Resimler = new ImageList();
            Resimler.ImageSize = new Size(71, 71);
            string theCommand = "SELECT * FROM Test";
            try
            {
                OleDbCommand theData = new OleDbCommand(theCommand, theConnection);
                theConnection.Open();
                bool Login = Convert.ToBoolean(theData.ExecuteScalar());
                OleDbDataReader TheRead = theData.ExecuteReader();
                int theAI = 0;
                while (TheRead.Read())
                {
                    Resimler.Images.Add(theLoadImage(TheRead["TestName"].ToString()[0].ToString()));
                    lvTest.Items.Add(TheRead["ID"].ToString(), TheRead["TestName"].ToString(), theAI);
                    theAI++;
                }
                theConnection.Close();
            }
            catch { }
            lvTest.LargeImageList = Resimler;
            lvTest.SmallImageList = Resimler;
        }

        public void addWordList(string ID)
        {
            WordIDS.Add(ID);
        }

        public void FinishTest()
        {
            sayac.Stop();
            string myWord = "";
            WordIDS.Distinct().ToList();
            for(int i=0;i<WordIDS.Count;i++)
            {
                myWord += WordIDS[i].ToString() + ",";
            }
            string theCommand = "INSERT INTO theData (xUSERID,xTRUE,xFALSE,xTIME,xWORDS) VALUES ('"+USERID+"','"+sayTrue+"','"+sayFalse+"','"+xTime+"','"+myWord+"')";
            MessageBox.Show(theCommand);
            OleDbCommand theDatax = new OleDbCommand(theCommand, theConnection);
            theConnection.Open();
            int effectedRow = theDatax.ExecuteNonQuery();
            theConnection.Close();
            if (effectedRow <= 0)
            {
                MessageBox.Show("Bir Hata Oluştu....");
                MessageBox.Show("Bir Hata Oluştu.....");
                MessageBox.Show("Bir Hata Oluştu......");
                MessageBox.Show("Bir Hata Oluştu.......");
                MessageBox.Show("Bir Hata Oluştu........");
            }
            RemoteLoad(USERID);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (SelectedID == "-1")
                MessageBox.Show("Lütfen Bir Test Seçiniz");
            else {
                lvTest.Visible = false;
                btnStart.Visible = false;
                btnLearnWords.Visible = true;
                panelMain.Visible = true;
                cntFalse.Visible = true;
                cntTrue.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                txtSayac.Visible = true;
                TestLearnWord.Instance.BringToFront();
                TestLearnWord.Instance.RemoteLoad(SelectedID,SelectedName);
                sayac.Start();
            }
            
        }

        public Bitmap theLoadImage(string theHarf)
        {
            Random rnd = new Random();
            Bitmap bmp = new Bitmap(71, 71);
            Font f = new System.Drawing.Font(FontFamily.GenericSerif, 25, FontStyle.Regular);
            Graphics pen = Graphics.FromImage(bmp);
            Pen Kalem = new Pen(Color.LightSkyBlue);
            pen.DrawRectangle(Kalem, 0, 0, 70, 70);
            pen.DrawString(theHarf, f, Brushes.Green, 20, 20);
            return bmp;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = lvTest.FocusedItem.SubItems[0].Name;
            SelectedName = lvTest.FocusedItem.SubItems[0].Text;
        }

        private void btnListenFind_Click(object sender, EventArgs e)  { selectTest(2); }
        private void btnListenWrite_Click(object sender, EventArgs e) { selectTest(3); }
        private void btnSelectWord_Click(object sender, EventArgs e)  { selectTest(1); }
        private void btnLearnWords_Click(object sender, EventArgs e)  { selectTest(0); }

        private void selectTest(int p)
        {
            switch (p)
            {
                case 0: TestLearnWord.Instance.BringToFront(); TestLearnWord.Instance.RemoteLoad(SelectedID, SelectedName); break;
                case 1: TestSelectWord.Instance.BringToFront(); TestSelectWord.Instance.RemoteLoad(SelectedID, SelectedName); break;
                case 2: TestListenFind.Instance.BringToFront(); TestListenFind.Instance.RemoteLoad(SelectedID, SelectedName); break;
                case 3: TestListenWrite.Instance.BringToFront(); TestListenWrite.Instance.RemoteLoad(SelectedID, SelectedName); break;
            }
        }
        public void NextTest(string p)
        {
            switch (p)
            {
                case "TestLearnWord": selectTest(0); btnLearnWords.Visible = true; break;
                case "TestSelectWord": selectTest(1); btnSelectWord.Visible = true; break;
                case "TestListenFind": selectTest(2); btnListenFind.Visible = true; break;
                case "TestListenWrite": selectTest(3); btnListenWrite.Visible = true; break;
            }
        }
        public void Say(int T, int F)
        {
            sayTrue += T; sayFalse += F;
            cntTrue.Text = sayTrue.ToString();
            cntFalse.Text = sayFalse.ToString();
        }

        private void sayac_Tick(object sender, EventArgs e)
        {
            xTime += 1;
            TimeSpan t = TimeSpan.FromSeconds(xTime);
            txtSayac.Text = t.ToString();
        }
    }
}
