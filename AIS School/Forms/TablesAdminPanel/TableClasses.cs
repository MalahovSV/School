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
    public partial class TableClasses : Form
    {
        AdminWindow _adminWindow;
        public TableClasses(AdminWindow adminWindow)
        {
            InitializeComponent();
            _adminWindow = adminWindow;
            loadData("select * from class;");
        }

        private void loadData(string command)
        {
            gridClasses.Rows.Clear();
            DataTable table = Classes.DBUtils.GetDataSetFromDataBase(command, _adminWindow.MyConnection);
            gridClasses.DataSource = table;

            gridClasses.Columns[0].CellTemplate.Style.ForeColor = Color.DarkGreen;
            gridClasses.Columns[1].CellTemplate.Style.ForeColor = Color.OrangeRed;
            gridClasses.Columns[2].CellTemplate.Style.ForeColor = Color.DarkBlue;
            foreach (DataGridViewColumn column in gridClasses.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void updateData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таблица обновлена", "Успешно", MessageBoxButtons.OK);
        }
    }
}
