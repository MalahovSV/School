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
    public partial class TeacherTable : Form

    {
        AdminWindow _adminWindow;
        public TeacherTable(AdminWindow adminWindow)
        {
            InitializeComponent();
            _adminWindow = adminWindow;
            loadData("call sp_Get_teacher();");
        }
        private void loadData(string command)
        {
            gridTeacher.Rows.Clear();
            DataTable table = Classes.DBUtils.GetDataSetFromDataBase(command, _adminWindow.MyConnection);
            gridTeacher.DataSource = table;
            gridTeacher.Columns[1].CellTemplate.Style.ForeColor = Color.OrangeRed;
            gridTeacher.Columns[0].CellTemplate.Style.ForeColor = Color.DarkViolet;
            
            foreach (DataGridViewColumn column in gridTeacher.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
        }
    }
}
