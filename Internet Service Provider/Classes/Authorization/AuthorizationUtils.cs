using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Service_Provider
{
    internal class AuthorizationUtils : DBMySqlUtils
    {
        static public bool CheckDataUser(string login, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(GetStringConnection()))
            {
                connection.Open();
                
                string commandText = $"select * from users where login_user = '{login}' and password_user = '{password}'";
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandText, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
