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
    public partial class Register : Form
    {
        theFunctions theFunc = new theFunctions();
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string theSqlComm = "INSERT INTO UserDetail (UName,USurName,UMail,UserName,UserPass) VALUES ('" + txtName.Text + "','" + txtSurname.Text + "','" + txtMail.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "')";
            bool theLogin = theFunc.Register(theSqlComm);

            if (theLogin)
            {
                MessageBox.Show("Kayıt Başarılı\nArtık Giriş yapabilirsiniz");
                btn_exit_Click(sender, e);
            }
            else
                MessageBox.Show("No");
           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Login i = new Login();
            i.Show();
        }
    }
}
