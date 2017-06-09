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
using WMPLib;

namespace TheEWL
{
    public partial class AdminWordNew : UserControl
    {
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");
        private string SelectedFileItemLink="";

        private static AdminWordNew _instance;
        public static AdminWordNew Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminWordNew();
                return _instance;
            }

        }
        public AdminWordNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCSV = new OpenFileDialog();

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "MP3 Dosyası |*.mp3";
            dosya.Title = "www.trxsoftware.com";
            //dosya.ShowDialog();
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                SelectedFileItemLink = dosya.FileName;
                txtMP3Selected.Text = "Selected File: " + Path.GetFileNameWithoutExtension(dosya.FileName)+".mp3";
            }
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            string theFileName = DateTime.Now.ToString("yyyyMMddhhmmss");
            string theSqlCom = "INSERT INTO Word (Word,Translated,Type,File) VALUES ('" + txtWord.Text + "','" + txtTranslated.Text + "','" + cmbType.SelectedItem.ToString() + "','"+theFileName+"')";
            OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
            theConnection.Open();
            int effectedRow = theData.ExecuteNonQuery();
            if (effectedRow > 0)
            {
                File.Copy(@SelectedFileItemLink, "AUDIO\\" + theFileName + ".mp3");
                MessageBox.Show("Ekleme Başarılı");
                txtWord.Clear();
                txtTranslated.Clear();
                txtMP3Selected.Text = "";
                cmbType.SelectedIndex=-1;
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu.\nBul Bakalım Bulabiliyorsan");
            }
            theConnection.Close();
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @SelectedFileItemLink;
            wplayer.controls.play();
        }
    }
}
