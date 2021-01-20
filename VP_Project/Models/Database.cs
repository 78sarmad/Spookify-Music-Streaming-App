using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace VP_Project.Models
{
    class Database
    {
        private String DBHost = "localhost";
        private String DBUser = "root";
        private String DBPwd = "";
        private String DBName = "spookify_app";

        public MySqlConnection conn = null;

        public void openConnection()
        {
            string connStr = @"server="+DBHost+";database="+DBName+";uid="+DBUser+";pwd="+DBPwd+";";
            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                Console.WriteLine("Status: Connection established.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not establish connection.\n" + ex.Message);
            }
        }

        public void closeConnection()
        {
            conn.Close();
        }

        // checks if connection is open
        public bool isConnOpen()
        {
            if (conn.State == ConnectionState.Open)
                return true;
            else
                return false;
        }

        public MySqlConnection getConnection()
        {
            return conn;
        }
    }
}
