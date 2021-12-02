using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace Internet_Service_Provider
{
    internal class DBMySqlUtils
    {
        static public string GetStringConnection()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        static public DataTable ExecuteMySqlCommandAndReturnTable(string command)
        {

            using (MySqlConnection mySql = new MySqlConnection(GetStringConnection()))
            {
                mySql.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command, mySql);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

    }
}
