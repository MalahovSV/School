using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_School
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            this.KeyPreview = true;
            eventsClickOnButton();
        }

        private void eventsClickOnButton()
        {
            LoginButton.Click += (s, e) => 
            {
                //Forms.MainMenuWindow mm = new Forms.MainMenuWindow();
                //mm.Show();
                Classes.Authorization.User user = Classes.Authorization.Аuthentication.CheckDataUser(loginUser.Text, passwordUser.Text);
                if (user != null)
                {
                    Forms.MainMenuWindow mainMenu = new Forms.MainMenuWindow(user, this);
                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Логин и/или пароль не верны.", "Ошибка аутентификации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            viewPasswordCheck.CheckedChanged += (s, e) =>
            {
                if (viewPasswordCheck.Checked)
                {
                    passwordUser.PasswordChar = (char)0;
                }
                else
                {
                    passwordUser.PasswordChar = '•';
                }
            };
        }


        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.C && e.Alt)
            {
                Forms.ConnectDataBaseWindow connectDataBase = new Forms.ConnectDataBaseWindow();
                connectDataBase.ShowDialog();
                e.Handled = true;
            }
        }
    }
}
