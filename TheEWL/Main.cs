using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheEWL
{
    public partial class Main : Form
    {
        bool mouseDown = false;
        Point cursorPosition;
        Point formLocation;
        string theGlobalUserName = "";
        int USERID = -1;
        public Main(string theUserName,int theUSERID)
        {
            InitializeComponent();
            USERID = theUSERID;
            BarTitle.Text = BarTitle.Text + "  [" + theUserName + "]";
            theGlobalUserName = theUserName;
            // Panellere Formları atıyok
            pnlMain.Controls.Add(MainTests.Instance);
            pnlMain.Controls.Add(MainLearnedWords.Instance);
            pnlMain.Controls.Add(MainStatislics.Instance);
            // varsayılan formcuk
            MainTests.Instance.BringToFront();
            MainTests.Instance.RemoteLoad(USERID);
        }

        private void navBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                cursorPosition = Cursor.Position;
                formLocation = this.Location;
                mouseDown = true;
            }
        }

        private void navBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = Cursor.Position.X - cursorPosition.X;
                int y = Cursor.Position.Y - cursorPosition.Y;
                this.Location = new Point(formLocation.X + x, formLocation.Y + y);
            }
        }

        private void navBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            MainTests.Instance.BringToFront();
            MainTests.Instance.RemoteLoad(USERID);
        }

        private void btnLearned_Click(object sender, EventArgs e)
        {
            MainLearnedWords.Instance.BringToFront();
            MainLearnedWords.Instance.RemoteLoad();
        }

        private void btnStatislick_Click(object sender, EventArgs e)
        {
            MainStatislics.Instance.BringToFront();
            MainStatislics.Instance.RemoteLoad(theGlobalUserName, USERID);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }


    }
}
