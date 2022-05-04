using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_School.Forms
{
    public partial class ConnectDataBaseWindow : Form
    {
        MySqlConnectionStringBuilder stringBuilder;      
        public ConnectDataBaseWindow()
        {
            InitializeComponent();
            eventsButtonClick();
        }

        private void eventsButtonClick()
        {
            createConnectButton.Click += (s, e) =>
            {
                checkDataInTextBox();
                addedRecordInConfig();
            };

            viewPasswordCheck.CheckedChanged += (s, e) =>
            {
                if (viewPasswordCheck.Checked)
                {
                    passwordBox.PasswordChar = (char)0;
                }
                else
                {
                    passwordBox.PasswordChar = '•';
                }
            };

        }

        private void checkDataInTextBox()
        {
            bool flag = false;
            flag = checkTextBox(serverNameBox);
            flag = checkTextBox(userNameBox);
            flag = checkTextBox(passwordBox);
            if (dataBasesList.Text.Equals(""))
            {
                dataBasesList.BackColor = Color.LightCoral;
                flag = true;
            }
            if (flag)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkTextBox(TextBox box)
        {
            if (box.Text.Equals(""))
            {
                box.BackColor = Color.LightCoral;
                return true;
            }
            return false;
        }

        

        private void dataBasesList_DropDown(object sender, EventArgs e)
        {
            dataBasesList.Items.Clear();
            stringBuilder = new MySqlConnectionStringBuilder
            {
                Server = serverNameBox.Text,
                UserID = userNameBox.Text,
                Password = passwordBox.Text
            };
            searchDatabases(stringBuilder);
        }

        private void searchDatabases(MySqlConnectionStringBuilder stringBuilder)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(stringBuilder.ConnectionString))
                {
                    connection.Open();

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("show databases;", connection);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dataBasesList.Items.Add(row.ItemArray[0].ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addedRecordInConfig()
        {

            Classes.Settings.ConfigurationLevel.AddUpdateAppSettings("SqlConnection", stringBuilder.ConnectionString);

        }

        private void dataBasesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringBuilder.Database = dataBasesList.Text;
        }
    }
}
