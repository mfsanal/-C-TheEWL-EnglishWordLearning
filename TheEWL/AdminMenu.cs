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
    public partial class AdminMenu : Form
    {
        public string UserNameBar = "Admin User";
        bool mouseDown = false;
        Point cursorPosition;
        Point formLocation;

        public AdminMenu(string pNameSurname)
        {
            InitializeComponent();
            BarTitle.Text = BarTitle.Text + "  [" + pNameSurname + "]";
            // Panellere Formları atıyok
            panel1.Controls.Add(AdminTestNew.Instance);
            panel1.Controls.Add(AdminTestList.Instance);
            panel1.Controls.Add(AdminWordNew.Instance);
            panel1.Controls.Add(AdminWordList.Instance);
            panel1.Controls.Add(AdminPair.Instance);
            // varsayılan formcuk
            AdminTestList.Instance.BringToFront();
            AdminTestList.Instance.RemoteLoad();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void AdminMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                cursorPosition = Cursor.Position;
                formLocation = this.Location;
                mouseDown = true;
            }
        }

        private void AdminMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = Cursor.Position.X - cursorPosition.X;
                int y = Cursor.Position.Y - cursorPosition.Y;
                this.Location = new Point(formLocation.X + x, formLocation.Y + y);
            }
        }

        private void AdminMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void btn_test_new_Click(object sender, EventArgs e)
        {
            AdminTestNew.Instance.BringToFront();
        }

        private void btn_test_list_Click(object sender, EventArgs e)
        {
            AdminTestList.Instance.BringToFront();
            AdminTestList.Instance.RemoteLoad();
        }


        private void btn_word_list_Click(object sender, EventArgs e)
        {
            AdminWordList.Instance.BringToFront();
            AdminWordList.Instance.RemoteLoad();
        }

        private void btn_word_new_Click(object sender, EventArgs e)
        {
            AdminWordNew.Instance.BringToFront();
        }

        private void btn_pair_Click(object sender, EventArgs e)
        {
            AdminPair.Instance.BringToFront();
            AdminPair.Instance.RemoteLoad();
        }

       
    }
}
