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
    /// <summary>
    /// Главное меню
    /// </summary>
    public partial class MainMenuWindow : Form
    {
        public readonly Classes.Authorization.User user;
        private readonly Authorization authorization;
        /// <summary>
        /// Конструктор главного меню
        /// </summary>
        /// <param name="user">Класс пользователь</param>
        public MainMenuWindow(Classes.Authorization.User user, Authorization authorization)
        {
            InitializeComponent();
            EventsButton();
            this.user = user;
            this.authorization = authorization;
            authorization.Hide();
            CheckRole();
        }

        private protected void CheckRole()
        {
            if (user.Role.ToLower() == "sysadmin")
            {
                administratedButton.Enabled = true;
                partfolioButton.Enabled = true;
                extracurricularActivitiesButton.Enabled = true;
                achivementsButton.Enabled = true;
                SettingsButton.Enabled = true;
                HelpButton.Enabled = true;
            }
            if (user.Role.ToLower() == "admin")
            {
                administratedButton.Enabled = true;
                partfolioButton.Enabled = true;
                extracurricularActivitiesButton.Enabled = true;
                achivementsButton.Enabled = true;
                SettingsButton.Enabled = true;
                HelpButton.Enabled = true;
            }
            if (user.Role.ToLower() == "teacher")
            {
                partfolioButton.Enabled = true;
                extracurricularActivitiesButton.Enabled = true;
                achivementsButton.Enabled = true;
                SettingsButton.Enabled = true;
                HelpButton.Enabled = true;
            }
            if (user.Role.ToLower() == "pupil")
            {
                partfolioButton.Enabled = true;
                extracurricularActivitiesButton.Enabled = true;
                achivementsButton.Enabled = true;
                SettingsButton.Enabled = true;
                HelpButton.Enabled = true;
            }
        }

        private void EventsButton()
        {
            administratedButton.Click += (s, e) =>
            {
                Forms.AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
            };
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            DialogResult result = MessageBox.Show("Вернуться к авторизации?", "Завершение работы программы", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                authorization.Show();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                authorization.Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            
        }

        private void PartfolioButton_Click(object sender, EventArgs e)
        {
            PortfolioPupil portfolioPupil = new PortfolioPupil(this);
            portfolioPupil.Show();
        }

        private void extracurricularActivitiesButton_Click(object sender, EventArgs e)
        {
            RatingPupil ratingPupil = new RatingPupil(this);
            ratingPupil.Show();
        }
    }
}
