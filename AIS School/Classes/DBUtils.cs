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

        static public DataTable GetDataSetFromDataBase(string CommandSQL, MySqlConnection connection)
        {
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(CommandSQL, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        static public void ExecuteSqlCommand(string CommandSQL, MySqlConnection Connection)
        {
            MySqlCommand sqlCommand = new MySqlCommand(CommandSQL, Connection);
            sqlCommand.ExecuteNonQuery();
        }


        static public DataTable loadDataTable1(string CommandSql)
        {
            MySqlConnection connection = new MySqlConnection();
            var task = SetupConnectionToServer("SqlConnection");
            LoaderForm ld = new LoaderForm(task.AsTask());
            ld.ShowDialog();
            connection = task.Result;

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(CommandSql, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            connection.Close();
            return dt;
        }

        /// <summary>
        /// Установка соединения
        /// </summary>
        /// <returns>Асинхронный поток с открытым соединением</returns>
        async static public ValueTask<MySqlConnection> SetupConnectionToServer(string NameKeyConnection)
        {
            MySqlConnection connection = new MySqlConnection(Settings.ConfigurationLevel.ReadSetting(NameKeyConnection));
            await connection.OpenAsync();
            return connection;
        }

    }
}
