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
    public partial class addedUser : Form
    {
        AdminWindow _adminWindow;
        public addedUser(AdminWindow adminWindow )
        {
            InitializeComponent();
            _adminWindow = adminWindow;
            DateBirthPucker.Value = DateTime.Now;
            loadCombobxes();
        }
        DataTable tableClass;
        private void loadCombobxes()
        {
            tableClass = Classes.DBUtils.GetDataSetFromDataBase("SELECT pk_class, CONCAT(number_class, leater) as 'class_name', fk_teacher FROM schoolportfolio.class;", _adminWindow.MyConnection);
            classBox.DataSource = tableClass;
            classBox.DisplayMember = "class_name";
            classBox.ValueMember = "pk_class";
            DataTable tablePosition = Classes.DBUtils.GetDataSetFromDataBase("SELECT * FROM schoolportfolio.position;", _adminWindow.MyConnection);
            positionCombo.DataSource = tablePosition;
            positionCombo.DisplayMember = "name_position";
            positionCombo.ValueMember = "pk_position";
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordBox.PasswordChar = (char)0;
            }
            else
            {
                passwordBox.PasswordChar = '•';
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            loginBox.Text = "";
            passwordBox.Text = "";
            SurnameBox.Text = "";
            FirstNameBox.Text = "";
            SecondNameBox.Text = "";
            DateBirthPucker.Value = DateTime.Now;
            NumberPhone.Text = "";
            emailBox.Text = "";
        }

        private void teacherRadio_CheckedChanged(object sender, EventArgs e)
        {
            positionCombo.Visible = false;
            positionLabel.Visible = false;
            classLabel.Visible = true;
            classBox.Visible = true;
        }

        private void pupilRadio_CheckedChanged(object sender, EventArgs e)
        {
            positionCombo.Visible = false;
            positionLabel.Visible = false;
            classLabel.Visible = true;
            classBox.Visible = true;
        }

        private void adminRadio_CheckedChanged(object sender, EventArgs e)
        {
            positionCombo.Visible = true;
            positionLabel.Visible = true;
            classLabel.Visible = false;
            classBox.Visible = false;
        }
 
        private void classBox_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void exampleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pupilRadio.Checked)
                {

                    Classes.DBUtils.ExecuteSqlCommand($@"call sp_Insert_pupil('{loginBox.Text}', 
'{passwordBox.Text}', '{SurnameBox.Text}', '{FirstNameBox.Text}', '{SecondNameBox.Text}', '{DateBirthPucker.Value.Date.ToShortDateString()}', 
'{NumberPhone.Text}', '{emailBox.Text}', {classBox.SelectedValue});", _adminWindow.MyConnection);
                    MessageBox.Show("Запись о ученике добавлена.", "Запись добавлена", MessageBoxButtons.OK);
                }
                if (adminRadio.Checked)
                {
                    Classes.DBUtils.ExecuteSqlCommand($@"call sp_insert_admin('{loginBox.Text}', 
'{passwordBox.Text}', '{SurnameBox.Text}', '{FirstNameBox.Text}', '{SecondNameBox.Text}', '{DateBirthPucker.Value.Date.ToShortDateString()}', 
'{NumberPhone.Text}', '{emailBox.Text}', {positionCombo.SelectedValue});", _adminWindow.MyConnection);
                    MessageBox.Show("Запись о администраторе добавлена.", "Запись добавлена", MessageBoxButtons.OK);
                }
                if (teacherRadio.Checked)
                {
                    DataTable dt = Classes.DBUtils.GetDataSetFromDataBase($@"select * from class where PK_class = {classBox.SelectedValue}", _adminWindow.MyConnection);
                    if (dt.Rows[0].ItemArray[3].ToString() != "")
                    {
                        var message = MessageBox.Show("У данного класса уже приставлен классный руководитель. Продолжить?", "Конфликт записей", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (message == DialogResult.Yes)
                        {
                            InsertTeacher();
                        }
                    }
                    else
                    {
                        Classes.DBUtils.ExecuteSqlCommand($@"call sp_insert_teacher('{loginBox.Text}', 
'{passwordBox.Text}', '{SurnameBox.Text}', '{FirstNameBox.Text}', '{SecondNameBox.Text}', '{DateBirthPucker.Value.Date.ToShortDateString()}', 
'{NumberPhone.Text}', '{emailBox.Text}', {classBox.SelectedValue});", _adminWindow.MyConnection);
                        MessageBox.Show("Запись о учителе добавлена.", "Запись добавлена", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertTeacher()
        {
            Classes.DBUtils.ExecuteSqlCommand($@"call sp_insert_teacher('{loginBox.Text}', 
'{passwordBox.Text}', '{SurnameBox.Text}', '{FirstNameBox.Text}', '{SecondNameBox.Text}', '{DateBirthPucker.Value.Date.ToShortDateString()}', 
'{NumberPhone.Text}', '{emailBox.Text}', {classBox.SelectedValue});", _adminWindow.MyConnection);
            MessageBox.Show("Запись о учителе добавлена.", "Запись добавлена", MessageBoxButtons.OK);
        }

        private void positionCombo_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void addedUser_Load(object sender, EventArgs e)
        {

        }

        private void canscelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
