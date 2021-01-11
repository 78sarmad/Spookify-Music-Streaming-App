using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace VP_Project.Models
{
    // singleton class - one instance in whole execution
    public static class Database
    {
        private static String DBHost = "localhost";
        private static String DBUser = "root";
        private static String DBPwd = "";
        private static String DBName = "spookify_app";

        public static MySqlConnection conn = null;

        public static void openConnection()
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

        public static void closeConnection()
        {
            conn.Close();
        }

        // checks if connection is open
        public static bool isConnValid()
        {
            if (conn != null)
                return true;
            else
                return false;
        }

        public static MySqlConnection getConnection()
        {
            return conn;
        }
    }
}
