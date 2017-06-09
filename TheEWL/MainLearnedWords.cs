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
    public partial class MainLearnedWords : UserControl
    {
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");

        private static MainLearnedWords _instance;
        public static MainLearnedWords Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainLearnedWords();
                return _instance;
            }
        }
        public MainLearnedWords()
        {
            InitializeComponent();
            //RemoteLoad();
        }
        public void RemoteLoad()
        {
            listView1.Clear();
            ImageList Resimler = new ImageList();
            Resimler.ImageSize = new Size(51, 51);
            string theCommand = "SELECT * FROM Word";
            try
            {
                OleDbCommand theData = new OleDbCommand(theCommand, theConnection);
                theConnection.Open();
                bool Login = Convert.ToBoolean(theData.ExecuteScalar());
                OleDbDataReader TheRead = theData.ExecuteReader();
                int theAI = 0;
                while (TheRead.Read())
                {
                    Resimler.Images.Add(theLoadImage(TheRead["Type"].ToString()[0].ToString()));
                    listView1.Items.Add(TheRead["File"].ToString(), TheRead["Word"].ToString(), theAI);
                    theAI++;
                }
                theConnection.Close();
            }
            catch { }
            listView1.LargeImageList = Resimler;
             
        }
        public Bitmap theLoadImage(string theHarf)
        {
            Random rnd = new Random();
            Bitmap bmp = new Bitmap(51, 51);
            Font f = new System.Drawing.Font(FontFamily.GenericSerif, 25, FontStyle.Regular);
            Graphics pen = Graphics.FromImage(bmp);
            Pen Kalem = new Pen(Color.LightSkyBlue);
            pen.DrawRectangle(Kalem, 0, 0, 50, 50);
            pen.DrawString(theHarf, f, Brushes.Green, 5, 5);
            return bmp;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.FocusedItem.SubItems[0].Name
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"AUDIO\\" + listView1.FocusedItem.SubItems[0].Name + ".mp3";
            wplayer.controls.play();
        }
    }
}
