using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_School.Forms
{
    public partial class InsertAchiviment : Form
    {
        MainMenuWindow _mainMenuWindow;

        public InsertAchiviment(MainMenuWindow mainMenuWindow)
        {
            InitializeComponent();
            _mainMenuWindow = mainMenuWindow;
            loadComboBoxes();
        }

        private void loadComboBoxes()
        {
            DataTable eventTable = Classes.DBUtils.GetDataSetFromDataBase($@"select PK_event, CONCAT(name_event, ' ', DAY(date_event), '.', MONTH(date_event),'.',YEAR(date_event)) as 'event' 
from events", _mainMenuWindow.MyConnection);
            eventCombo.DataSource = eventTable;
            eventCombo.DisplayMember = "event";
            eventCombo.ValueMember = "pk_event";
            
            DataTable pupilsTable = Classes.DBUtils.GetDataSetFromDataBase($@"select concat(surname, ' ', first_name, ' ', second_name) as 'ФИО', pk_pupil from users, pupil, class, teacher
where fk_teacher = pk_teacher and
pk_users = pupil.FK_user and pk_class = fk_class and
teacher.fk_user = {_mainMenuWindow.user.ID}", _mainMenuWindow.MyConnection);
            pupilsCombo.DataSource = pupilsTable;
            pupilsCombo.DisplayMember = "ФИО";
            pupilsCombo.ValueMember = "pk_pupil";

            DataTable prizzersTable = Classes.DBUtils.GetDataSetFromDataBase($@"SELECT * FROM schoolportfolio.prize_winning_coefficient;", _mainMenuWindow.MyConnection);
            prizzersCoeffCombo.DataSource = prizzersTable;
            prizzersCoeffCombo.DisplayMember = "name_win_coeff";
            prizzersCoeffCombo.ValueMember = "pk_win_coeff";
        }

        private void canscelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {

        }

        private void exampleButton_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.DBUtils.ExecuteSqlCommand($@"call sp_insert_participation ({pupilsCombo.SelectedValue}, {eventCombo.SelectedValue}, {prizzersCoeffCombo.SelectedValue})", _mainMenuWindow.MyConnection);
                MessageBox.Show("Запись добавлена", "Успешно", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
