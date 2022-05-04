using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_School.Classes
{
    class DBUtils
    {
        /// <summary>
        /// Connection string from app.config.
        /// </summary>
        /// <returns>If first start project, method return string connection with data base for developing.</returns>
        public static string GetConnectionString()
        {
            //return ConfigurationManager.ConnectionStrings["SqlConnection"].ToString();
            return Classes.Settings.ConfigurationLevel.ReadSetting("SqlConnection");
        }

        /// <summary>
        /// Fetching data from a database.
        /// </summary>
        /// <param name="select">Line with data fetch command</param>
        /// <returns>Sample result</returns>
        public static DataSet GetDataSetFromDataBase(string select)
        {
            using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
            {
                connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
        }
        /// <summary>
        /// Example SQL commands (INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="select">It`s command "select..."</param>
        public static void ExecuteSqlCommand(string select)
        {
            using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
            {
                connection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(select, connection);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();
            }
        }
    }
}
