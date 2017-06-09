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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            /* *********** Auto Login *********** */
            /**/txtUserName.Text = "maliksanal";   /**/
            /**/txtPassword.Text = "123456"; /**/
            /* *********** Auto Login *********** */
        }
        bool mouseDown = false;
        Point cursorPosition;
        Point formLocation;
        theFunctions theFunc = new theFunctions();

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                cursorPosition = Cursor.Position;
                formLocation = this.Location;
                mouseDown = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = Cursor.Position.X - cursorPosition.X;
                int y = Cursor.Position.Y - cursorPosition.Y;
                this.Location = new Point(formLocation.X + x, formLocation.Y + y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register frmRegister = new Register();
            frmRegister.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ALogin frmALogin = new ALogin();
            frmALogin.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string theSqlComm = "SELECT * FROM UserDetail WHERE UserName = '" + txtUserName.Text + "' and UserPass ='" + txtPassword.Text + "'";
            bool theLogin = theFunc.UserLogin(theSqlComm);
            string theUserName = theFunc.UserLogin();// Requrment of UserLogin() else Error
            int theUSERID = theFunc.UserID();
            if (theLogin)
            {
                Main frm = new Main(theUserName,theUSERID);
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Login Error");
        }
    }
}
