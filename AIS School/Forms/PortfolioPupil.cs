using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace AIS_School.Forms
{
    public partial class PortfolioPupil : Form
    {
        MySqlConnection _myConnection;
        private readonly MainMenuWindow mainMenuWindow;
        public PortfolioPupil(MainMenuWindow mainMenu)
        {
            InitializeComponent();
            mainMenuWindow = mainMenu;
            _myConnection = mainMenu.MyConnection;
            typeFilter.SelectedIndex = 0;
            loadData($"call sp_Get_Prizers ({mainMenu.user.ID})");
        }

        private void loadData(string select)
        {
            gridPrizers.Rows.Clear();
            DataTable dt = Classes.DBUtils.GetDataSetFromDataBase(select, _myConnection);
            foreach(DataRow row in dt.Rows)
            {
                gridPrizers.Rows.Add(row.ItemArray[0], //surname
                                       row.ItemArray[1], //first_name
                                       row.ItemArray[2], //second_name
                                       row.ItemArray[3], //name_event
                                       row.ItemArray[4], //date_event
                                       row.ItemArray[5], //terrain_factor
                                       row.ItemArray[6], //name_win
                                       row.ItemArray[7], // balls
                                       row.ItemArray[8] //name_event
                                       );
            }
        }

        private void typeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typeFilter.SelectedIndex == 0)
            {
                ItemFilter.Enabled = false;
            } else
            {
                ItemFilter.Enabled = true;
            }
            if(typeFilter.SelectedIndex == 1)
            {
                DataTable table = Classes.DBUtils.GetDataSetFromDataBase($@"select concat(surname, ' ', first_name, ' ', second_name) as 'ФИО', pk_pupil from users, pupil, class, teacher
where fk_teacher = pk_teacher and
pk_users = pupil.FK_user and pk_class = fk_class and
teacher.fk_user = {mainMenuWindow.user.ID}", _myConnection);
                ItemFilter.DataSource = table;
                ItemFilter.DisplayMember = "ФИО";
                ItemFilter.ValueMember = "pk_pupil";
            }
            if (typeFilter.SelectedIndex == 2)
            {
                DataTable table = Classes.DBUtils.GetDataSetFromDataBase($@"select PK_event, CONCAT(name_event, ' ', DAY(date_event), '.', MONTH(date_event),'.',YEAR(date_event)) as 'event' 
from events, pupil, class, teacher, participation, users
where class.FK_teacher = PK_teacher and 
pupil.FK_user = pk_users and fk_class = pk_class and
FK_event = PK_Event and pk_pupil = fk_pupil and
teacher.fk_user = {mainMenuWindow.user.ID}", _myConnection);   
                ItemFilter.DataSource = table;
                ItemFilter.DisplayMember = "event";
                ItemFilter.ValueMember = "pk_event";
            }
        }
        private void ItemFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemFilter.SelectedIndex > 0)
            {
                if (typeFilter.SelectedIndex == 1)
                {
                    loadData($"call sp_Get_Prizers_filter_pupil({mainMenuWindow.user.ID}, {ItemFilter.SelectedValue})");
                }
                else
                    if (typeFilter.SelectedIndex == 2)
                {
                    loadData($"call sp_Get_Prizers_filter_event({mainMenuWindow.user.ID}, {ItemFilter.SelectedValue})");
                }
            }
        }
    }
}
