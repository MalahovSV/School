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
    public partial class TablePupils : Form
    {
        AdminWindow _adminWindow;
        public TablePupils(AdminWindow adminWindow)
        {
            InitializeComponent();
            _adminWindow = adminWindow;
            loadData("call sp_Get_Pupils();");
        }

        private void loadData(string command)
        {
            gridPupils.Rows.Clear();
            DataTable table = Classes.DBUtils.GetDataSetFromDataBase(command, _adminWindow.MyConnection);
            gridPupils.DataSource = table;
            
            gridPupils.Columns[0].CellTemplate.Style.ForeColor = Color.DarkGreen;
            gridPupils.Columns[1].CellTemplate.Style.ForeColor = Color.OrangeRed;
            gridPupils.Columns[2].CellTemplate.Style.ForeColor = Color.DarkBlue;
            foreach (DataGridViewColumn column in gridPupils.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }


    }
}
