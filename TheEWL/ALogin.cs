using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TheEWL
{
    public partial class ALogin : Form
    {
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");

        bool mouseDown = false;
        Point cursorPosition;
        Point formLocation;
        public ALogin()
        {
            InitializeComponent();
            /* *********** Auto Login *********** */
            /**/txtUserName.Text = "fatihsanal";   /**/
            /**/txtPassword.Text = "123456"; /**/
            /* *********** Auto Login *********** */
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frmLogin = new Login();
            frmLogin.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string theSqlCom = "SELECT * FROM Admin WHERE UserName = '" + txtUserName.Text + "' and UserPass ='" + txtPassword.Text + "'";
            string pNameSurname = "";
            try
            {
                OleDbCommand theData = new OleDbCommand(theSqlCom, theConnection);
                theConnection.Open();
                /**/bool srgLogin = Convert.ToBoolean(theData.ExecuteScalar());
                    OleDbDataReader TheRead = theData.ExecuteReader();
                    if(TheRead.Read())
                    {
                        pNameSurname = TheRead["UName"].ToString() + " " + TheRead["USurName"].ToString();
                    }
                theConnection.Close();
                if(srgLogin)
                {
                    //MessageBox.Show(pNameSurname);

                    AdminMenu frmLogin = new AdminMenu(pNameSurname);
                    frmLogin.UserNameBar = pNameSurname;
                    this.Close();
                    frmLogin.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Pass or UserName");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error...\ne3706");
            }
        }

    }
}
