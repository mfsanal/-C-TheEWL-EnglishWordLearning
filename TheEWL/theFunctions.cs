using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace TheEWL
{
    class theFunctions
    {
        OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=TheEWL.accdb");
        private string LoginUserName="Unknown User";
        int theUserID = -1;
        public bool Register(string theCommand)
        {
            try
            {
                OleDbCommand theData = new OleDbCommand(theCommand, theConnection);
                theConnection.Open();
                int effectedRows = theData.ExecuteNonQuery();
                theConnection.Close();
                if (effectedRows > 0)
                {
                    return true; //Login True
                }
                else
                {
                    return false; //Login False
                }

            }
            catch
            {
                return false; //Error Connection
            }
        }
        public bool UserLogin(string theCommand)
        {
            try
            {
                OleDbCommand theData = new OleDbCommand(theCommand, theConnection);
                theConnection.Open();
                bool Login = Convert.ToBoolean(theData.ExecuteScalar());
                OleDbDataReader TheRead = theData.ExecuteReader();
                if (TheRead.Read())
                { 
                    LoginUserName = TheRead["UName"].ToString() + " " + TheRead["USurName"].ToString();
                    theUserID = Convert.ToInt32(TheRead["ID"].ToString());
                }
                theConnection.Close();

                return Login; // Login State
            }
            catch
            {
                return false; //Error Connection
            }
        }
        public string UserLogin()
        {
            return LoginUserName;
        }
        public int UserID()
        {
            return theUserID;
        }
         
    }
}
