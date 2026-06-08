using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace LibraryManagementSystem.Helper
{
    public class DBConnection
    {
        private static string connectionString =
            "Server=localhost;Port=3306;Database=LibraryDB;Uid=root;Pwd=ah721077@gmail;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var con = GetConnection())
                {
                    con.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}