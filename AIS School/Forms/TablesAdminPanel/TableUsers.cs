using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_School.Forms.TablesAdminPanel
{
    public partial class TableUsers : Form
    {
        AdminWindow _adminWindow;
        MySqlDataAdapter myAdapter;
        DataTable tableUsers;
        public TableUsers(AdminWindow aw)
        {
            InitializeComponent();
            _adminWindow = aw;
            loadData("call sp_get_users();");

        }

        private void loadData(string command)
        {
            gridUsers.Rows.Clear();
            tableUsers = Classes.DBUtils.GetDataSetFromDataBase(command, _adminWindow.MyConnection);
            gridUsers.DataSource = tableUsers;

            gridUsers.Columns[0].CellTemplate.Style.ForeColor = Color.OrangeRed;
            foreach(DataGridViewColumn column in gridUsers.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            gridUsers.Columns[0].FillWeight = 60;
        }

        private void updateData_Click(object sender, EventArgs e)
        {
            //#region InsertCommandSubscribers
            //myAdapter.InsertCommand = new MySqlCommand("insert into tariff values (NULL, @name_tariff, @price, @speed, @about)", _adminWindow.MyConnection);
            //myAdapter.InsertCommand.Parameters.Add("@name_tariff", MySqlDbType.VarChar, 30, "Наименование тарифа");
            //myAdapter.InsertCommand.Parameters.Add("@price", MySqlDbType.VarChar, 30, "Цена");
            //myAdapter.InsertCommand.Parameters.Add("@speed", MySqlDbType.VarChar, 30, "Скорость (Мбит/с)");
            //myAdapter.InsertCommand.Parameters.Add("@about", MySqlDbType.VarChar, 10000, "Подробно");
            //#endregion

            //#region DeleteCommandSubscriber
            //myAdapter.DeleteCommand = new MySqlCommand("delete from tariff where id_tariff = @id_tariff", _adminWindow.MyConnection);
            //myAdapter.DeleteCommand.Parameters.Add("@id_tariff", MySqlDbType.VarChar, 5, "ID");
            //#endregion

            //#region UpdateCommandSubscriber

            //myAdapter.UpdateCommand = new MySqlCommand(@"	update tariff set 	name_tariff = @name_tariff,
            //                                                                                price = @price,
            //                                                                                speed = @speed,
            //                                                                                about = @about
            //                                                        where id_tariff = @id_tariff", _adminWindow.MyConnection);

            //myAdapter.UpdateCommand.Parameters.Add("@id_tariff", MySqlDbType.VarChar, 5, "ID");
            //myAdapter.UpdateCommand.Parameters.Add("@name_tariff", MySqlDbType.VarChar, 30, "Наименование тарифа");
            //myAdapter.UpdateCommand.Parameters.Add("@price", MySqlDbType.VarChar, 30, "Цена");
            //myAdapter.UpdateCommand.Parameters.Add("@speed", MySqlDbType.VarChar, 30, "Скорость (Мбит/с)");
            //myAdapter.UpdateCommand.Parameters.Add("@about", MySqlDbType.VarChar, 10000, "Подробно");

            //#endregion

            //myAdapter.Update(tableUsers);
            //MessageBox.Show("Операции проведены успешно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //loadData("call sp_Get_Users();");
            MessageBox.Show("Операции проведены успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
